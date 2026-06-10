using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Game3
{
    public class TesoroPeru
    {
        public Arbol3 arbol;
        public Nodo actual;
        public List<string> inventario;

        public TesoroPeru()
        {
            arbol = new Arbol3();
            actual = arbol.raiz;
            inventario = new List<string>();
        }
        public void IrIzquierda()
        {
            if (actual.izq != null)
            {
                actual = actual.izq;
                ObtenerObjeto();
            }
        }
        public void IrDerecha()
        {
            if (actual.der != null)
            {
                actual = actual.der;
                ObtenerObjeto();
            }
        }
        private void ObtenerObjeto()
        {
            if (actual.objeto != null)
            {
                bool existe = false;

                foreach (string item in inventario)
                {
                    if (item == actual.objeto)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe == false)
                {
                    inventario.Add(actual.objeto);
                }
            }
        }
        public bool Perdio()
        {
            if (actual.derrota)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Gano()
        {
            bool pieza1 = false;
            bool pieza2 = false;
            bool pieza3 = false;
            bool llave = false;

            foreach (string item in inventario)
            {
                if (item == "Pieza1")
                    pieza1 = true;

                if (item == "Pieza2")
                    pieza2 = true;

                if (item == "Pieza3")
                    pieza3 = true;

                if (item == "Llave")
                    llave = true;
            }

            if (pieza1)
            {
                if (pieza2)
                {
                    if (pieza3)
                    {
                        if (llave)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void VolverInicio()
        {
            actual = arbol.raiz;
        }
    }
}
