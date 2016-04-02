using JuegoCartas;
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
    public partial class Inicio : Form
    {
        private int facil = 2;
        private int medio = 3;
        private int dificil = 4;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            //Centrar en la pantalla
            this.CenterToScreen();

            //Autoajustar la ventana
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void Btn_facil_Click(object sender, EventArgs e)
        {
            Juego form=new Juego(facil, facil,"Fácil");
            form.Show();
            this.Hide();
        }

        private void Btn_medio_Click(object sender, EventArgs e)
        {
            Juego form = new Juego(medio, medio,"Medio");
            form.Show();
            this.Hide();
        }

        private void Btn_dificil_Click(object sender, EventArgs e)
        {
            Juego form = new Juego(dificil, dificil,"Difícil");
            form.Show();
            this.Hide();
        }

        private void Btn_puntuaciones_Click(object sender, EventArgs e)
        {
            Puntuaciones form = new Puntuaciones();
            form.Show();
            this.Hide();
        }

    }
}
