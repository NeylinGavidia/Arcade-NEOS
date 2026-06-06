using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Nodo
    {
        public string nombreSala;
        public string descripcion;

        public Nodo izq;
        public Nodo der;

        public Enemigo enemigo;

        public int recompensaOro;
        public int recompensaVida;
    }
}
