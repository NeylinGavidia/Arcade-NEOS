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
        public GUIPokemon()
        {
            InitializeComponent();
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
                textBox1.Text = "Cuéntame un poco sobre ti, ¿cuál es tu nombre?";
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
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

        private void GUIPokemon_Load(object sender, EventArgs e)
        {
           
        }

        private void GUIPokemon_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
    }

}
