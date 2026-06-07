namespace Game4
{
    partial class DUNGEON_TREE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.pnlLinea1 = new System.Windows.Forms.Panel();
            this.lblTextoJugador = new System.Windows.Forms.Label();
            this.lblTextoVida = new System.Windows.Forms.Label();
            this.lblTextoOro = new System.Windows.Forms.Label();
            this.lblTextoSala = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.lblOro = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.rtbHistoria = new System.Windows.Forms.RichTextBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gold;
            this.lblTitulo.Location = new System.Drawing.Point(129, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(327, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DUNGEON TREE";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(44, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(127, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(355, 63);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(120, 35);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pnlLinea1
            // 
            this.pnlLinea1.BackColor = System.Drawing.Color.Black;
            this.pnlLinea1.ForeColor = System.Drawing.Color.White;
            this.pnlLinea1.Location = new System.Drawing.Point(0, 110);
            this.pnlLinea1.Name = "pnlLinea1";
            this.pnlLinea1.Size = new System.Drawing.Size(600, 2);
            this.pnlLinea1.TabIndex = 4;
            // 
            // lblTextoJugador
            // 
            this.lblTextoJugador.AutoSize = true;
            this.lblTextoJugador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoJugador.ForeColor = System.Drawing.Color.White;
            this.lblTextoJugador.Location = new System.Drawing.Point(44, 130);
            this.lblTextoJugador.Name = "lblTextoJugador";
            this.lblTextoJugador.Size = new System.Drawing.Size(82, 23);
            this.lblTextoJugador.TabIndex = 5;
            this.lblTextoJugador.Text = "Jugador:";
            // 
            // lblTextoVida
            // 
            this.lblTextoVida.AutoSize = true;
            this.lblTextoVida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoVida.ForeColor = System.Drawing.Color.White;
            this.lblTextoVida.Location = new System.Drawing.Point(44, 162);
            this.lblTextoVida.Name = "lblTextoVida";
            this.lblTextoVida.Size = new System.Drawing.Size(51, 23);
            this.lblTextoVida.TabIndex = 6;
            this.lblTextoVida.Text = "Vida:";
            // 
            // lblTextoOro
            // 
            this.lblTextoOro.AutoSize = true;
            this.lblTextoOro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoOro.ForeColor = System.Drawing.Color.White;
            this.lblTextoOro.Location = new System.Drawing.Point(44, 194);
            this.lblTextoOro.Name = "lblTextoOro";
            this.lblTextoOro.Size = new System.Drawing.Size(45, 23);
            this.lblTextoOro.TabIndex = 7;
            this.lblTextoOro.Text = "Oro:";
            // 
            // lblTextoSala
            // 
            this.lblTextoSala.AutoSize = true;
            this.lblTextoSala.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSala.ForeColor = System.Drawing.Color.White;
            this.lblTextoSala.Location = new System.Drawing.Point(44, 227);
            this.lblTextoSala.Name = "lblTextoSala";
            this.lblTextoSala.Size = new System.Drawing.Size(104, 23);
            this.lblTextoSala.TabIndex = 8;
            this.lblTextoSala.Text = "Sala Actual:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 2);
            this.panel1.TabIndex = 5;
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.White;
            this.lblJugador.Location = new System.Drawing.Point(147, 130);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(38, 23);
            this.lblJugador.TabIndex = 9;
            this.lblJugador.Text = "----";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.White;
            this.lblVida.Location = new System.Drawing.Point(148, 162);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(38, 23);
            this.lblVida.TabIndex = 10;
            this.lblVida.Text = "----";
            // 
            // lblOro
            // 
            this.lblOro.AutoSize = true;
            this.lblOro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOro.ForeColor = System.Drawing.Color.White;
            this.lblOro.Location = new System.Drawing.Point(148, 194);
            this.lblOro.Name = "lblOro";
            this.lblOro.Size = new System.Drawing.Size(38, 23);
            this.lblOro.TabIndex = 11;
            this.lblOro.Text = "----";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.White;
            this.lblSala.Location = new System.Drawing.Point(148, 227);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(38, 23);
            this.lblSala.TabIndex = 12;
            this.lblSala.Text = "----";
            // 
            // rtbHistoria
            // 
            this.rtbHistoria.BackColor = System.Drawing.Color.Black;
            this.rtbHistoria.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistoria.ForeColor = System.Drawing.Color.Lime;
            this.rtbHistoria.Location = new System.Drawing.Point(12, 388);
            this.rtbHistoria.Name = "rtbHistoria";
            this.rtbHistoria.ReadOnly = true;
            this.rtbHistoria.Size = new System.Drawing.Size(572, 250);
            this.rtbHistoria.TabIndex = 13;
            this.rtbHistoria.Text = "";
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Enabled = false;
            this.btnIzquierda.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(48, 665);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(120, 40);
            this.btnIzquierda.TabIndex = 14;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Enabled = false;
            this.btnDerecha.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(355, 665);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(120, 40);
            this.btnDerecha.TabIndex = 15;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 2);
            this.panel2.TabIndex = 6;
            // 
            // lblHistoria
            // 
            this.lblHistoria.AutoSize = true;
            this.lblHistoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoria.ForeColor = System.Drawing.Color.White;
            this.lblHistoria.Location = new System.Drawing.Point(12, 362);
            this.lblHistoria.Name = "lblHistoria";
            this.lblHistoria.Size = new System.Drawing.Size(88, 23);
            this.lblHistoria.TabIndex = 16;
            this.lblHistoria.Text = "HISTORIA";
            // 
            // DUNGEON_TREE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(596, 717);
            this.Controls.Add(this.lblHistoria);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.rtbHistoria);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblOro);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTextoSala);
            this.Controls.Add(this.lblTextoOro);
            this.Controls.Add(this.lblTextoVida);
            this.Controls.Add(this.lblTextoJugador);
            this.Controls.Add(this.pnlLinea1);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "DUNGEON_TREE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Tree";
            this.Load += new System.EventHandler(this.DUNGEON_TREE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Panel pnlLinea1;
        private System.Windows.Forms.Label lblTextoJugador;
        private System.Windows.Forms.Label lblTextoVida;
        private System.Windows.Forms.Label lblTextoOro;
        private System.Windows.Forms.Label lblTextoSala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblOro;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.RichTextBox rtbHistoria;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHistoria;
    }
}