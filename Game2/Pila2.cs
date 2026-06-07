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
            StringBuilder sb = new StringBuilder();

            Nodo temp = cima;

            while (temp != null)
            {
                sb.AppendLine(temp.dato.nombre);

                temp = temp.sig;
            }

            return sb.ToString();
        }
    }
}
