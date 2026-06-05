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
            //1.ENTRADA
            Nodo entrada = new Nodo(); //Nodo 1
            entrada.nombSala = "Entrada";
            entrada.descripcionSala = "Te encuentras frente a la entrada de una antigua mazmorra.";
            
            //2.PASILLO IZQUIERDO
            Nodo pasilloIzquierdo = new Nodo(); //Nodo 2
            pasilloIzquierdo.nombSala = "Pasillo Izquierdo";
            pasilloIzquierdo.descripcionSala = "Un pasillo oscuro que parece abandonado.";

            //3.PASILLO DERECHO
            Nodo pasilloDerecho = new Nodo(); //Nodo 3
            pasilloDerecho.nombSala = "Pasillo Derecho";
            pasilloDerecho.descripcionSala = "Escuchas el sonido de agua a lo lejos.";

            // Establece la raíz del árbol como la entrada
            raiz = entrada;

            //Conecta la entrada con los pasillos izquierdo y derecho 
            entrada.izquierda = pasilloIzquierdo;
            entrada.derecha = pasilloDerecho;

            //4.SALA ABANDONADA
            Nodo salaAbandonada = new Nodo(); //Nodo 4
            salaAbandonada.nombSala = "Sala Abandonada";
            salaAbandonada.descripcionSala = "Una sala llena de polvo y muebles rotos.";

            //5.CAMARA MISTERIOSA
            Nodo camaraMisteriosa = new Nodo(); //Nodo 5
            camaraMisteriosa.nombSala = "Camara Misteriosa";
            camaraMisteriosa.descripcionSala = "Extraños simbolos cubren las paredes.";

            //Conecta el pasillo izquierdo con la sala abandonada y la camara misteriosa
            pasilloIzquierdo.izquierda = salaAbandonada;
            pasilloIzquierdo.derecha = camaraMisteriosa;

            //6.SALA INUNDADA
            Nodo salaInundada = new Nodo(); //Nodo 6
            salaInundada.nombSala = "Sala Inundada";
            salaInundada.descripcionSala = "El agua cubre parte del suelo.";

            //7.SALON DE CRISTAL
            Nodo salonCristal = new Nodo(); //Nodo 7
            salonCristal.nombSala = "Salon de Cristal";
            salonCristal.descripcionSala = "Cristales brillantes iluminan la sala.";

            //Conecta el pasillo derecho con la sala inundada y el salon de cristal
            pasilloDerecho.izquierda = salaInundada;
            pasilloDerecho.derecha = salonCristal;
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
