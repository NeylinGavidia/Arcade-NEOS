using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game1;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DetectiveNodo juego;
        Nodo act;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            juego = new DetectiveNodo();
            juego.CrearCaso("Ana", "Luis", "Carlos", "Maria", "Pedro");

            act = juego.lista.prim;

            Mostrar();
        }

        private void Mostrar()
        {
            lblNombre.Text = act.dato.nomb;
            lblRol.Text = act.dato.rol;
            lblHabitacion.Text = act.dato.habi;
            lblDialogo.Text = act.dato.decl;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            act = act.sig;
            Mostrar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            act = act.ant;
            Mostrar();
        }

        private void btnInterrogar_Click(object sender, EventArgs e)
        {
            txtHistorial.Text += juego.Interrogar(act.dato) + "\r\n";
        }

        private void btnAcusar_Click(object sender, EventArgs e)
        {
            if (juego.Acusar(txtAcusar.Text))
            {
                MessageBox.Show("¡Correcto! Caso resuelto 🕵️");
            }
            else
            {
                MessageBox.Show("Incorrecto... sigue investigando ❌");
            }
        }
    }
}
