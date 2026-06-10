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
            raiz.opcionIzquierda = "Costa";//
            raiz.opcionDerecha = "Otras Regiones";//


            // REGIONES

            Nodo costa = new Nodo();
            costa.desc = "COSTA";
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
            sierra.opcionIzquierda = "Cueva";//
            sierra.opcionDerecha = "Montaña";//
            Nodo selva = new Nodo();
            selva.desc = "SELVA";
            selva.opcionIzquierda = "Río";//
            selva.opcionDerecha = "Bosque";//
            regiones.izq = sierra;
            regiones.der = selva;

            // COSTA
            Nodo barco = new Nodo();
            barco.desc = "Ir al barco abandonado";
            Nodo playa = new Nodo();
            playa.desc = "Buscar en la playa";
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

