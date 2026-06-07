using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game5
{
    public partial class GUIPokemon : Form
    {
        int pas = 0;
        string gender;
        public GUIPokemon()
        {
            InitializeComponent();
            picChico.BringToFront();
            picChica.BringToFront();

            pnlHistoria.Click += pnlHistoria_Click;
            picChico.Click += picChico_Click;
            picChica.Click += picChica_Click;

            picChico.Cursor = Cursors.Hand;
            picChica.Cursor = Cursors.Hand;
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
                pnlGenero.Visible = true;
                pnlGenero.BringToFront();
            }
            else if (pas == 3)
            {
                textBox1.Text = "Cuéntame un poco sobre ti, ¿cuál es tu nombre?";
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
            MessageBox.Show("Click en chico");
            gender = "Chico";
            pnlGenero.Visible = false;
            textBox1.Text = "Elegiste chico.";
        }

        private void picChica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click en chica");
            gender = "Chica";
            pnlGenero.Visible = false;
            textBox1.Text = "Elegiste chica.";
        }

        private void pnlGenero_Paint(object sender, PaintEventArgs e)
        {
            pnlGenero.Visible = true;
            pnlGenero.BringToFront();

            picChico.BringToFront();
            picChica.BringToFront();
        }
    }

}
