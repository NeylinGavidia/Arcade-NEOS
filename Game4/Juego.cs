using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    public class Juego
    {
        public Arbol4 arbol;

        public Juego()
        {
            arbol = new Arbol4();
            ConstruirArbol();
        }

        private void ConstruirArbol()
        {
            //HOJAS (RESULTADOS)
            Nodo llegaTarde = new Nodo("Llegas tarde a clase, pero igual entras. El profesor te mira raro, pero al menos no faltaste. Eso demuestra responsabilidad");
            Nodo atrasasCurso = new Nodo("Decidiste no ir a clases y ahora te estás atrasando. Será más difícil recuperar el tema después. Fue una mala decision");

            Nodo llegasTiempo = new Nodo("Te alistaste con calma y llegaste puntualmente a clase. Gracias a tu organización, comenzaste el día sin problemas.");
            Nodo casiTiempo = new Nodo("Llegaste casi a tiempo a clase. Por suerte, el profesor aún no había comenzado la explicación. Buenda decision");
            Nodo pierdesTema = new Nodo("Decidiste faltar a clases. Lamentablemente, ese día explicaron un tema importante para tu próximo examen. Pesima decision"); //Xd

            //NIVEL 2
            Nodo irClaseTarde = new Nodo("El tiempo pasó demasiado rápido... y ahora recuerdas que tenías clases en la universidad. ¿Qué harás ahora?" +
                                        "\nA) Ir aunque pierdes 30 minutos de clase" +
                                        "\nB) No ir");

            Nodo celular = new Nodo("Te entretuviste más de lo que pensabas. Al revisar la hora, sientes un pequeño susto: tu clase está a punto de empezar. ¿Qué haces?" +
                                    "\nA) Alistarte rápido" +
                                    "\nB) Faltar");

            //RAÍZ
            Nodo raiz = new Nodo("Tu alarma suena fuerte... ¿te levantas o sigues acostado un rato más?" +
                                 "\nA) Levantarse " +
                                 "\nB) Seguir acostado");

            //CONEXIONES

            // RAÍZ
            raiz.Izquierda = irClaseTarde;   // NO
            raiz.Derecha = new Nodo("Has decidido levantarte. Todo parece ir bien por ahora. Al mirar tu celular, notas que tu primera clase comienza dentro de media hora. ¿Qué haces?" +
                                    "\nA) Alistarte " +
                                    "\nB) Revisar el celular un rato"); // SI

            irClaseTarde.Derecha = llegaTarde;   // Ir
            irClaseTarde.Izquierda = atrasasCurso;   // No ir

            // RAMA SI
            Nodo nodoClase = raiz.Derecha;

            nodoClase.Derecha = llegasTiempo;

            nodoClase.Izquierda = celular;

            celular.Derecha = casiTiempo;      // Alistarte rápido
            celular.Izquierda = pierdesTema;   // Faltar

            //GUARDAR EN ÁRBOL
            arbol.SetRaiz(raiz);
        }
        public Nodo ObtenerRaiz()
        {
            return arbol.GetRaiz();
        }
    }
}
