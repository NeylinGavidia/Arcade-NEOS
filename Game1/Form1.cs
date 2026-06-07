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

        //controla la máquina de escribir
        string textoCompleto = "";
        int posicionLetra = 0;
        Nodo nodoAct = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string tl =
                " ───  🗂️  D E T E C T I V E   N O D O  🔍  ───";

            lblTitulo.Text = tl;
            lblTitulo.Font = new Font("Arial Black", 12, FontStyle.Italic);
            lblTitulo.ForeColor = Color.White; 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.AutoSize = false;
            lblTitulo.Size = new Size(this.ClientSize.Width, 30);
            lblTitulo.Location = new Point(0, 15);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            dtn.CrearCaso("Selene", "Dante", "Damián", "Astrid", "Bruno");
            lstSospechosos.Items.Clear();
            Nodo temp = dtn.ls.prim;
            do
            {
                lstSospechosos.Items.Add(temp.dato.nomb);
                temp = temp.sig;
            } while (temp != dtn.ls.prim);
            nodoAct = dtn.ls.prim;
            txtPantalla.Text = "========================================\r\n" +
                               " 🕒 HORA DEL REPORTE: 01:30 A.M.\r\n" +
                               " LUGAR DEL CRIMEN: Mansión Hillside\r\n" +
                               "========================================\r\n\r\n" +
                               "🕵️‍ DETECTIVE NODO: El crimen ocurrió hace poco más de una hora, entre la medianoche y las 12:30.\r\n\r\n" +
                               "Los 5 sospechosos siguen dentro de la casa. Selecciona uno en el expediente para comenzar el interrogatorio.";
        }

        private void relojMaquina_Tick(object sender, EventArgs e)
        {
            if (posicionLetra < textoCompleto.Length)
            {
                txtPantalla.Text = txtPantalla.Text + textoCompleto[posicionLetra];
                posicionLetra = posicionLetra + 1;
            }
            else
            {
                relojMaquina.Enabled = false;
                lstSospechosos.Enabled = true;
            }
        }

        private void btnInterrogar_Click(object sender, EventArgs e)
        {
            if (nodoAct != null)
            {
                txtPantalla.Clear();
                textoCompleto = dtn.Interrogar(nodoAct.dato);
                relojMaquina.Enabled = false;
                posicionLetra = 0;
                lstSospechosos.Enabled = false;
                relojMaquina.Enabled = true;
            }
        }

        private void btnAcusar_Click(object sender, EventArgs e)
        {
            if (lstSospechosos.SelectedIndex != -1)
            {
                string nombre = lstSospechosos.SelectedItem.ToString();

                if (dtn.Acusar(nombre))
                {
                    MessageBox.Show("¡CASO RESUELTO!\r\n\r\nEl verdadero asesino es " + nombre + ". ¡Buen trabajo, detective!", "¡Felicidades!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPantalla.Clear();
                    txtPantalla.Text = "🚨 CASO CERRADO: El culpable está tras las rejas.";
                }
                else
                {
                    MessageBox.Show("INCORRECTO\r\n\r\n" + nombre + " es inocente. Te has equivocado y el culpable sigue libre.", "Sigue investigando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPantalla.Clear();
                    txtPantalla.Text = "❌ INFORME: Acusación fallida contra " + nombre + ". Revisa las pistas de nuevo.";
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Persona p = dtn.pl.Desapilar();
            txtPantalla.Clear();
            if (p != null)
            {
                textoCompleto = "📁 HISTORIAL CONFIDENCIAL DESAPILADO:\r\n" + p.ToString();
            }
            else
            {
                textoCompleto = "📁 PILA VACÍA: No quedan más expedientes en el historial policial.";
            }
            posicionLetra = 0;
            lstSospechosos.Enabled = false;
            relojMaquina.Enabled = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (nodoAct != null)
            {
                nodoAct = nodoAct.ant;
                txtPantalla.Clear();
                textoCompleto = "📁 ARCHIVO CONFIDENCIAL: Perfil del Sospechoso <<<\r\n" + nodoAct.dato.ToString();
                relojMaquina.Enabled = false;
                posicionLetra = 0;
                relojMaquina.Enabled = true;
                lstSospechosos.SelectedItem = nodoAct.dato.nomb;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nodoAct != null)
            {
                nodoAct = nodoAct.sig;
                txtPantalla.Clear();
                textoCompleto = "📁 ARCHIVO CONFIDENCIAL: Perfil del Sospechoso >>>\r\n" + nodoAct.dato.ToString();
                relojMaquina.Enabled = false;
                posicionLetra = 0;
                relojMaquina.Enabled = true;
                lstSospechosos.SelectedItem = nodoAct.dato.nomb;
            }
        }

        private void lstSospechosos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombSelec = lstSospechosos.SelectedItem.ToString();
            Nodo temp = dtn.ls.prim;
            bool encontrado = false;

            do
            {
                if (temp.dato.nomb == nombSelec)
                {
                    nodoAct = temp;
                    encontrado = true;
                    break;
                }
                temp = temp.sig;
            } while (temp != dtn.ls.prim && !encontrado);
        }
    }
}
