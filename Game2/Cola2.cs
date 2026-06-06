using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Cola2
    {
        Nodo frente = null;
        Nodo final = null;

        public void Encolar(Fruta f)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = f;

            if (frente == null)
            {
                frente = nuevo;
            }
            else
            {
                final.sig = nuevo;
            }

            final = nuevo;
        }

        public Fruta Desencolar()
        {
            Fruta aux = null;

            if (frente != null)
            {
                aux = frente.dato;
                frente = frente.sig;
            }

            return aux;
        }

        public Fruta VerFrente()
        {
            if (frente == null)
                return null;

            return frente.dato;
        }

        public bool Vacia()
        {
            return frente == null;
        }
    }
}
