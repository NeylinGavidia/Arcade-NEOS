using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2
{
    public partial class FrmFnutivinanza : Form
    {
        JuegoFrutas2 juego = new JuegoFrutas2();
        public FrmFnutivinanza()
        {
            InitializeComponent();
        }

        private void FrmFnutivinanza_Load(object sender, EventArgs e)
        {
            juego.CargarDatos();

            lblVidas.Text = "Vidas: " + juego.vidas;
            lblPuntaje.Text = "Puntaje: " + juego.puntaje;

            lblPista.Text = juego.ObtenerActual().pista;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstFrutas.Items.Clear();

            lstFrutas.Items.Add("1 - Manzana");
            lstFrutas.Items.Add("2 - Piña");
            lstFrutas.Items.Add("3 - Fresa");
            lstFrutas.Items.Add("4 - Uva");
            lstFrutas.Items.Add("5 - Mango");
            lstFrutas.Items.Add("6 - Sandia");
            lstFrutas.Items.Add("7 - Platano");
            lstFrutas.Items.Add("8 - Naranja");
            timerFrutas.Start();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int codigo;

            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Código ingresado: " + codigo);
                bool correcto = juego.Verificar(codigo);
                MessageBox.Show("Resultado: " + correcto);

                if (correcto)
                {
                    MessageBox.Show("¡Correcto!");
                }
                else
                {
                    MessageBox.Show("Incorrecto");

                    lstIntentos.Items.Add(codigo);
                }

                lblVidas.Text = "Vidas: " + juego.vidas;
                lblPuntaje.Text = "Puntaje: " + juego.puntaje;

                if (!juego.Ganaste())
                {
                    if (juego.ObtenerActual() != null)
                    {
                        lblPista.Text = juego.ObtenerActual().pista;
                    }
                }

                if (juego.Ganaste())
                {
                    MessageBox.Show("🎉 ¡Ganaste!");
                }

                if (juego.Perdiste())
                {
                    MessageBox.Show("💀 Perdiste");
                }

                txtCodigo.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerFrutas_Tick(object sender, EventArgs e)
        {
            lstFrutas.Items.Clear();

            timerFrutas.Stop();
        }
    }
}
