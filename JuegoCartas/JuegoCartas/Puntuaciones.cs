using Juego;
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
            //Centrar en la pantalla
            this.CenterToScreen();
            // Carga datos en la tabla 'bDDataSet.Puntuaciones'
            this.puntuacionesTableAdapter.Fill(this.bDDataSet.Puntuaciones);
            // Ordenar los datos por la columna de movimientos
            this.dataGridView1.Sort(this.movimientosDataGridViewTextBoxColumn, ListSortDirection.Ascending);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
