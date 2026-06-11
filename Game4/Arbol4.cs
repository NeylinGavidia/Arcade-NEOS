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
        public void PreOrden(Nodo nodo)
        {
            //No se utiliza xd
        }
        //RECORRIDO INORDEN
        public void InOrden(Nodo nodo)
        {
            //Tampoco se utiliza xd
        }
        //RECORRIDO POSTORDEN
        public void PostOrden(Nodo nodo)
        {
            //De este ni que decir :v
        }
    }
}
