 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game5
{
    public class Arbol5
    {
        private Nodo raiz_pri;
        static int cont = 1;
        public void Insertar(Pokemon d)  //tuve que hacer esto por haber puesto el Nodo en privado qwq
        {
            d.code = cont;
            cont+= 3;
            Insertar(ref raiz_pri, d);
        }
        private void Insertar(ref Nodo raiz, Pokemon d)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = d;
                raiz = nuevo;
            }
            else if (d.code < raiz.dato.code)
            {
                Insertar(ref raiz.iz, d);
            }
            else if (d.code > raiz.dato.code)
            {
                Insertar(ref raiz.de, d);
            }
            else
            {
                Console.WriteLine("Dato duplicado");
            }
        }
        public string MostrarPok() //cambiando a string el mostrar sino no funciona mi idea >:(
        {
            return Mostrar(raiz_pri);
        }
        private string Mostrar(Nodo raiz)
        {
            if (raiz == null)
            {
                return "";
            }

            return $"{Mostrar(raiz.iz)}\n {raiz.dato}\n {Mostrar(raiz.de)}"; //ojala funcione esto xd si lo hace increible xd

        }
        public Pokemon Buscar(int code)
        {
            return Buscar(raiz_pri, code);
        }
        private Pokemon Buscar(Nodo raiz, int code)
        {
            if (raiz == null)
            {
                return null;
            }
            if (code == raiz.dato.code)
            {
                return raiz.dato;
            }
            else if (code < raiz.dato.code)
            {
                return Buscar(raiz.iz, code);
            }
            else
            {
                return Buscar(raiz.de, code);
            }
        }
    }
}
