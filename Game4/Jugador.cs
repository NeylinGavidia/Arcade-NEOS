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
        public int ataqueJugador;
        public int oroJugador;
        public int enemigosderrotados;

        public Jugador()
        {
        }
        public override string ToString()
        {
            return $"Nombre: {nombJugador} | Vida: {vidaJugador}";
        }
    }
}
