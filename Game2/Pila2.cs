using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Pila2
    {
        Nodo cima = null;

        public void Apilar(Fruta f)
        {
            Nodo nuevo = new Nodo();

            nuevo.dato = f;

            nuevo.sig = cima;

            cima = nuevo;
        }

        public string Mostrar()
        {
            string texto = "";

            Nodo temp = cima;

            while (temp != null)
            {
                texto = texto + temp.dato.nombre + "\n";

                temp = temp.sig;
            }

            return texto;
        }
    }
}
