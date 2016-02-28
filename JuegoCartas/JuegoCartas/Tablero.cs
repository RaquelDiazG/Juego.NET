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
        private int filas;
        private int columnas;
        public int puntos { get; set; }
        private int tiempo;
        public string palabra { get; set; }
        private int posicion;
        private int minLetras;
        private int maxLetras;

        public Tablero(int f, int c)
        {
            //Iniciamos las variables
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
            palabra = getPalabraBBDD();

             //Introducimos las letras de la palabra en el tablero
            Random aleatorio = new Random();
            for(int i=0;i<palabra.Length;i++)
            {
                bool insertada = false;
                do
                {
                    insertada = insertarLetra(aleatorio, palabra[i].ToString());
                }
                while (!insertada);
            }

            //Rellenamos el tablero con otras letras
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (!hayCarta(i, j))
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

        private bool insertarLetra(Random aleatorio, string letra)
        {
            int fila_aleatoria = aleatorio.Next(filas);
            int columna_aleatoria = aleatorio.Next(columnas);
            if (!hayCarta(fila_aleatoria, columna_aleatoria))
            {
                cartas[fila_aleatoria, columna_aleatoria] = new Carta(letra);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void visualizar()
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

        public void mostrarCarta(int f, int c)
        {
            cartas[f, c].mostrar();
        }

        public void ocultarCarta(int f, int c)
        {
            cartas[f, c].ocultar();
        }

        private string getPalabraBBDD()
        {
            //Conexion a BBDD
            BDEntidades entidades = new BDEntidades();

            //Consulta LINQ

            /*
            SELECT TOP 1 Original FROM Palabras
            WHERE LEN(Original)=3
            ORDER BY NEWID();
            ;
            */
            Random random = new Random();
            int aleatorio = random.Next(entidades.Palabras.Count());
            string respuesta = (from palabra in entidades.Palabras
                                where palabra.Original.Length >= minLetras
                                where palabra.Original.Length <= maxLetras
                                orderby aleatorio
                                select palabra.Original).FirstOrDefault();
            return respuesta;

        }

        private bool hayCarta(int filas, int columnas)
        {

            return (cartas[filas, columnas] != null);
        }

        public string queHayEn(int f, int c)
	    {
	        return cartas[f, c].ToString();
	    }

        public bool coincidePosicionPalabra(int f, int c)
        {
            string letra = cartas[f, c].ToString();
            int posicion_palabra = palabra.IndexOf(letra);
            return posicion==posicion_palabra;
        }

        public void aumentarPosicion()
        {
            posicion++;
            //comprobamos si ha ganado
            if (posicion == palabra.Length)
            {
                GuardarPuntuacion form=new GuardarPuntuacion(puntos, tiempo);
                form.Show();
            }
           
        }
        public void resetearPosicion()
        {
            posicion = 0;
        }

        public void aumentarPuntos()
        {
            puntos++;
        }

    }
}
