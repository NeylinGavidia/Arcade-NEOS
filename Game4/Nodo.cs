using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Nodo
    {
        public string nombSala;
        public string descripcionSala; 

        public int oro; // Oro disponible en las sala
        public int efectoVida; // Vida que se puede recuperar en las sala
        public bool esFinal; // Indica si la sala es una sala final (sin enemigos ni tesoros)

        public Enemigo enemigoSala; // Guarda el enemigo asociado a la sala actual

        public Nodo izquierda; 
        public Nodo derecha;
    }
}
