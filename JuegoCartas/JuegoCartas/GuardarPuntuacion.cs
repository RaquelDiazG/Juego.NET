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
    public partial class GuardarPuntuacion : Form
    {
        private int movimientos;
        private int tiempo;

        public GuardarPuntuacion(int movimientos, int tiempo)
        {
            InitializeComponent();
            this.movimientos = movimientos;
            this.tiempo = tiempo;
            //Centrar en la pantalla
            this.CenterToScreen();
        }

        private void btn_guardar_puntuacion_Click(object sender, EventArgs e)
        {
            string usuario = nombre.Text;

            //Conexion a BBDD
            BDEntidades entidades = new BDEntidades();

            //Crear puntuacion
            Puntuacione puntuacion = new Puntuacione();
            puntuacion.Nombre = usuario;
            puntuacion.Movimientos = movimientos;
            puntuacion.Tiempo = tiempo;

            //Guardar puntuacion en BBDD
            entidades.Puntuaciones.Add(puntuacion);
            entidades.SaveChanges();

            //Ocultar ventana
            this.Hide();
        }
    }
}
