using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Arbol4
    {
        public Nodo raiz;
        public Arbol4()
        {
            raiz = null;
        }
        //ASIGNAR RAÍZ
        public void SetRaiz(Nodo nodo)
        {
            raiz = nodo;
        }
        public Nodo GetRaiz()
        {
            return raiz;
        }
        //RECORRIDO PREORDEN
        // Raíz - Izquierda - Derecha
        public void PreOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.WriteLine(nodo.texto);
                PreOrden(nodo.Izquierda);
                PreOrden(nodo.Derecha);
            }
        }
        //RECORRIDO INORDEN
        // Izquierda - Raíz - Derecha
        public void InOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                InOrden(nodo.Izquierda);
                Console.WriteLine(nodo.texto);
                InOrden(nodo.Derecha);
            }
        }
        //RECORRIDO POSTORDEN
        // Izquierda - Derecha - Raíz
        public void PostOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                PostOrden(nodo.Izquierda);
                PostOrden(nodo.Derecha);
                Console.WriteLine(nodo.texto);
            }
        }
    }
}
