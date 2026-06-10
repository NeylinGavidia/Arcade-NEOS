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
        public Persona ases;
        public Persona vict;
        public int vd = 3;
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

            //se selecciona al asesino
            int a = r.Next(1, 6);
            Nodo temp = ls.prim;
            for (int i = 1; i < a; i++)
            {
                temp = temp.sig;
            }
            ases = temp.dato;

            //se selecciona la victima
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
            vict = temp.dato;
        }

        private string HabitacionRandom()
        {
            string h;
            do
            {
                int rnum = r.Next(1, 7);
                if (rnum == 1)
                {
                    h = "Sala";
                }
                else if (rnum == 2)
                {
                    h = "Comedor";
                }
                else if (rnum == 3)
                {
                    h = "Cocina";
                }
                else if (rnum == 4)
                {
                    h = "Biblioteca";
                }
                else if (rnum == 5)
                {
                    h = "Patio";
                }
                else
                {
                    h = "Dormitorio";
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

        public string Interrogar(Persona p)
        {
            pl.Apilar(p);
            string nomb = p.nomb;
            string habi = p.habi;
            string tl = "INFORME: Custodiado en [" + habi.ToUpper() + "].\r\n";
            string test = "";

            if (p.nomb == vict.nomb)
            {
                return tl + "\"...\n[ERROR: El cuerpo de " + nomb + " fue hallado aquí. No puede responder]\"";
            }

            switch (nomb)
            {
                case "Selene":
                    if (p.nomb == ases.nomb)
                    {
                        test = "\"¡Yo no hice nada! No podía dormir y me quedé caminando por los pasillos oscuros... de verdad, ¡soy inocente!\"";
                    }
                    else
                    {
                        test = "\"Yo me quedé en la zona de " + habi + " ordenando unos archivos viejos. Estaba muy concentrada y no escuché nada raro hasta que llegó la policía.\"";
                    }
                    break;

                case "Dante":
                    if (p.nomb == ases.nomb)
                    {
                        test = "\"¿Yo? No sé de qué me habla, detective. Estaba dando vueltas por los pasillos buscando un vaso de agua... no vi a nadie.\"";
                    }
                    else
                    {
                        test = "\"Yo estuve todo el tiempo en el área de " + habi + " revisando unos papeles importantes sobre mi escritorio. Dejé todo perfectamente limpio al terminar.\"";
                    }
                    break;

                case "Damián":
                    if (p.nomb == ases.nomb)
                    {
                        test = "\"¡Esto es un error! Yo solo caminaba por los pasillos del fondo porque me sentía un poco mareado. No estuve cerca de la víctima.\"";
                    }
                    else
                    {
                        test = "\"Estaba avanzando mi informe técnico en el sector de " + habi + ". De repente escuché unos pasos apurados afuera, pero no quise asomarme por miedo.\"";
                    }
                    break;

                case "Astrid":
                    if (p.nomb == ases.nomb)
                    {
                        test = "\"Le juro que soy inocente. Salí a caminar por los pasillos para tomar un poco de aire porque hacía calor en mi habitación, eso es todo.\"";
                    }
                    else
                    {
                        test = "\"Yo estaba haciendo mi ronda de rutina por el área de " + habi + ". Todo se veía tranquilo por aquí, no entiendo en qué momento ocurrió esa desgracia.\"";
                    }
                    break;

                case "Bruno":
                    if (p.nomb == ases.nomb)
                    {
                        test = "\"¡Es una trampa! Yo no salí de los pasillos principales en toda la noche. Estaba desorientado porque se cortó la luz y no supe qué pasó.\"";
                    }
                    else
                    {
                        test = "\"Bajé un momento a la zona de " + habi + " a prepararme un café bien cargado para el sueño. Justo en ese instante las luces parpadearon muy extraño.\"";
                    }
                    break;

                default:
                    test = "\"No pienso decir nada más sobre qué hacía en " + habi + " sin un abogado.\"";
                    break;
            }
            return tl + test;
        }

        public bool Acusar(string nombre)
        {
            if (nombre == ases.nomb)
            {
                return true;
            }
            else
            {
                vd = vd - 1; //resta vida
                return false;
            }
        }
    }
}
