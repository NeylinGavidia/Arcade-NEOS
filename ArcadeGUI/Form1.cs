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
using Game2;
using Game3;
using Game4;
using Game5;

namespace ArcadeGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGame1_Click(object sender, EventArgs e)
        {

        }

        private void btnGame2_Click(object sender, EventArgs e)
        {

        }
        private void btnGame3_Click(object sender, EventArgs e)
        {

        }

        private void btnGame4_Click(object sender, EventArgs e)
        {

        }

        private void btnGame5_Click(object sender, EventArgs e)
        {
            GUIPokemon pokemon = new GUIPokemon();
            pokemon.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
