using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Arbol2
    {
        Nodo raiz = null;

        int contador = 1;

        public void Insertar(Fruta f)
        {
            f.codigo = contador;
            contador++;

            Insertar(ref raiz, f);
        }

        private void Insertar(ref Nodo raiz, Fruta f)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = f;

                raiz = nuevo;
            }
            else if (f.codigo < raiz.dato.codigo)
            {
                Insertar(ref raiz.iz, f);
            }
            else
            {
                Insertar(ref raiz.de, f);
            }
        }

        public void Mostrar()
        {
            Mostrar(raiz);
        }

        private void Mostrar(Nodo raiz)
        {
            if (raiz != null)
            {
                Mostrar(raiz.iz);

                Console.WriteLine(raiz.dato);

                Mostrar(raiz.de);
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
                return Buscar(raiz.iz, codigo);

            return Buscar(raiz.de, codigo);
        }
    }
}

