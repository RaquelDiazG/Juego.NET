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
            //Autoajustar la ventana
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btn_facil_Click(object sender, EventArgs e)
        {
            Form1 form=new Form1(facil, facil);
            form.Show();
            this.Hide();
        }

        private void btn_medio_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(medio, medio);
            form.Show();
            this.Hide();
        }

        private void btn_dificil_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(dificil, dificil);
            form.Show();
            this.Hide();
        }

        private void btn_puntuaciones_Click(object sender, EventArgs e)
        {

        }

    }
}
