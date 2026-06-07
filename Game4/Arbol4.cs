using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Arbol4
    {
        public Nodo raiz;

        public Arbol4()
        {
            ConstruirArbol();
        }

        private void ConstruirArbol()
        {
            raiz = new Nodo();
            raiz.nombreSala = "Entrada";
            raiz.descripcion = "Has ingresado a una cueva misteriosa.";

            Nodo pasilloIzq = new Nodo();
            pasilloIzq.nombreSala = "Pasillo Izquierdo";

            Nodo pasilloDer = new Nodo();
            pasilloDer.nombreSala = "Pasillo Derecho";

            raiz.izq = pasilloIzq;
            raiz.der = pasilloDer;

            Nodo salaAbandonada = new Nodo();
            salaAbandonada.nombreSala = "Sala Abandonada";

            Nodo camaraMisteriosa = new Nodo();
            camaraMisteriosa.nombreSala = "Cámara Misteriosa";

            pasilloIzq.izq = salaAbandonada;
            pasilloIzq.der = camaraMisteriosa;

            Nodo biblioteca = new Nodo();
            biblioteca.nombreSala = "Biblioteca";
            biblioteca.recompensaOro = 50;

            Nodo sotano = new Nodo();
            sotano.nombreSala = "Sótano";
            sotano.enemigo = new Enemigo()
            {
                nombEnemigo = "Goblin",
                vidaEnemigo = 20,
                ataqueEnemigo = 10,
                recompensaOro = 30
            };

            salaAbandonada.izq = biblioteca;
            salaAbandonada.der = sotano;

            Nodo estatua = new Nodo();
            estatua.nombreSala = "Estatua";
            estatua.recompensaVida = 20;

            Nodo portal = new Nodo();
            portal.nombreSala = "Portal";

            camaraMisteriosa.izq = estatua;
            camaraMisteriosa.der = portal;

            Nodo salaInundada = new Nodo();
            salaInundada.nombreSala = "Sala Inundada";

            Nodo salonCristal = new Nodo();
            salonCristal.nombreSala = "Salón de Cristal";

            pasilloDer.izq = salaInundada;
            pasilloDer.der = salonCristal;

            Nodo puente = new Nodo();
            puente.nombreSala = "Puente";

            Nodo cueva = new Nodo();
            cueva.nombreSala = "Cueva";
            cueva.enemigo = new Enemigo()
            {
                nombEnemigo = "Orco",
                vidaEnemigo = 30,
                ataqueEnemigo = 15,
                recompensaOro = 50
            };

            salaInundada.izq = puente;
            salaInundada.der = cueva;

            Nodo jardin = new Nodo();
            jardin.nombreSala = "Jardín";
            jardin.recompensaVida = 30;

            Nodo camaraFinal = new Nodo();
            camaraFinal.nombreSala = "Cámara Final";
            camaraFinal.enemigo = new Enemigo()
            {
                nombEnemigo = "Dragón",
                vidaEnemigo = 50,
                ataqueEnemigo = 25,
                recompensaOro = 200
            };

            salonCristal.izq = jardin;
            salonCristal.der = camaraFinal;
        }
    }
}
