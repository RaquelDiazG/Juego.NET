﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Juego
{
    public partial class Juego: Form
    {
        private int numFilas;
        private int numColumnas;
        private string nivel;
        private Tablero tablero;
        private Button[,] botones;
        private SoundPlayer player;
        private int segundos=0;

        public Juego(int filas, int columnas, string nivel)
        {
            InitializeComponent();
            this.numFilas = filas;
            this.numColumnas = columnas;
            this.nivel = nivel;
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            //Centrar en la pantalla
            this.CenterToScreen();

            //Autoajustar la ventana
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //Sonido
            player = new SoundPlayer(global::JuegoCartas.Properties.Resources.musica);
            player.PlayLooping();
            btn_musica.Tag = "sonidoOn";

            //Inicializamos las variables
            tablero = new Tablero(numFilas, numColumnas,nivel);
            botones = new Button[numFilas, numColumnas];

            //Iniciamos el contador de tiempo
            timer.Enabled = true;
            timer.Start();

            //Mostramos la palabra
            label1.Text = tablero.palabra;

            //Mostramos los movimientos
            label2.Text = "0";

            //Limpiamos los controles existentes
            tableLayoutPanel1.Controls.Clear();

            //Limpiamos los estilos de líneas y columnas existentes
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            //Asignamos el numero de filas y columnas
            this.tableLayoutPanel1.RowCount = numFilas;
            this.tableLayoutPanel1.ColumnCount = numColumnas;
            
            //Rellenamos el layout con botones creados dinamicamente
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numColumnas; j++)
                {
                    //insertamos el boton
                    botones[i, j] = new MiBoton(i,j);
                    this.tableLayoutPanel1.Controls.Add(botones[i, j],i,j);

                    //asociamos dos controladores de eventos para cada boton
                    botones[i, j].MouseUp += new MouseEventHandler(this.MouseUp);
                    botones[i, j].MouseDown += new MouseEventHandler(this.MouseDown);

                    //cambiamos el tamaño del boton
                    botones[i, j].Width = 80;
                    botones[i, j].Height = 80;

                    //cambiamos el tamaño de la fuente
                    botones[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    //añadimos las imagenes a los botones
                    PonerImagenCarta(i, j);

                }
            }
            ActualizaIU();
        }

        private void MouseDown(object sender, EventArgs e)
        {
            //MessageBox.Show("["+((MiBoton)sender).f+ "," + ((MiBoton)sender).c+ "]");
            //mostramos la carta
            tablero.MostrarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
            QuitarImagenCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
            //aumentamos los puntos
            tablero.AumentarPuntos();
            label2.Text = tablero.puntos.ToString();
            //actualizamos el tablero
            ActualizaIU();
        }

        private void MouseUp(object sender, EventArgs e)
        {
            //comprobamos si la carta que se levanta coincide con la siguiente letra de la palabra
            if (tablero.CoincidePosicionPalabra(((MiBoton)sender).f, ((MiBoton)sender).c))
            {
                //mostramos la carta
                tablero.MostrarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
                //deshabilitamos el boton
                ((MiBoton)sender).Enabled = false;
                //aumentamos el contador para identificar la siguiente letra
                tablero.AumentarPosicion();
            }
            else {
                //ocultamos todas las cartas y habilitamos todos los botones
                for (int i = 0; i < numFilas; i++)
                {
                    for (int j = 0; j < numColumnas; j++)
                    {
                        botones[i, j].Enabled = true;
                        tablero.OcultarCarta(i, j);
                        PonerImagenCarta(i, j);
                    }
                }
                //reseteamos el contador
                tablero.ResetearPosicion();
            }
            ActualizaIU();
        }

        public void ActualizaIU()
        {
            for (int f = 0; f < numFilas; f++)
            {
                for (int c = 0; c < numColumnas; c++)
                {
                    //Texto en el boton
                    botones[f, c].Text = tablero.QueHayEn(f, c);
                }
            }
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }


        private void PonerImagenCarta(int i, int j)
        {
            botones[i, j].Image = global::JuegoCartas.Properties.Resources.mosaico;
        }

        private void QuitarImagenCarta(int i, int j)
        {
            botones[i,j].Image = null;
            botones[i,j].BackColor = Color.WhiteSmoke;
        }

        private void Btn_repetir_Click(object sender, EventArgs e)
        {
            Juego nuevo=new Juego(numFilas, numColumnas,nivel);
            nuevo.Show();
            this.Dispose();
        }

        private void Btn_musica_Click(object sender, EventArgs e)
        {
            if (btn_musica.Tag.ToString() == "sonidoOn")
            {
                player.Stop();
                btn_musica.Image = global::JuegoCartas.Properties.Resources.sonidoOff;
                btn_musica.Tag = "sonidoOff";
            }
            else
            {
                player.PlayLooping();
                btn_musica.Image = global::JuegoCartas.Properties.Resources.sonidoOn;
                btn_musica.Tag = "sonidoOn";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tablero.finPartida)
            {
                timer.Stop();
            }
            else
            {
                segundos++;
                label_tiempo.Text = Convert.ToString(segundos);
                tablero.tiempo = segundos;
            }
        }

        private void Juego_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.Stop();
        }
    }
}
