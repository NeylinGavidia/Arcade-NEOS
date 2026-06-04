using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class DetectiveNodo
    {
        Random r = new Random();
        public Persona asesino;
        public Persona victima;
        public ListaDobleCircular lista = new ListaDobleCircular();
        public Pila pila = new Pila();

        public void CrearCaso(string n1, string n2, string n3, string n4, string n5)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            Persona p3 = new Persona();
            Persona p4 = new Persona();
            Persona p5 = new Persona();

            p1.nomb = n1;
            p2.nomb = n2;
            p3.nomb = n3;
            p4.nomb = n4;
            p5.nomb = n5;

            lista.Insertar(p1);
            lista.Insertar(p2);
            lista.Insertar(p3);
            lista.Insertar(p4);
            lista.Insertar(p5);

            p1.habi = HabitacionRandom();
            p2.habi = HabitacionRandom();
            p3.habi = HabitacionRandom();
            p4.habi = HabitacionRandom();
            p5.habi = HabitacionRandom();

            int a = r.Next(1, 6);
            Nodo temp = lista.prim;
            for (int i = 1; i < a; i++)
            {
                temp = temp.sig;
            }
            asesino = temp.dato;
            int v = r.Next(1, 6);
            while (v == a)
            {
                v = r.Next(1, 6);
            }
            temp = lista.prim;
            for (int i = 1; i < v; i++)
            {
                temp = temp.sig;
            }
            victima = temp.dato;
            CrearDeclaraciones();
        }

        private string HabitacionRandom()
        {
            int h = r.Next(1, 6);
            if (h == 1)
            {
                return "Biblioteca";
            }
            else if (h == 2)
            {
                return "Cocina";
            }
            else if (h == 3)
            {
                return "Sala";
            }
            else if (h == 4)
            {
                return "Laboratorio";
            }
            else
            {
                return "Sótano";
            }
        }

        private void CrearDeclaraciones()
        {
            Nodo temp = lista.prim;
            do
            {
                Persona p = temp.dato;
                p.rol = "Sospechoso";
                if (p == asesino)
                {
                    p.rol = "Asesino";
                    p.decl = "Yo no fui, no tengo nada que ver.\n" +
                             "Estaba solo, nadie me vio.\n" +
                             "No estuve en la escena del crimen.";
                }
                else if (p == victima)
                {
                    p.rol = "Victima";
                    p.decl = "No vi quién fue...\n" +
                             "Solo recuerdo que alguien entró.\n" +
                             "Después todo se volvió confuso.";
                }
                else
                {
                    if (p.habi == asesino.habi)
                    {
                        p.decl = "Estuve en la misma habitación que la víctima.\n" +
                                 "Vi a alguien salir rápido, pero no supe quién era.";
                    }
                    else
                    {
                        p.decl = "Yo estaba en " + p.habi + ".\n" +
                                 "No vi nada sospechoso.\n" +
                                 "Todo parecía normal.";
                    }
                }
                temp = temp.sig;
            } while (temp != lista.prim);
        }

        public string Interrogar(Persona p)
        {
            pila.Apilar(p);
            return p.nomb + ": " + p.decl;
        }

        public bool Acusar(string nombre)
        {
            if (nombre == asesino.nomb)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
