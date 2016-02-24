using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Juego: Form
    {
        private int numFilas;
        private int numColumnas;
        private Tablero tablero;
        private Button[,] botones;

        public Juego(int filas, int columnas)
        {
            InitializeComponent();
            numFilas = filas;
            numColumnas = columnas;
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            //Autoajustar la ventana
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //Inicializamos las variables
            tablero = new Tablero(numFilas, numColumnas);
            botones = new Button[numFilas, numColumnas];

            //Mostramos la palabra
            label1.Text = tablero.palabra;

            //Mostramos los puntos
            label2.Text = "0";

            //Rellenamos el layout con botones creados dinamicamente
            this.tableLayoutPanel1.RowCount = numFilas;
            this.tableLayoutPanel1.ColumnCount = numColumnas;
            
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numColumnas; j++)
                {
                    //insertamos el boton
                    botones[i, j] = new MiBoton(i,j);
                    this.tableLayoutPanel1.Controls.Add(botones[i, j]);

                    //asociamos dos controladores de eventos para cada boton
                    botones[i, j].MouseUp += new MouseEventHandler(this.mouseUp);
                    botones[i, j].MouseDown += new MouseEventHandler(this.mouseDown);

                    //cambiamos el tamaño del boton
                    botones[i, j].Width = 80;
                    botones[i, j].Height = 80;

                    //añadimos las imagenes a los botones
                    ponerImagenCarta(i, j);

                }
            }
            actualizaIU();
        }

        private void mouseDown(object sender, EventArgs e)
        {
            //MessageBox.Show("["+((MiBoton)sender).f+ "," + ((MiBoton)sender).c+ "]");
            //mostramos la carta
            tablero.mostrarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
            quitarImagenCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
            //aumentamos los puntos
            tablero.aumentarPuntos();
            label2.Text = tablero.puntos.ToString();
            //actualizamos el tablero
            actualizaIU();
        }

        private void mouseUp(object sender, EventArgs e)
        {
            //comprobamos si la carta que se levanta coincide con la siguiente letra de la palabra
            if (tablero.coincidePosicionPalabra(((MiBoton)sender).f, ((MiBoton)sender).c))
            {
                //mostramos la carta
                tablero.mostrarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
                //deshabilitamos el boton
                ((MiBoton)sender).Enabled = false;
                //aumentamos el contador para identificar la siguiente letra
                tablero.aumentarPosicion();
            }
            else {
                //ocultamos todas las cartas y habilitamos todos los botones
                for (int i = 0; i < numFilas; i++)
                {
                    for (int j = 0; j < numColumnas; j++)
                    {
                        botones[i, j].Enabled = true;
                        tablero.ocultarCarta(i, j);
                        ponerImagenCarta(i, j);
                    }
                }
                //reseteamos el contador
                tablero.resetearPosicion();
            }
            actualizaIU();
        }

        public void actualizaIU()
        {
            for (int f = 0; f < numFilas; f++)
            {
                for (int c = 0; c < numColumnas; c++)
                {
                    //Texto en el boton
                    botones[f, c].Text = tablero.queHayEn(f, c);
                }
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }


        private void ponerImagenCarta(int i, int j)
        {
            botones[i, j].Image = global::JuegoCartas.Properties.Resources.carta_detras;
        }

        private void quitarImagenCarta(int i, int j)
        {
            botones[i,j].Image = null;
            botones[i,j].BackColor = Color.WhiteSmoke;
        }
    }
}
