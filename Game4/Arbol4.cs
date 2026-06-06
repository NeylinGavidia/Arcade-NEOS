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

            //8.BIBLIOTECA ANTIGUA
            Nodo bibliotecaAntigua = new Nodo(); //Nodo 8
            bibliotecaAntigua.nombSala = "Biblioteca Antigua";
            bibliotecaAntigua.descripcionSala = "Antiguos libros cubiertos de polvo llenan los estantes.";

            //9.SOTANO ABANDONADO
            Nodo sotanoAbandonado = new Nodo(); //Nodo 9
            sotanoAbandonado.nombSala = "Sotano Abandonado";
            sotanoAbandonado.descripcionSala = "El ambiente es frio y se escuchan ruidos extraños.";

            //Conecta la sala abandonada(4) con la biblioteca antigua(8) y el sotano abandonado(9)
            salaAbandonada.izquierda = bibliotecaAntigua;
            salaAbandonada.derecha = sotanoAbandonado;

            //10.ESTATUA ANTIGUA
            Nodo estatuaAntigua = new Nodo(); //Nodo 10
            estatuaAntigua.nombSala = "Estatua Antigua";
            estatuaAntigua.descripcionSala = "Una enorme estatua de piedra observa cada uno de tus movimientos.";

            //11.PORTAL
            Nodo portal = new Nodo(); //Nodo 11
            portal.nombSala = "Portal";
            portal.descripcionSala = "Un portal brillante emite una extraña energia.";

            //Conecta la camara misteriosa(5) con la estatua antigua(10) y el portal(11)
            camaraMisteriosa.izquierda = estatuaAntigua;
            camaraMisteriosa.derecha = portal;

            //12.PUENTE
            Nodo puente = new Nodo(); //Nodo 12
            puente.nombSala = "Puente";
            puente.descripcionSala = "Un viejo puente de madera cruza sobre aguas oscuras.";

            //13.CUEVA
            Nodo cueva = new Nodo(); //Nodo 13
            cueva.nombSala = "Cueva";
            cueva.descripcionSala = "La cueva es oscura y apenas puedes ver el camino.";

            //Conecta la sala inundada(6) con el puente(12) y la cueva(13)
            salaInundada.izquierda = puente;
            salaInundada.derecha = cueva;

            //14.JARDIN OCULTO
            Nodo jardinOculto = new Nodo(); //Nodo 14
            jardinOculto.nombSala = "Jardin Oculto";
            jardinOculto.descripcionSala = "Un pequeño jardin escondido florece dentro de la mazmorra.";

            //15.CAMARA FINAL
            Nodo camaraFinal = new Nodo(); //Nodo 15
            camaraFinal.nombSala = "Camara Final";
            camaraFinal.descripcionSala = "Has llegado a la ultima sala de la mazmorra.";

            //Conecta el salon de cristal(7) con el jardin oculto(14) y la camara final(15)
            salonCristal.izquierda = jardinOculto;
            salonCristal.derecha = camaraFinal;

            //16.COFRE ANTIGUO
            Nodo cofreAntiguo = new Nodo(); //Nodo 16
            cofreAntiguo.nombSala = "Cofre Antiguo";
            cofreAntiguo.descripcionSala = "Encontraste un antiguo cofre lleno de oro.";
            cofreAntiguo.oro = 50; // Asigna 50 unidades de oro al cofre antiguo

            //17.TRAMPA
            Nodo trampa = new Nodo(); //Nodo 17
            trampa.nombSala = "Trampa";
            trampa.descripcionSala = "Has activado una trampa oculta.";

            //Conecta la biblioteca antigua(8) con el cofre antiguo(16) y la trampa(17)
            bibliotecaAntigua.izquierda = cofreAntiguo;
            bibliotecaAntigua.derecha = trampa;

            //18.GOBLIN
            Nodo goblin = new Nodo(); //Nodo 18
            goblin.nombSala = "Goblin";
            goblin.descripcionSala = "Un goblin aparecio frente a ti.";
            goblin.enemigoSala = new Enemigo();
            goblin.enemigoSala.nombEnemigo = "Goblin";
            goblin.enemigoSala.vidaEnemigo = 30;
            goblin.enemigoSala.ataqueEnemigo = 10;
            goblin.enemigoSala.recompensaOro = 25;

            //19.TESORO
            Nodo tesoro1 = new Nodo(); //Nodo 19
            tesoro1.nombSala = "Tesoro";
            tesoro1.descripcionSala = "Encontraste una pequeña bolsa de monedas.";
            tesoro1.oro = 30;

            //Conecta el sotano abandonado(9) con el goblin(18) y el tesoro(19)
            sotanoAbandonado.izquierda = goblin;
            sotanoAbandonado.derecha = tesoro1;

            //20.BENDICION
            Nodo bendicion = new Nodo(); //Nodo 20
            bendicion.nombSala = "Bendicion";
            bendicion.descripcionSala = "La estatua te concede una bendicion.";

            //21.MALDICION
            Nodo maldicion = new Nodo(); //Nodo 21
            maldicion.nombSala = "Maldicion";
            maldicion.descripcionSala = "Una energia oscura cae sobre ti.";

            //Conecta la estatua antigua(10) con la bendicion(20) y la maldicion(21)
            estatuaAntigua.izquierda = bendicion;
            estatuaAntigua.derecha = maldicion;

            //22.SALA SECRETA
            Nodo salaSecreta = new Nodo(); //Nodo 22
            salaSecreta.nombSala = "Sala Secreta";
            salaSecreta.descripcionSala = "Has descubierto una sala oculta.";
            salaSecreta.oro = 50;

            //23.MURCIELAGO
            Nodo murcielago = new Nodo(); //Nodo 23
            murcielago.nombSala = "Murcielago";
            murcielago.descripcionSala = "Un murcielago gigante se lanza hacia ti.";
            murcielago.enemigoSala = new Enemigo();
            murcielago.enemigoSala.nombEnemigo = "Murcielago";
            murcielago.enemigoSala.vidaEnemigo = 15;
            murcielago.enemigoSala.ataqueEnemigo = 5;
            murcielago.enemigoSala.recompensaOro = 10;

            //Conecta el portal(11) con la sala secreta(22) y el murcielago(23)
            portal.izquierda = salaSecreta;
            portal.derecha = murcielago;

            //24.CRUZAR
            Nodo cruzar = new Nodo(); //Nodo 24
            cruzar.nombSala = "Cruzar";
            cruzar.descripcionSala = "Cruzas el puente con exito.";

            //25.CAER AL AGUA
            Nodo caerAgua = new Nodo(); //Nodo 25
            caerAgua.nombSala = "Caer al Agua";
            caerAgua.descripcionSala = "Resbalas y caes al agua.";

            //Conecta el puente(12) con cruzar(24) y caer al agua(25)
            puente.izquierda = cruzar;
            puente.derecha = caerAgua;

            //26.TESORO
            Nodo tesoro2 = new Nodo(); //Nodo 26
            tesoro2.nombSala = "Tesoro";
            tesoro2.descripcionSala = "Encontraste un tesoro escondido.";
            tesoro2.oro = 30;

            //27.ESQUELETO
            Nodo esqueleto = new Nodo(); //Nodo 27
            esqueleto.nombSala = "Esqueleto";
            esqueleto.descripcionSala = "Un esqueleto armado bloquea el paso.";
            esqueleto.enemigoSala = new Enemigo();
            esqueleto.enemigoSala.nombEnemigo = "Esqueleto";
            esqueleto.enemigoSala.vidaEnemigo = 40;
            esqueleto.enemigoSala.ataqueEnemigo = 12;
            esqueleto.enemigoSala.recompensaOro = 40;

            //Conecta la cueva(13) con el tesoro(26) y el esqueleto(27)
            cueva.izquierda = tesoro2;
            cueva.derecha = esqueleto;

            //28.CURACION
            Nodo curacion = new Nodo(); //Nodo 28
            curacion.nombSala = "Curacion";
            curacion.descripcionSala = "Las plantas restauran tu energia.";

            //29.COFRE
            Nodo cofre = new Nodo(); //Nodo 29
            cofre.nombSala = "Cofre";
            cofre.descripcionSala = "Encuentras un cofre lleno de monedas.";
            cofre.oro = 40;

            //Conecta el jardin oculto(14) con curacion(28) y el cofre(29)
            jardinOculto.izquierda = curacion;
            jardinOculto.derecha = cofre;

            //30.TESORO LEGENDARIO
            Nodo tesoroLegendario = new Nodo(); //Nodo 30
            tesoroLegendario.nombSala = "Tesoro Legendario";
            tesoroLegendario.descripcionSala = "Has encontrado el tesoro legendario.";
            tesoroLegendario.oro = 100;

            //31.DRAGON
            Nodo dragon = new Nodo(); //Nodo 31
            dragon.nombSala = "Dragon";
            dragon.descripcionSala = "El dragon guardian aparece ante ti.";
            dragon.enemigoSala = new Enemigo();
            dragon.enemigoSala.nombEnemigo = "Dragon";
            dragon.enemigoSala.vidaEnemigo = 80;
            dragon.enemigoSala.ataqueEnemigo = 25;
            dragon.enemigoSala.recompensaOro = 150;

            //Conecta la camara final(15) con el tesoro legendario(30) y el dragon(31)
            camaraFinal.izquierda = tesoroLegendario;
            camaraFinal.derecha = dragon;

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
