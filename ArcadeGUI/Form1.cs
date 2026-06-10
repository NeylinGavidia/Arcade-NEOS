using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            Form1 DetectiveNodo = new Form1();
            DetectiveNodo.Show();
            this.Hide();
        }

        private void btnGame2_Click(object sender, EventArgs e)
        {
            FrmFnutivinanza frutivinanza = new FrmFnutivinanza();
            frutivinanza.Show();
            this.Hide();
        }
        private void btnGame3_Click(object sender, EventArgs e)
        {
            Form3TesoroPeru juego3 = new Form3TesoroPeru();
            juego3.Show();
        }

        private void btnGame4_Click(object sender, EventArgs e)
        {
            DUNGEON_TREE dungeon_tree = new DUNGEON_TREE();
            dungeon_tree.Show();
            this.Hide();
        }

        private void btnGame5_Click(object sender, EventArgs e)
        {
            GUIPokemon pokemon = new GUIPokemon();
            pokemon.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir sa = new Salir();
            sa.Show();
            this.Hide();
            timer1.Interval = 2000;
            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
