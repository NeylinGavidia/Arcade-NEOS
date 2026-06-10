using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game3
{
    public partial class Form3TesoroPeru : Form
    {
        private TesoroPeru juego;
        public Form3TesoroPeru()
        {
            InitializeComponent();
            juego = new TesoroPeru();
            ActualizarPantalla();
            btnIzquierda.Click += btnIzquierda_Click;
            btnDerecha.Click += btnDerecha_Click;
            btnReiniciar.Click += btnReiniciar_Click;
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarPantalla()
        {
            lblDescripcion.Text = juego.actual.desc;

            lblInventario.Text = "";

            foreach (string item in juego.inventario)
            {
                lblInventario.Text += item + Environment.NewLine;
            }

            // AGREGADO - mostrar nombres de opciones
            //btnIzquierda.Text = juego.actual.opcionIzquierda;
            // btnDerecha.Text = juego.actual.opcionDerecha;
            btnIzquierda.Text = string.IsNullOrEmpty(juego.actual.opcionIzquierda)
                ? "Sin opción"
                : juego.actual.opcionIzquierda;

            btnDerecha.Text = string.IsNullOrEmpty(juego.actual.opcionDerecha)
                ? "Sin opción"
                : juego.actual.opcionDerecha;
            // AGREGADO - imágenes

            if (juego.actual.desc.Contains("INICIO"))
            {
                picEscena.Image = Image.FromFile("Imagenes/inicio.jpg");
            }

            else if (juego.actual.desc.Contains("COSTA"))
            {
                picEscena.Image = Image.FromFile("Imagenes/costa.jpg");
            }

            else if (juego.actual.desc.Contains("Ir al barco"))
            {
                picEscena.Image = Image.FromFile("Imagenes/barco.jpg");
            }

            else if (juego.actual.desc.Contains("Buscar en la playa"))
            {
                picEscena.Image = Image.FromFile("Imagenes/playa.jpg");
            }

            else if (juego.actual.desc.Contains("SIERRA"))
            {
                picEscena.Image = Image.FromFile("Imagenes/sierra.jpg");
            }

            else if (juego.actual.desc.Contains("cueva"))
            {
                picEscena.Image = Image.FromFile("Imagenes/cueva.jpg");
            }

            else if (juego.actual.desc.Contains("montaña"))
            {
                picEscena.Image = Image.FromFile("Imagenes/montana.jpg");
            }

            else if (juego.actual.desc.Contains("SELVA"))
            {
                picEscena.Image = Image.FromFile("Imagenes/selva.jpg");
            }

            else if (juego.actual.desc.Contains("río"))
            {
                picEscena.Image = Image.FromFile("Imagenes/rio.jpg");
            }

            else if (juego.actual.desc.Contains("bosque"))
            {
                picEscena.Image = Image.FromFile("Imagenes/bosque.jpg");
            }


        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            juego.IrIzquierda();

            ActualizarPantalla();

            if (juego.Perdio())
            {
                picEscena.Image = Image.FromFile("Imagenes/trampa.jpg");
                MessageBox.Show("GAME OVER\n\nHas caído en una trampa.");
            }

            if (juego.Gano())
            {
                picEscena.Image = Image.FromFile("Imagenes/tesoro.jpg");
                MessageBox.Show("FELICIDADES\n\n¡Encontraste el Tesoro Perdido del Perú!");
            }
        }
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            juego.IrDerecha();

            ActualizarPantalla();

            if (juego.Perdio())
            {
                picEscena.Image = Image.FromFile("Imagenes/trampa.jpg");
                MessageBox.Show("GAME OVER\n\nHas caído en una trampa.");
            }

            if (juego.Gano())
            {
                picEscena.Image = Image.FromFile("Imagenes/tesoro.jpg");
                MessageBox.Show("FELICIDADES\n\n¡Encontraste el Tesoro Perdido del Perú!");
            }
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            juego = new TesoroPeru();

            ActualizarPantalla();
        }

    }
}
