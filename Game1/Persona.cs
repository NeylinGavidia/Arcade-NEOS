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
        public string decl;

        public override string ToString()
        {
            return "__________________________________________\n" +
                   "Nombre: " + nomb + "\n" +
                   "Rol: " + rol + "\n" +
                   "Habitación: " + habi + "\n" +
                   "___________________________________________\n";
        }
    }
}
