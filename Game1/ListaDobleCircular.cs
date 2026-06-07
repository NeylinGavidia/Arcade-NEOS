using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ListaDobleCircular
    {
        public Nodo prim = null;
        public Nodo ult = null;
        public void Insertar(Persona p)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = p;

            if (prim == null)
            {
                prim = nuevo;
                ult = nuevo;
            }
            else
            {
                ult.sig = nuevo;
                nuevo.ant = ult;
                ult = nuevo;
            }
            ult.sig = prim;
            prim.ant = ult;
        }
    }
}
