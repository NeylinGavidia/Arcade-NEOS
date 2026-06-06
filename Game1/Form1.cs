using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        DetectiveNodo dtn = new DetectiveNodo();

        // controla la máquina de escribir
        string textoCompleto = "";
        int posicionLetra = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtn.CrearCaso("Selene", "Dante", "Damián", "Astrid", "Bruno");
            lstSospechosos.Items.Clear();
            Nodo temp = dtn.ls.prim;
            do
            {
                lstSospechosos.Items.Add(temp.dato.nomb);
                temp = temp.sig;
            } while (temp != dtn.ls.prim);
            txtPantalla.Text = "🕵️‍♂️ DETECTIVE NODO: ¡Caso iniciado!\r\nSelecciona un sospechoso en el expediente y dale a Interrogar.\r\n\r\n";
        }

        //escribe letra por letra
        private void relojMaquina_Tick(object sender, EventArgs e)
        {
            if (posicionLetra < textoCompleto.Length)
            {
                txtPantalla.Text = txtPantalla.Text + textoCompleto[posicionLetra];
                posicionLetra = posicionLetra + 1; //se avanza a la letra que sigue
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "\r\n\r\n";
                relojMaquina.Enabled = false;
                lstSospechosos.Enabled = true;
            }
        }

        private void btnInterrogar_Click(object sender, EventArgs e)
        {
            if (lstSospechosos.SelectedIndex != -1)
            {
                string nombre = lstSospechosos.SelectedItem.ToString();
                Nodo temp = dtn.ls.prim;
                do
                {
                    if (temp.dato.nomb == nombre)
                    {
                        txtPantalla.ForeColor = System.Drawing.Color.White;
                        textoCompleto = "📝 " + dtn.Interrogar(temp.dato);
                        posicionLetra = 0;

                        lstSospechosos.Enabled = false;
                        relojMaquina.Enabled = true;
                        break;
                    }
                    temp = temp.sig;
                } while (temp != dtn.ls.prim);
            }
        }

        private void btnAcusar_Click(object sender, EventArgs e)
        {
            if (lstSospechosos.SelectedIndex != -1)
            {
                string nombre = lstSospechosos.SelectedItem.ToString();

                if (dtn.Acusar(nombre))
                {
                    txtPantalla.ForeColor = System.Drawing.Color.Lime;
                    textoCompleto = "🚨 ¡CASO RESUELTO! El verdadero asesino es: " + nombre + ". ¡Buen trabajo, detective!";
                }
                else
                {
                    txtPantalla.ForeColor = System.Drawing.Color.Red;
                    textoCompleto = "❌ INFORME: " + nombre + " es inocente. Te has equivocado y el culpable sigue libre.";
                }

                posicionLetra = 0;
                lstSospechosos.Enabled = false;
                relojMaquina.Enabled = true;
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Persona p = dtn.pl.Desapilar();
            txtPantalla.ForeColor = System.Drawing.Color.White;

            if (p != null)
            {
                textoCompleto = "📁 PILA: Se revisó el historial clínico/policial de -> " + p.nomb;
            }
            else
            {
                textoCompleto = "📁 PILA VACÍA: No quedan más sospechosos registrados en el historial.";
            }

            posicionLetra = 0;
            lstSospechosos.Enabled = false;
            relojMaquina.Enabled = true;
        }
    }
}
