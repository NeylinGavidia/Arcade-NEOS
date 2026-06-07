using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Arbol2
    {
        private Nodo raiz = null;

        public void Insertar(Fruta d)
        {
            Insertar(ref raiz, d);
        }

        private void Insertar(ref Nodo raiz, Fruta d)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = d;
                raiz = nuevo;
            }
            else if (d.codigo < raiz.dato.codigo)
            {
                Insertar(ref raiz.izq, d);
            }
            else if (d.codigo > raiz.dato.codigo)
            {
                Insertar(ref raiz.der, d);
            }
        }

        public Fruta Buscar(int codigo)
        {
            return Buscar(raiz, codigo);
        }

        private Fruta Buscar(Nodo raiz, int codigo)
        {
            if (raiz == null)
                return null;

            if (codigo == raiz.dato.codigo)
                return raiz.dato;

            if (codigo < raiz.dato.codigo)
                return Buscar(raiz.izq, codigo);

            return Buscar(raiz.der, codigo);
        }

        public void Mostrar()
        {
            Mostrar(raiz);
        }

        private void Mostrar(Nodo raiz)
        {
            if (raiz != null)
            {
                Mostrar(raiz.izq);
                Console.WriteLine(raiz.dato);
                Mostrar(raiz.der);
            }
        }
    }
}
