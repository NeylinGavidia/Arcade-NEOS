using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Pila
    {
        public Nodo Cima = null;
        public void Apilar(Persona p)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = p;
            if (Cima == null)
            {
                Cima = nuevo;
            }
            else
            {
                nuevo.sig = Cima;
                Cima = nuevo;
            }
        }

        public Persona Desapilar()
        {
            Persona dato = null;
            if (Cima != null)
            {
                dato = Cima.dato;
                Cima = Cima.sig;
            }
            return dato;
        }
    }
}
