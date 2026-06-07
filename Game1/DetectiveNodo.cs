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
                    if (habi == "Biblioteca")
                    {
                        test = "\"Yo me quedé en la biblioteca ordenando unos archivos viejos casi hasta la medianoche. Estoy segura de que salí a las 00:15 porque miré mi teléfono... aunque el reloj de pared de aquí marcaba otra hora. No sé si alguien lo movió.\"";
                    }
                    else
                    {
                        test = "\"Yo solo fui a la zona de " + habi + " porque me pareció escuchar un ruido extraño por ahí. Cuando entré a revisar, me di cuenta de que la luz principal parpadeaba raro, como si alguien hubiera estado jugando con el interruptor.\"";
                    }
                    break;

                case "Dante":
                    if (habi == "Sala")
                    {
                        test = "\"Yo estuve en la sala hasta tarde revisando unos papeles sobre la mesa. Cuando me fui a dormir, les juro que dejé todo perfectamente ordenado y limpio. Quien haya entrado después, desarregló las cosas.\"";
                    }
                    else
                    {
                        test = "\"Estaba cansado y caminé hacia el área de " + habi + " para despejarme un poco. Lo único extraño es que la puerta de este sector estaba completamente abierta... y por seguridad siempre debería estar cerrada con llave a esa hora.\"";
                    }
                    break;

                case "Damián":
                    if (habi == "Comedor")
                    {
                        test = "\"Yo me quedé en la mesa del comedor avanzando el informe técnico que debo entregar mañana. Alrededor de las 23:45 escuché unos pasos apurados afuera en el pasillo... era una silueta oscura que llevaba un maletín grande.\"";
                    }
                    else
                    {
                        test = "\"Iba de pasada hacia el sector de " + habi + " cuando vi de reojo que alguien salía corriendo hacia el pasillo del fondo. No le vi la cara porque todo estaba muy oscuro, pero caminaba muy rápido, como escondiéndose.\"";
                    }
                    break;

                case "Astrid":
                    if (habi == "Patio")
                    {
                        test = "\"Salí un momento al patio porque me sentía un poco abrumada adentro. Estaba caminando cerca de la entrada trasera y noté que había unas huellas de barro frescas en el suelo... alguien entró por ahí hace poco, estoy segura.\"";
                    }
                    else
                    {
                        test = "\"Sé que me encontraron aquí en el área de " + habi + " y que eso me hace ver sospechosa, pero de verdad no tengo nada que ocultar. Yo solo estaba haciendo mi ronda de rutina; cualquiera pudo haber caminado por este pasillo.\"";
                    }
                    break;

                case "Bruno":
                    if (habi == "Cocina")
                    {
                        test = "\"Yo bajé a la cocina a prepararme un café cargado porque el sueño me estaba ganando. Justo cuando estaba ahí, entre las 11:30 y la medianoche, se cortó la luz por completo en este sector. Me quedé a oscuras un buen rato.\"";
                    }
                    else
                    {
                        test = "\"Estaba buscando un duplicado de las llaves en el mueble de esta zona. Lo raro fue que, justo al encender la luz aquí en " + habi + ", escuché un zumbido fuerte, como si el sistema de ventilación forzada se hubiera encendido de golpe.\"";
                    }
                    break;

                default:
                    test = "\"No pienso decir nada más sobre qué hacía en el área de " + habi + " hasta que pueda hablar con alguien que me asesore. Esto es un error.\"";
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
                return false;
            }
        }
    }
}
