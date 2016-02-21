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

            //Rellenamos el layout con botones creados dinamicamente
            this.tableLayoutPanel1.RowCount = numFilas;
            this.tableLayoutPanel1.ColumnCount = numColumnas;
            
            for (int i = 0; i < numFilas; i++)
            {
                for (int j = 0; j < numColumnas; j++)
                {
                    botones[i, j] = new MiBoton(i,j);
                    botones[i, j].Text = "[" + i+ "," + j+"]";
                    this.tableLayoutPanel1.Controls.Add(botones[i, j]);

                    //asociamos un controlador de eventos para todos los botones
                    botones[i, j].Click += new EventHandler(this.OnClick);
                }
            }
            actualizaIU();
        }

        private void OnClick(object sender, EventArgs e)
        {
            //MessageBox.Show("["+((MiBoton)sender).f+ "," + ((MiBoton)sender).c+ "]");
            tablero.levantar(((MiBoton)sender).f, ((MiBoton)sender).c);
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
