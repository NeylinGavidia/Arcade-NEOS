using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Fruta
    {
        public int codigo;
        public string nombre;
        public string color;
        public string origen;
        public string pista;

        public override string ToString()
        {
            return "==================================\n" +
                   "Codigo: " + codigo + "\n" +
                   "Nombre: " + nombre + "\n" +
                   "Color: " + color + "\n" +
                   "Origen: " + origen + "\n" +
                   "==================================\n";
        }
    }
}
