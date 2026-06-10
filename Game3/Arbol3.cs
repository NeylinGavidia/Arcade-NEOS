using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game3
{
    public class Arbol3
    {
        public Nodo raiz;
        public Arbol3()
        {
            CrearJuego();
        }
        private void CrearJuego()
        {
            raiz = new Nodo();
            raiz.desc = "INICIO";
            raiz.desc ="Un antiguo explorador escondió un tesoro legendario." +
            "\n\nDebes recorrer el Perú para encontrar las piezas del mapa.";
            raiz.opcionIzquierda = "Costa";//
            raiz.opcionDerecha = "Otras Regiones";//


            // REGIONES

            Nodo costa = new Nodo();
            costa.desc = "COSTA";
            costa.desc ="Has llegado a la Costa peruana." +
            "\n\nEl sonido de las olas oculta secretos antiguos.";
            costa.opcionIzquierda = "Barco";//
            costa.opcionDerecha = "Playa";//

            Nodo regiones = new Nodo();
            regiones.desc = "OTRAS REGIONES";
            regiones.opcionIzquierda = "Sierra";//
            regiones.opcionDerecha = "Selva";//
            raiz.izq = costa;
            raiz.der = regiones;
            Nodo sierra = new Nodo();
            sierra.desc = "SIERRA";
            sierra.desc ="Las montañas esconden misterios ancestrales.";
            sierra.opcionIzquierda = "Cueva";//
            sierra.opcionDerecha = "Montaña";//
            Nodo selva = new Nodo();
            selva.desc = "SELVA";
            selva.desc = "La selva es oscura y llena de sonidos desconocidos.";
            selva.opcionIzquierda = "Río";//
            selva.opcionDerecha = "Bosque";//
            regiones.izq = sierra;
            regiones.der = selva;

            // COSTA
            Nodo barco = new Nodo();
            barco.desc = "Encuentras un viejo barco abandonado.";
            Nodo playa = new Nodo();
            playa.desc = "Buscas entre la arena y las rocas.";
            costa.izq = barco;
            costa.der = playa;
            Nodo camarote = new Nodo();
            camarote.desc = "Obtienes Pieza 1";
            camarote.objeto = "Pieza1";
            Nodo bodega = new Nodo();
            bodega.desc = "Trampa";
            bodega.derrota = true;
            barco.izq = camarote;
            barco.der = bodega;
            Nodo excavar = new Nodo();
            excavar.desc = "Obtienes Llave";
            excavar.objeto = "Llave";
            Nodo caminar = new Nodo();
            caminar.desc = "No encuentras nada";
            playa.izq = excavar;
            playa.der = caminar;

            // SIERRA
            Nodo cueva = new Nodo();
            cueva.desc = "Entrar a una cueva";
            cueva.desc = "Una antigua cueva guarda secretos ocultos.";
            Nodo montana = new Nodo();
            montana.desc = "Subir la montaña";
            sierra.izq = cueva;
            sierra.der = montana;
            Nodo antorcha = new Nodo();
            antorcha.desc = "Obtienes Pieza 2";
            antorcha.objeto = "Pieza2";
            Nodo oscuridad = new Nodo();
            oscuridad.desc = "Caída";
            oscuridad.derrota = true;
            cueva.izq = antorcha;
            cueva.der = oscuridad;
            Nodo sendero = new Nodo();
            sendero.desc = "Obtienes Brújula";
            sendero.objeto = "Brujula";
            Nodo atajo = new Nodo();
            atajo.desc = "Deslizamiento";
            atajo.derrota = true;
            montana.izq = sendero;
            montana.der = atajo;

            // SELVA
            Nodo rio = new Nodo();
            rio.desc = "Seguir el río";
            rio.desc = "Siguiendo el río descubres algo brillante.";
            Nodo bosque = new Nodo();
            bosque.desc = "Entrar al bosque";
            selva.izq = rio;
            selva.der = bosque;
            Nodo puente = new Nodo();
            puente.desc = "Obtienes Pieza 3";
            puente.objeto = "Pieza3";
            Nodo nadar = new Nodo();
            nadar.desc = "Pirañas";
            nadar.derrota = true;
            rio.izq = puente;
            rio.der = nadar;
            Nodo sonidos = new Nodo();
            sonidos.desc = "Trampa";
            sonidos.derrota = true;
            Nodo marcas = new Nodo();
            marcas.desc = "Obtienes Gema";
            marcas.objeto = "Gema";
            bosque.izq = sonidos;
            bosque.der = marcas;
        }
    }
}

