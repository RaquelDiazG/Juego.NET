using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCartas
{
    public partial class Puntuaciones : Form
    {
        public Puntuaciones()
        {
            InitializeComponent();
        }

        private void Puntuaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDDataSet.Puntuaciones' Puede moverla o quitarla según sea necesario.
            this.puntuacionesTableAdapter.Fill(this.bDDataSet.Puntuaciones);

        }
    }
}
