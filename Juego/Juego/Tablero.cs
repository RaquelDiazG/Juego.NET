using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Tablero
    {
        private Carta[,] cartas;
        private int filas;
        private int columnas;
        private int puntos;
        private int tiempo;
        public string palabra { get; set; }
        private int posicion;
        private string[] abecedario= { "A", "B", "C", "D", "E", "F", "G" };

        public Tablero(int f, int c)
        {
            //Iniciamos las variables
            filas = f;
            columnas = c;
            //Creamos el tablero 
            cartas = new Carta[f, c];

            //Recuperamos una palabra de BBDD
            palabra = getPalabraBBDD();
            // string[] letras_palabra = palabra.Split(abecedario);
            string[] letras_palabra = { "S", "A", "L" };

             //Introducimos las letras de la palabra en el tablero
            Random aleatorio = new Random();
            foreach (string letra in letras_palabra)
            {
                bool insertada = false;
                do
                {
                    insertada = insertarLetra(aleatorio, letra);
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
                        //string letra_abecedario = abecedario[aleatorio.Next(abecedario.lenght())];
                        string letra_abecedario = "P";
                        if (!palabra.Contains(letra_abecedario))
                        {
                            cartas[i, j] = new Carta(letra_abecedario);
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
            //Recuperamos una palabra de la BBDD
            return "SAL";
        }

        private bool hayCarta(int filas, int columnas)
        {

            return (cartas[filas, columnas] != null);
        }

        public string queHayEn(int f, int c)
	    {
	        return cartas[f, c].ToString();
	    }
}
}
