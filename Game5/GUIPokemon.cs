using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game5
{
    public partial class GUIPokemon : Form
    {
        int pas = 0;
        string gender;
        string player;
        public GUIPokemon()
        {
            InitializeComponent();

            picChico.Cursor = Cursors.Hand; //esto es para que se vea mas bonito al seleccionar, con otro cursor
            picChica.Cursor = Cursors.Hand;

            pnlHistoria.Click += pnlHistoria_Click;
        }
        private void SiguienteDialogo()
        {
            pas++;

            if (pas == 1)
            {
                textBox1.Text = "Soy el profesor Oak.";
            }
            else if (pas == 2)
            {
                textBox1.Text = "Primero, ¿eres chico o chica?";
                
            }
            else if (pas == 3)
            {
                pnlGenero.Visible = true;
                
            }
            else if (pas == 4)
            {
                pnlHistoria.Visible = false;
                pnlName.Visible = true;

            }
            else if (pas == 5)
            {
               
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUIPokemon_Load(object sender, EventArgs e) //para que primero se muestre la carga y luego la historia
        {
            pnlCarga.Visible = true;
            pnlHistoria.Visible = false;
            pnlGenero.Visible = false;
            timerCarga.Interval = 2000;
            timerCarga.Start();
        }

        private void GUIPokemon_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timerCarga_Tick_1(object sender, EventArgs e) //este timer esta chevere, ayuda a cambiar de paneles
        {
            timerCarga.Stop();
            pnlCarga.Visible = false;
            pnlHistoria.Visible = true;
            pas = 0;
            textBox1.Text = "Hola, bienvenido/a al pueblo Paleta.";
        }
        private void pnlHistoria_Click(object sender, EventArgs e) //este panel tiene que ir si o si :/ sino el click tendria que ser en el mismo lugar
        {
            if (pnlGenero.Visible == true)
            {
                return;
            }

            SiguienteDialogo();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picChico_Click(object sender, EventArgs e)
        {
            gender = "Chico";
            pnlGenero.Visible = false;
            textBox1.Text = "Entiendo, eres un chico.";
        }

        private void picChica_Click(object sender, EventArgs e)
        {
            gender = "Chica";
            pnlGenero.Visible = false;
            textBox1.Text = "Entiendo, eres una chica.";
        }

        private void pnlGenero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlName_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "") // esto para que no quede vacio, es solo una validacion
            {
                MessageBox.Show("Ingresa tu nombre.");
                return;
            }

            player = txtName.Text.Trim(); //aqui para que quite espacios

            pnlName.Visible = false;
            pnlHistoria.Visible = true;
            pnlHistoria.BringToFront();

            textBox1.Text = $"Hola, {player}. Hoy elegirás un Pokémon que te acompañará en tus aventuras.";
            pas = 5;
        }
    }

}
