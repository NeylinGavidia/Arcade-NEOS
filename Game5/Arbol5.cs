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

        static int cont = 0;

        public void Codigo(Pokemon d)
        {
            d.code = cont;
            cont++;
        }
        public void Insertar(ref Nodo raiz, Pokemon d) 
        {
            if (raiz == null)
            {

                Nodo nuevo = new Nodo();
                nuevo.dato = d;
                raiz = nuevo;
            }
            else
            {
                if (d.code < raiz.dato.code) //para guiarlo a la izquierda
                {
                    Insertar(ref raiz.iz, d); //envia el dato a la izquierda, eso sognifica
                }
                else if (d.code > raiz.dato.code) //para enviarlo a la derecha
                {
                    Insertar(ref raiz.de, d);
                }
                else //cuando son iguales
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void Mostrar(Nodo raiz, int nivel)
        {
            if (raiz != null)
            {
                Mostrar(raiz.de, nivel + 1);//el arbol comienza a mostrarse desde la derecha y el nivel aumenta en 1
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("                    ");
                }
                Console.WriteLine(nivel + ": " + raiz.dato); //muestra el elemtno root
                Mostrar(raiz.iz, nivel + 1); //sigue con la izquierda, menores
            }
        }
        public bool Buscar(Nodo raiz, int d) //gual al insertar pero se quita la insercion y se modifica la recursividad
        {
            if (raiz == null)
            {
                return false;
            }

            if (raiz.dato.code == d)
            {
                Console.Write("Persona encontrada: ");
                Console.WriteLine($"{raiz.dato.name} ({raiz.dato.tipo})");
                return true;
            }

            return Buscar(raiz.iz, d) || Buscar(raiz.de, d);
        }
    }
}
