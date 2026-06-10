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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Game5
{
    public partial class GUIPokemon : Form
    {
        private Arbol5 arbol = new Arbol5();
        private Pokemon pjugador; //pokemon jugador
        private Pokemon prival; //pokemon rival
        public string atqp; //tipo de ataque pokemon jugador
        public string atqr; //tipo de ataque de pokemon rival
        int pas = 0;
        string gender;
        string player;
        int anchoVida = 140; //este es el panel para vida
        Random rnd = new Random(); //para randomizar;
        string resultado; //esto para la batalla, sino no puedo moverme
        public GUIPokemon()
        {
            InitializeComponent();

            picChico.Cursor = Cursors.Hand; //esto es para que se vea mas bonito al seleccionar, con otro cursor
            picChica.Cursor = Cursors.Hand;
            picBulbasaur.Cursor = Cursors.Hand;
            pictCharmander.Cursor = Cursors.Hand; // encima lo borre mal AHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
            picSquirtle.Cursor = Cursors.Hand;

            pnlHistoria.Click += pnlHistoria_Click;
            pnlHistoria2.Click += pnlHistoria2_Click;
            pnlHistoria3.Click += pnlHistoria3_Click;
            pnlMisterioso.Click += pnlMisterioso_Click;
            pnlRival.Click += pnlRival_Click;
            pnlOakyGary.Click += pnlOakyGary_Click;
            pnlGary.Click += pnlGary_Click;
            pnlReto.Click += pnlReto_Click;
            pnlBatalla.Click += pnlBatalla_Click;
            pnlResultado.Click += pnlResultado_Click;
        }

        private void SiguienteDialogo()
        {
            pas++;
            MessageBox.Show("pas = " + pas); //este ayuda a ver el doble click solito

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
                MostrarPanel(pnlGenero);
                pnlHistoria.Visible = true; //se soluciono esto qwq

            }
            else if (pas == 4)
            {
                MostrarPanel(pnlName);

            }
            else if (pas == 5)
            {
                MostrarPanel(pnlPok);

            }
            else if (pas == 6) //aqui debe ser asi para que pase de uno en uno para que muestre diversos mensaje en el mismo cuadro
            {
                if (pjugador == null)
                {
                    MessageBox.Show("Primero elige un Pokémon.");
                    pas = 5;
                    MostrarPanel(pnlPok);
                    return;
                }

                MostrarPanel(pnlHistoria2);
                textBox4.Text = $"({pjugador.name} ha sido añadido a tu Pokédex)";
            }
            else if (pas == 7)
            {
                textBox4.Text = "Profesor Oak: Ahora podrás ir de avent-";
            }
            else if (pas == 8)
            {
                textBox4.Text = "Sistema: Pasos se oyen acercándose";
            }
            else if (pas == 9)
            {
                if (gender == "Chico")
                {
                    pictureBox7.Image = Properties.Resources.redu;
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.iu1;
                }

                textBox5.Text = "!!!!!!!!!!!!!";
                MostrarPanel(pnlHistoria3);
            }
            else if (pas == 10) //aqui gary misterioso
            {
                textBox5.Text = "Sistema: Un misterioso chico llega .-.";
            }
            else if (pas == 11)
            {
                textBox6.Text = "Chico misterioso: Yo también elegiré un pokémon";
                MostrarPanel(pnlMisterioso);
            }
            else if (pas == 12) //aqui ya agrego el metodo de elegir
            {
                ElegirRival();
                MostrarPanel(pnlRival);
                if (gender == "Chico")
                {
                    pictureBox8.Image = Properties.Resources.redg;
                }
                else
                {
                    pictureBox8.Image = Properties.Resources.leag;
                }

                textBox7.Text = "El chico toma una pokebola de la mesa";
            }
            else if (pas == 13)
            {
                textBox7.Text = "Chico misterioso: Me quedaré con esta";
            }
            else if (pas == 14) //desde aqui profesor aparece y gary de fondo xd es decir otro panel
            {
                MostrarPanel(pnlOakyGary);
                textBox8.Text = $"Profesor Oak: Lo siento {player}, ¿recuerdas a mi sobrino Gary? Jugaban juntos de pequeños";
            }
            else if (pas == 15)
            {
                textBox8.Text = "Profesor Oak: Bueno, ahora ambos tienen una gran responsabilidad, así que cuiden bien de esos pokemones.";
            }
            else if (pas == 16)
            {
                textBox8.Text = "Te apresuras a salir";
            }
            else if (pas == 17)
            {
                MostrarPanel(pnlGary);
                textBox9.Text = $"Gary: Espera {player}";
            }
            else if (pas == 18)
            {
                textBox9.Text = "Gary: Probemos nuestro pokemones, ¿o tienes miedo?";
            }
            else if (pas == 19)
            {
                MostrarPanel(pnlReto);
                if (gender == "Chico")
                {
                    pictureBox9.Image = Properties.Resources.images__1_;
                }
                else
                {
                    pictureBox9.Image = Properties.Resources.leafvsgary;
                }

                textBox10.Text = "La batalla comienza. ¡Preparate!";
            }
            else if (pas == 20)
            {
                textBox10.Text = $"Has elegido a {pjugador.name}";
            }
            else if (pas == 21)
            {
                textBox10.Text = $"Gary elegido a {prival.name}";
            }
            else if (pas == 22)
            {
                OcultarBotonesBatalla();
                pnlVidaR.Visible = true;
                pnlVidaP.Visible = true;
                pnlOculto.Visible = true;

                if (pjugador.code == 1 && prival.code == 4) //que gusto de complicarme la vida qwq
                {
                    pictureBox10.Image = Properties.Resources.bulvschar;
                }
                else if (pjugador.code == 1 && prival.code == 7)
                {
                    pictureBox10.Image = Properties.Resources.bulvssqui;
                }
                else if (pjugador.code == 4 && prival.code == 1)
                {
                    pictureBox10.Image = Properties.Resources.charvsbul;
                }
                else if (pjugador.code == 4 && prival.code == 7)
                {
                    pictureBox10.Image = Properties.Resources.charvssqu;
                }
                else if (pjugador.code == 7 && prival.code == 1)
                {
                    pictureBox10.Image = Properties.Resources.squivsbul;
                }
                else
                {
                    pictureBox10.Image = Properties.Resources.squivschar;
                }
            }
            else if (pas == 23)
            {
                MostrarPanel(pnlBatalla);
                textBox11.Text = $"Los PS de {prival.name} son {prival.ps}. Nivel 5\r\n\nLos PS de tu {pjugador.name} son {pjugador.ps} Nivel 5";
                OcultarBotonesBatalla();
                
            }
            else if (pas == 24)
            {
                MostrarPanel(pnlBatalla);
                textBox11.Text = "¿Qué quieres hacer?";
                MostrarBotonesBatalla();
                ActualizarVida();

            }
            else if (pas == 25)
            {
                
            }
            else if (pas == 26)
            {
                MostrarPanel(pnlResultado);
                textBox12.Text = $"Gary: Tsk... ganaste esta vez, {player}.";
            }
            else if (pas == 35)
            {
                textBox12.Text = $"Gary: Tsk, no importa. La próxima vez te ganaré {player}. ¡Me voy a entrenar!";
            }
            else if (pas == 45)
            {
                textBox12.Text = "Sistema: Gary sale del laboratorio con decepción.";
            }
        }
        //ELECCCIONES DE POKEMON
        private void ElegirPokemon(int codigo) //trayendo de PokeDemo qwq odio esto auxilienme
        {
            pjugador = arbol.Buscar(codigo);

            if (pjugador == null)
            {
                MessageBox.Show("No has elegido pokemon");
                return;
            }

            if (pjugador.name == "Charmander")
            {
                atqp = "Arañazo";
            }
            else
            {
                atqp = "Placaje";
            }

            MostrarPanel(pnlHistoria2);

            textBox4.Text = $"Profesor Oak: Excelente, elegiste a {pjugador.name}.";
            pas = 5;
        }
        private void ElegirRival()
        {
            int opcion;
            int codigo;

            do
            {
                opcion = rnd.Next(1, 4);

                if (opcion == 1)
                {
                    codigo = 1;
                }
                else if (opcion == 2)
                {
                    codigo = 4;
                }
                else
                {
                    codigo = 7;
                }

                prival = arbol.Buscar(codigo);

            } while (prival == null || prival.code == pjugador.code);

            if (prival.name == "Charmander")
            {
                atqr = "Arañazo";
            }
            else
            {
                atqr = "Placaje";
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
            CargarPokemon();

            MostrarPanel(pnlCarga);
            btnLucha.Visible = false;
            btnMochila.Visible = false;
            btnPokemon.Visible = false;
            btnHuida.Visible = false;

            timerCarga.Interval = 2000;
            timerCarga.Start();
        }
        private void CargarPokemon() //trayendo metodos de PokeDemo qwq me complique la vida la verdad
        {
            arbol.Insertar(new Pokemon("Bulbasaur", "Planta", 11, 10, 20));
            arbol.Insertar(new Pokemon("Charmander", "Fuego", 12, 9, 20));
            arbol.Insertar(new Pokemon("Squirtle", "Agua", 10, 11, 20));
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
            MostrarPanel(pnlHistoria);
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
        private void pnlHistoria2_Click(object sender, EventArgs e) // tanto para que con esto si funcion, soy gil
        {
            SiguienteDialogo();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picChico_Click(object sender, EventArgs e)
        {
            gender = "Chico";
            MostrarPanel(pnlHistoria);
            textBox1.Text = "Entiendo, eres un chico.";
            pas = 3;
        }

        private void picChica_Click(object sender, EventArgs e)
        {
            gender = "Chica";
            MostrarPanel(pnlHistoria);
            textBox1.Text = "Entiendo, eres una chica.";
            pas = 3; //sino funciona con esto lloro qwq
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
                MessageBox.Show("Nombre no válido");
                return;
            }

            player = txtName.Text.Trim(); //aqui para que quite espacios

            MostrarPanel(pnlHistoria2);
            textBox4.Text = $"Profesor Oak: Hola, {player}. Hoy elegirás un Pokémon que te acompañará en tus aventuras.";
            pas = 4; //esto tambien mal de 5 a 4, sino no funciona
        }

        private void picBulbasaur_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.Mostrar1(1)); //ahora si se puede? Si xd
            ElegirPokemon(1);
        }

        private void pictCharmander_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.Mostrar1(4));
            ElegirPokemon(4);
        }

        private void picSquirtle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.Mostrar1(7));
            ElegirPokemon(7);
        }

        private void pnlHistoria2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarPanel(Panel panel) //tuve que agregar esto porque entre tanto panel ni yo entendia que estaba activo o no, ojala lo solucione
        {
            pnlCarga.Visible = false;
            pnlHistoria.Visible = false;
            pnlGenero.Visible = false;
            pnlName.Visible = false;
            pnlHistoria2.Visible = false;
            pnlPok.Visible = false;
            pnlHistoria3.Visible = false;
            pnlMisterioso.Visible = false;
            pnlRival.Visible = false;
            pnlOakyGary.Visible = false;
            pnlGary.Visible = false;
            pnlReto.Visible = false;
            pnlBatalla.Visible = false;
            pnlResultado.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void label4_Click_1(object sender, EventArgs e) //bueno se me fue la mano xd pero son labels ahora para poder ahcerlo transparente
        {

        }
        private void pnlHistoria3_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlHistoria3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void pnlMisterioso_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlRival_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlOakyGary_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlGary_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlReto_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
        private void pnlBatalla_Click(object sender, EventArgs e)
        {
            if (pjugador.ps > 0 && prival.ps > 0)
            {
                textBox11.Text = "¿Qué quieres hacer?";
                MostrarBotonesBatalla();
            }
        }
        private void ActualizarVida() //metodo para batalla para que baje la barra de vida
        {
            if (pjugador.ps < 0) //mas ordenadito
                pjugador.ps = 0;
            if (prival.ps < 0) 
                prival.ps = 0;

            if (pjugador.ps > 20) 
                pjugador.ps = 20;
            if (prival.ps > 20) 
                prival.ps = 20;

            pnlVidaP.Width = (pjugador.ps * anchoVida) / 20; //esto es para el ancho de la vida
            pnlVidaR.Width = (prival.ps * anchoVida) / 20;

            if (pjugador.ps > 10)
                pnlVidaP.BackColor = Color.PaleGreen;
            else if (pjugador.ps > 5)
                pnlVidaP.BackColor = Color.Yellow;
            else
                pnlVidaP.BackColor = Color.Red;

            if (prival.ps > 10)
                pnlVidaR.BackColor = Color.PaleGreen;
            else if (prival.ps > 5)
                pnlVidaR.BackColor = Color.Yellow;
            else
                pnlVidaR.BackColor = Color.Red;
        }
        private void btnLucha_Click(object sender, EventArgs e)
        {
            Atacar();
        }
        private void btnMochila_Click(object sender, EventArgs e)
        {
            textBox11.Text = "No tienes objetos disponibles.";
            OcultarBotonesBatalla();
        }
        private void btnPokemon_Click(object sender, EventArgs e)
        {
            textBox11.Text = "No tienes más Pokémon disponibles.";
            OcultarBotonesBatalla();
        }
        private void btnHuida_Click(object sender, EventArgs e)
        {
            pjugador.ps = 0;
            ActualizarVida();
            OcultarBotonesBatalla();
            resultado = "Huir";
            pas = 44;
            textBox11.Text = "(" + pjugador.name + " ha huido)\r\n\r\nGary: Sabía que no tenías coraje JAJAJA.";
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void Atacar()
        {
            OcultarBotonesBatalla(); //ojala

            int dañoJugador = rnd.Next(1, pjugador.atq + 1);
            int dfj = dañoJugador - (prival.def / 2);

            if (dfj < 1)
                dfj = 1;

            prival.ps = prival.ps - dfj;
            ActualizarVida();

            textBox11.Text = pjugador.name + " usó " + atqp +"\r\n" + prival.name + " perdió " + dfj + " PS." +" (" + prival.ps + "/20)"; ;

            if (prival.ps <= 0)
            { 
                resultado = "Ganar";
                pas = 25;
                return; //sin esto no cargan los mensajes anteriores
            }

            int dañoRival = rnd.Next(1, prival.atq + 1);
            int dfr = dañoRival - ((pjugador.def / 2)+1);

            if (dfr < 1)
                dfr = 1;

            pjugador.ps = pjugador.ps - dfr;
            ActualizarVida();

            textBox11.Text = textBox11.Text + "\r\n\r\n" +prival.name + " usó " + atqr + "\r\n" + pjugador.name + " perdió " + dfr + " PS." +" (" + pjugador.ps + "/20)";
            
            if (pjugador.ps <= 0)
            {
                resultado = "Perder";
                pas = 34;
                return;
            }
        }
        private void OcultarBotonesBatalla()
        {
            btnLucha.Visible = false;
            btnMochila.Visible = false;
            btnPokemon.Visible = false;
            btnHuida.Visible = false;
        }

        private void MostrarBotonesBatalla()
        {
            btnLucha.Visible = true;
            btnMochila.Visible = true;
            btnPokemon.Visible = true;
            btnHuida.Visible = true;
        }
        private void pnlResultado_Click(object sender, EventArgs e)
        {
            SiguienteDialogo();
        }
    }
}
