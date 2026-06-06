using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Persona
    {
        public string nomb;
        public string rol;
        public string habi;

        public override string ToString()
        {
            return "==================================\r\n" +
                   "Nombre: " + nomb + "\r\n" +
                   "Rol: " + rol + "\r\n" +
                   "Habitación: " + habi + "\r\n" +
                   "==================================\r\n";
        }
    }
}
