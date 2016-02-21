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
    public partial class Form1: Form
    {
        private int numFilas = 2;
        private int numColumnas = 2;
        private Tablero tablero;
        private Button[,] botones;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializamos las variables
            tablero = new Tablero(numFilas, numColumnas);
            botones = new Button[numFilas, numColumnas];

            //Mostramos la palabra
            label1.Text = tablero.palabra;

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

                }
            }
            actualizaIU();
        }

        private void mouseUp(object sender, EventArgs e)
        {
            //MessageBox.Show("["+((MiBoton)sender).f+ "," + ((MiBoton)sender).c+ "]");
            tablero.ocultarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
            actualizaIU();
        }

        private void mouseDown(object sender, EventArgs e)
        {
            //MessageBox.Show("["+((MiBoton)sender).f+ "," + ((MiBoton)sender).c+ "]");
            tablero.mostrarCarta(((MiBoton)sender).f, ((MiBoton)sender).c);
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
                    /*
                    if (tablero.queHayEn(f, c).Equals("0"))
                    {
                        botones[f - 1, c - 1].Enabled = false;
                        botones[f - 1, c - 1].Text = "";
                    }
                    else if (tablero.queHayEn(f, c).Equals("B"))
                    {
                        botones[f - 1, c - 1].Image = global::BuscaminasVentana.Properties.Resources.bomba;
                    }*/
                }
            }
        }

    }
}
