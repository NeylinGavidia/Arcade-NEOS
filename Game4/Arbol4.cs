using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Arbol4
    {
        public Nodo raiz = null;

        //Crea y conecta todas las salas de la mazmorra, asignando enemigos y oro a cada sala
        public void CrearMazmorra()
        {

        }

        // Devuelve el nombre de la sala actual
        public string Mostrarsala(Nodo sala)
        {
            return sala.nombSala;
        }
        //public Nodo IrIzquierda(Nodo actual)
        //{

        //}
        //public Nodo IrDerecha(Nodo actual)
        //{

        //}

        // Verifica si la sala actual tiene un enemigo
        public bool VerificarEnemigo(Nodo sala)
        {
            return sala.enemigoSala != null;
        }

        // Verifica si la sala actual es una sala final (sin salas conectadas)
        public bool EsFinal(Nodo sala)
        {
            return sala.izquierda == null && sala.derecha == null;
        }
    }
}
