using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Juego
    {
        public Jugador jugador;
        public Arbol4 arbol;
        public Nodo actual;

        public Juego()
        {
            jugador = new Jugador();
            arbol = new Arbol4();
            actual = arbol.raiz;
        }
        public string IrIzquierda()
        {
            if (actual.izq == null)
            {
                return "No puedes avanzar.";
            }
            actual = actual.izq;
            return ProcesarSala();
        }
        public string IrDerecha()
        {
            if (actual.der == null)
            {
                return "No puedes avanzar.";
            }
            actual = actual.der;
            return ProcesarSala();
        }
        private string ProcesarSala()
        {
            string mensaje = $"Has llegado a {actual.nombreSala}.";

            if (actual.recompensaOro > 0)
            {
                jugador.oroJugador = jugador.oroJugador + actual.recompensaOro;
                mensaje += $"\nEncontraste {actual.recompensaOro} monedas de oro.";
            }

            if (actual.recompensaVida > 0)
            {
                jugador.vidaJugador = jugador.vidaJugador + actual.recompensaVida;
                mensaje += $"\nRecuperaste {actual.recompensaVida} puntos de vida.";
            }

            if (actual.enemigo != null)
            {
                jugador.vidaJugador = jugador.vidaJugador - actual.enemigo.ataqueEnemigo;
                jugador.oroJugador = jugador.oroJugador + actual.enemigo.recompensaOro;

                mensaje = mensaje + "\nDerrotaste a " + actual.enemigo.nombEnemigo;
                mensaje = mensaje + "\nPerdiste " + actual.enemigo.ataqueEnemigo + " de vida.";
                mensaje = mensaje + "\nGanaste " + actual.enemigo.recompensaOro + " de oro.";
            }

            return mensaje;
        }
    }
}
