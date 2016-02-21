using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Carta
    {
        public bool levantada { get; set; }
        public string letra { get; set; }

        //Constructor

        public Carta(string l)
        {
            levantada = false;
            letra = l;
        }

        public void mostrar()
        {
            levantada = true;
        }

        public void ocultar()
        {
            levantada = false;
        }

        public override string ToString()
        {
            if (!levantada)
            {
                return "X";
            }
            else {
                return letra;
            }
        }
    }
}
