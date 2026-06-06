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

        public void CargarDatos()
        {
            Fruta f1 = new Fruta();
            f1.nombre = "Manzana";
            f1.pista = "Es roja y crece en arboles";

            Fruta f2 = new Fruta();
            f2.nombre = "Piña";
            f2.pista = "Tiene corona y es tropical";

            Fruta f3 = new Fruta();
            f3.nombre = "Fresa";
            f3.pista = "Es pequeña y tiene semillas por fuera";

            arbol.Insertar(f1);
            arbol.Insertar(f2);
            arbol.Insertar(f3);

            cola.Encolar(f1);
            cola.Encolar(f2);
            cola.Encolar(f3);
        }

        public Fruta ObtenerActual()
        {
            return cola.VerFrente();
        }

        public bool Verificar(int codigo)
        {
            Fruta seleccionada = arbol.Buscar(codigo);

            if (seleccionada == null)
                return false;

            if (seleccionada.codigo == cola.VerFrente().codigo)
            {
                puntaje += 10;

                cola.Desencolar();

                return true;
            }

            pila.Apilar(seleccionada);

            vidas--;

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
    }
}
