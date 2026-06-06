using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Jugador
    {
        public string nombJugador;
        public int vidaJugador;
        public int oroJugador;
        public int ataqueJugador;
        public Jugador()
        {
            vidaJugador = 100;
            oroJugador = 0;
            ataqueJugador = 20;
        }
        public override string ToString()
        {
            return $"Nombre: {nombJugador} | Vida: {vidaJugador} | Oro: {oroJugador}";
        }
    }
}
