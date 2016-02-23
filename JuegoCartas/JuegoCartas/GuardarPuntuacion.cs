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
        private int puntos;
        private int tiempo;

        public GuardarPuntuacion(int puntos, int tiempo)
        {
            InitializeComponent();
            this.puntos = puntos;
            this.tiempo = tiempo;
        }

        private void btn_guardar_puntuacion_Click(object sender, EventArgs e)
        {
            string usuario = nombre.Text;

            //Conexion a BBDD
            BDEntidades entidades = new BDEntidades();

            //Crear puntuacion
            Puntuacione puntuacion = new Puntuacione();
            puntuacion.Nombre = usuario;
            puntuacion.Puntos = puntos;
            puntuacion.Tiempo = tiempo;

            //Guardar puntuacion en BBDD
            entidades.Puntuaciones.Add(puntuacion);
            entidades.SaveChanges();

            //Ocultar ventana
            this.Hide();
        }
    }
}
