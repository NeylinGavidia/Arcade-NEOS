using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Nodo
    {
        public string texto;
        public Nodo Izquierda;
        public Nodo Derecha;

        public Nodo(string texto)
        {
            this.texto = texto;
            this.Izquierda = null;
            this.Derecha = null;
        }
    }
}
