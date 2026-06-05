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
            juego.CrearCaso("Selene", "Dante", "Damián", "Astrid", "Bruno");
            act = juego.ls.prim;
            Mostrar();
        }

        private void Mostrar()
        {
            lblNombre.Text = "Nombre: " + act.dato.nomb;
            if (act.dato.nomb == juego.victima.nomb)
            {
                lblRol.Text = "Rol: Víctima";
            }
            else
            {
                lblRol.Text = "Rol: Sospechoso";
            }
            lblHabitacion.Text = "Habitación: " + act.dato.habi;
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
            string nuevo =
                "\r\n═══════════════════════════\r\n" +
                "🕵️ INVESTIGACIÓN\r\n" +
                "═══════════════════════════\r\n" +
                juego.Interrogar(act.dato) +
                "\r\n═══════════════════════════\r\n";

            if (txtHistorial.Text == "")
            {
                txtHistorial.Text = nuevo;
            }
            else
            {
                txtHistorial.Text = txtHistorial.Text + nuevo;
            }
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
