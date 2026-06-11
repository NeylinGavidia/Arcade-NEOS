using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game4
{
    public partial class DUNGEON_TREE : Form
    {
        Juego juego;
        Nodo actual;
        string nombreJugador;
        public DUNGEON_TREE()
        {
            InitializeComponent();
        }
        private void DUNGEON_TREE_Load(object sender, EventArgs e)
        {
            juego = new Juego();
            actual = juego.ObtenerRaiz();

            // OCULTAR JUEGO AL INICIO
            lblPregunta.Visible = false;
            btnSi.Visible = false;
            btnNo.Visible = false;
            btnReiniciar.Visible = false;
            picJuego.Visible = false;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            if (actual.Derecha != null)
            {
                actual = actual.Derecha;
                lblPregunta.Text = actual.texto;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (actual.Izquierda != null)
            {
                actual = actual.Izquierda;
                lblPregunta.Text = actual.texto;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            actual = juego.ObtenerRaiz();
            lblPregunta.Text = actual.texto;
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            nombreJugador = txtNombre.Text;

            // Historia personalizada
            lblHistoria.Text = nombreJugador +
                ", acabas de despertar en tu habitación. La luz del sol entra por la ventana y tu celular no deja de sonar. " +
                "Tus padres ya han salido a trabajar y hoy tienes clases importantes en la universidad. " +
                "Dependiendo de tus decisiones, tu día puede salir bien o convertirse en un desastre...";

            // Ocultar inicio
            txtNombre.Visible = false;
            btnComenzar.Visible = false;
            lblNombre.Visible = false;

            lblHistoria.Visible = false;
            picJuego.Visible = true;

            // Mostrar juego
            lblPregunta.Visible = true;
            btnSi.Visible = true;
            btnNo.Visible = true;
            btnReiniciar.Visible = true;

            // Iniciar árbol
            actual = juego.ObtenerRaiz();
            lblPregunta.Text = actual.texto;
        }
    }
}
