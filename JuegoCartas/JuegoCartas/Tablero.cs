using JuegoCartas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    class Tablero
    {
        private Carta[,] cartas;
        private string nivel;
        private int filas;
        private int columnas;
        public int puntos { get; set; }
        public int tiempo { get; set; }
        public string palabra { get; set; }
        private int posicion;
        private int minLetras;
        private int maxLetras;
        public bool finPartida { get; set; }

        public Tablero(int f, int c, string nivel)
        {
            //Iniciamos las variables
            tiempo = 0;
            finPartida = false;
            this.nivel = nivel;
            filas = f;
            columnas = c;
            posicion = 0;
            minLetras = 2;
            switch (filas)
            {
                case 2: maxLetras = 3; break;
                case 3: maxLetras = 5; break;
                case 4: maxLetras = 8; break;
            }

            //Creamos el tablero 
            cartas = new Carta[f, c];

            //Recuperamos una palabra de BBDD
            palabra = GetPalabraBBDD();

             //Introducimos las letras de la palabra en el tablero
            Random aleatorio = new Random();
            for(int i=0;i<palabra.Length;i++)
            {
                bool insertada = false;
                do
                {
                    insertada = InsertarLetra(aleatorio, palabra[i].ToString());
                }
                while (!insertada);
            }

            //Rellenamos el tablero con otras letras
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (!HayCarta(i, j))
                    { 
                        string letra_auxiliar = "♬";
                        if (!palabra.Contains(letra_auxiliar))
                        {
                            cartas[i, j] = new Carta(letra_auxiliar);
                        }
                    }
                }
            }
            
        }

        private bool InsertarLetra(Random aleatorio, string letra)
        {
            int fila_aleatoria = aleatorio.Next(filas);
            int columna_aleatoria = aleatorio.Next(columnas);
            if (!HayCarta(fila_aleatoria, columna_aleatoria))
            {
                cartas[fila_aleatoria, columna_aleatoria] = new Carta(letra);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Visualizar()
        {
            for (int i = 1; i < filas - 1; i++)
            {
                for (int j = 1; j < columnas - 1; j++)
                {
                    Console.Write(cartas[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void MostrarCarta(int f, int c)
        {
            cartas[f, c].mostrar();
        }

        public void OcultarCarta(int f, int c)
        {
            cartas[f, c].ocultar();
        }

        private string GetPalabraBBDD()
        {
            //Conexion a BBDD
            BDEntidades entidades = new BDEntidades();

            //Consulta LINQ - palabra aleatoria con longitud entre el maximo y el minimo
            Random random = new Random();
            var palabras = (from palabra in entidades.Palabras
                            where palabra.Original.Length >= minLetras
                            && palabra.Original.Length <= maxLetras
                            orderby palabra.Id
                            select palabra.Original);
            int aleatorio = random.Next(palabras.Count());
            return palabras.Skip(aleatorio).First();
        }

        private bool HayCarta(int filas, int columnas)
        {
            return (cartas[filas, columnas] != null);
        }

        public string QueHayEn(int f, int c)
	    {
	        return cartas[f, c].ToString();
	    }

        public bool CoincidePosicionPalabra(int f, int c)
        {
            string letra = cartas[f, c].ToString();
            int posicion_palabra = palabra.IndexOf(letra);
            return posicion==posicion_palabra;
        }

        public void AumentarPosicion()
        {
            posicion++;
            //comprobamos si ha ganado
            if (HaGanado())
            {
                GuardarPuntuacion form=new GuardarPuntuacion(nivel, puntos, tiempo);
                form.Show();
            }
           
        }

        public void ResetearPosicion()
        {
            posicion = 0;
        }

        public void AumentarPuntos()
        {
            puntos++;
        }

        public Boolean HaGanado()
        {
            finPartida = (posicion == palabra.Length);
            return finPartida;
        }
    }
}
