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
        public DUNGEON_TREE()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            juego = new Juego();

            juego.jugador.nombJugador = txtNombre.Text;

            lblJugador.Text = juego.jugador.nombJugador;
            lblVida.Text = juego.jugador.vidaJugador.ToString();
            lblOro.Text = juego.jugador.oroJugador.ToString();
            lblSala.Text = juego.actual.nombreSala;

            rtbHistoria.Text = "Bienvenido a Dungeon Tree.";
            rtbHistoria.Text += "\n\nHas ingresado a una antigua cueva misteriosa.";
            rtbHistoria.Text += "\nTu aventura comienza en la Sala (Entrada).";

            btnIzquierda.Enabled = true;
            btnDerecha.Enabled = true;

            btnComenzar.Enabled = false;
            txtNombre.Enabled = false;
        }
        private void DUNGEON_TREE_Load(object sender, EventArgs e)
        {
            btnIzquierda.Enabled = false;
            btnDerecha.Enabled = false;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            string mensaje = juego.IrIzquierda();

            rtbHistoria.Text += "\n\n" + mensaje;

            lblVida.Text = juego.jugador.vidaJugador.ToString();
            lblOro.Text = juego.jugador.oroJugador.ToString();
            lblSala.Text = juego.actual.nombreSala;

            if (juego.actual.nombreSala == "Cámara Final")
            {
                MessageBox.Show("¡Has completado Dungeon Tree!", "Victoria");

                btnIzquierda.Enabled = false;
                btnDerecha.Enabled = false;
            }
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            string mensaje = juego.IrDerecha();

            rtbHistoria.Text += "\n\n" + mensaje;

            lblVida.Text = juego.jugador.vidaJugador.ToString();
            lblOro.Text = juego.jugador.oroJugador.ToString();
            lblSala.Text = juego.actual.nombreSala;

            if (juego.actual.nombreSala == "Cámara Final")
            {
                MessageBox.Show("¡Has completado Dungeon Tree!", "Victoria");

                btnIzquierda.Enabled = false;
                btnDerecha.Enabled = false;
            }
        }
    }
}
