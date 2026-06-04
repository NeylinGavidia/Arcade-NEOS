using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Enemigo
    {
        public string nombEnemigo;
        public int vidaEnemigo;
        public int ataqueEnemigo;
        public int recompensaOro;

        public override string ToString()
        {
            return $"Nombre: {nombEnemigo} | Vida: {vidaEnemigo}";
        }
    }
}
