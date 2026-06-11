using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class JuegoFrutas2
    {
        public Arbol2 arbol = new Arbol2();
        public Cola2 cola = new Cola2();
        public Pila2 pila = new Pila2();

        public int vidas = 3;
        public int puntaje = 0;
        public int intentos = 0;

        public void CargarDatos()
        {
            Fruta f1 = new Fruta();
            f1.codigo = 1;
            f1.nombre = "Manzana";
            f1.color = "Rojo";
            f1.origen = "Arbol";
            f1.pista = "Es roja y crece en arboles";

            Fruta f2 = new Fruta();
            f2.codigo = 2;
            f2.nombre = "Piña";
            f2.color = "Amarillo";
            f2.origen = "Tropical";
            f2.pista = "Tiene corona y es tropical";

            Fruta f3 = new Fruta();
            f3.codigo = 3;
            f3.nombre = "Fresa";
            f3.color = "Rojo";
            f3.origen = "Planta";
            f3.pista = "Es pequeña y tiene semillas por fuera";

            Fruta f4 = new Fruta();
            f4.codigo = 4;
            f4.nombre = "Platano";
            f4.color = "Amarillo";
            f4.origen = "Planta";
            f4.pista = "Es amarillo y lo comen mucho los monos";

            Fruta f5 = new Fruta();
            f5.codigo = 5;
            f5.nombre = "Naranja";
            f5.color = "Naranja";
            f5.origen = "Arbol";
            f5.pista = "Tiene mucho jugo y vitamina C";

            Fruta f6 = new Fruta();
            f6.codigo = 6;
            f6.nombre = "Uva";
            f6.color = "Morado";
            f6.origen = "Vid";
            f6.pista = "Crece en racimos";

            Fruta f7 = new Fruta();
            f7.codigo = 7;
            f7.nombre = "Sandia";
            f7.color = "Verde";
            f7.origen = "Planta";
            f7.pista = "Es grande por fuera y roja por dentro";

            Fruta f8 = new Fruta();
            f8.codigo = 8;
            f8.nombre = "Mango";
            f8.color = "Amarillo";
            f8.origen = "Arbol";
            f8.pista = "Fruta tropical muy dulce";

            arbol.Insertar(f1);
            arbol.Insertar(f2);
            arbol.Insertar(f3);
            arbol.Insertar(f4);
            arbol.Insertar(f5);
            arbol.Insertar(f6);
            arbol.Insertar(f7);
            arbol.Insertar(f8);


            cola.Encolar(f1);
            cola.Encolar(f2);
            cola.Encolar(f3);
            cola.Encolar(f4);
            cola.Encolar(f5);
            cola.Encolar(f6);
            cola.Encolar(f7);
            cola.Encolar(f8);
        }

        public Fruta ObtenerActual()
        {
            return cola.VerFrente();
        }

        public bool Verificar(int codigo)
        {
            Fruta seleccionada = arbol.Buscar(codigo);

            if (seleccionada == null)
            {
                intentos++;
                vidas--;

                if (intentos >= 2)
                {
                    cola.Desencolar();
                    intentos = 0;
                }

                return false;
            }

            if (seleccionada.codigo == cola.VerFrente().codigo)
            {
                puntaje += 10;
                cola.Desencolar();
                intentos = 0;

                return true;
            }
            intentos++;
            vidas--;
            pila.Apilar(seleccionada);
            if (intentos >= 2)
            {
                cola.Desencolar();
                intentos = 0;
            }
            return false;
        }

        public bool Ganaste()
        {
            return cola.Vacia();
        }

        public bool Perdiste()
        {
            return vidas <= 0;
        }
        public string MensajeFinal()
        {
            if (puntaje >= 70)
            {
                return "¡Excelente! Eres un experto en frutas.";
            }
            else if (puntaje >= 40)
            {
                return "¡Buen trabajo!";
            }
            else
            {
                return "Sigue practicando.";
            }
        }
    }
}
