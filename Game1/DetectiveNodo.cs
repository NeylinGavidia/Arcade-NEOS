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
        public ListaDobleCircular ls = new ListaDobleCircular();
        public Pila pl = new Pila();
        string hab1 = null;
        string hab2 = null;
        string hab3 = null;
        string hab4 = null;
        string hab5 = null;

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

            ls.Insertar(p1);
            ls.Insertar(p2);
            ls.Insertar(p3);
            ls.Insertar(p4);
            ls.Insertar(p5);

            p1.habi = HabitacionRandom();
            p2.habi = HabitacionRandom();
            p3.habi = HabitacionRandom();
            p4.habi = HabitacionRandom();
            p5.habi = HabitacionRandom();

            int a = r.Next(1, 6);
            Nodo temp = ls.prim;
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
            temp = ls.prim;
            for (int i = 1; i < v; i++)
            {
                temp = temp.sig;
            }
            victima = temp.dato;
            CrearDeclaraciones();
        }

        private string HabitacionRandom()
        {
            string h;
            do
            {
                int rnum = r.Next(1, 6);
                if (rnum == 1)
                {
                    h = "Biblioteca";
                }
                else if (rnum == 2)
                {
                    h = "Cocina";
                }
                else if (rnum == 3)
                {
                    h = "Sala";
                }
                else if (rnum == 4)
                {
                    h = "Laboratorio";
                }
                else
                {
                    h = "Sótano";
                }

            } while (h == hab1 || h == hab2 || h == hab3 || h == hab4 || h == hab5);

            if (hab1 == null)
            {
                hab1 = h;
            }
            else if (hab2 == null)
            {
                hab2 = h;
            }
            else if (hab3 == null)
            {
                hab3 = h;
            }
            else if (hab4 == null)
            {
                hab4 = h;
            }
            else
            {
                hab5 = h;
            }
            return h;
        }

        private void CrearDeclaraciones()
        {
            Nodo temp = ls.prim;
            do
            {
                Persona p = temp.dato;
                p.rol = "Sospechoso";
                if (p.nomb == asesino.nomb)
                {
                    p.rol = "Asesino";
                    p.decl = "No fui yo...\n" +
                             "Estaba en otro lugar cuando pasó todo.\n" +
                             "No tengo relación con la víctima.";
                }
                else if (p.nomb == victima.nomb)
                {
                    p.rol = "Victima";
                    p.decl = "La víctima no puede ser interrogada.";
                }
                else
                {
                    int pista = r.Next(1, 4);
                    if (pista == 1)
                    {
                        p.decl = "Estaba en " + p.habi + ".\n" +
                                 "Vi a alguien salir rápido.\n" +
                                 "No pude reconocerlo.";
                    }
                    else if (pista == 2)
                    {
                        p.decl = "Yo no salí de " + p.habi + ".\n" +
                                 "Todo estaba tranquilo.\n" +
                                 "No vi nada extraño.";
                    }
                    else
                    {
                        p.decl = "Estaba en " + p.habi + ".\n" +
                                 "Escuché un ruido fuerte.\n" +
                                 "Pero no le di importancia.";
                    }
                }
                temp = temp.sig;
            } while (temp != ls.prim);
        }

        public string Interrogar(Persona p)
        {
            pl.Apilar(p);
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
