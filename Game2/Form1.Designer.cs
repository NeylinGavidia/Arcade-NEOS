namespace Game2
{
    partial class FrmFnutivinanza
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
            this.lblVidas = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lblPistaTitulo = new System.Windows.Forms.Label();
            this.lblPista = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lstFrutas = new System.Windows.Forms.ListBox();
            this.gbFrutas = new System.Windows.Forms.GroupBox();
            this.gbIntentos = new System.Windows.Forms.GroupBox();
            this.lstIntentos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFrutas.SuspendLayout();
            this.gbIntentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FRUTIVINANZA  ";
            // 
            // lblVidas
            // 
            this.lblVidas.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(173, 59);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(301, 40);
            this.lblVidas.TabIndex = 1;
            this.lblVidas.Text = "Vidas";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(375, 59);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(301, 40);
            this.lblPuntaje.TabIndex = 2;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // lblPistaTitulo
            // 
            this.lblPistaTitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPistaTitulo.Location = new System.Drawing.Point(29, 90);
            this.lblPistaTitulo.Name = "lblPistaTitulo";
            this.lblPistaTitulo.Size = new System.Drawing.Size(301, 40);
            this.lblPistaTitulo.TabIndex = 3;
            this.lblPistaTitulo.Text = "Pista";
            // 
            // lblPista
            // 
            this.lblPista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPista.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.Location = new System.Drawing.Point(17, 121);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(685, 52);
            this.lblPista.TabIndex = 4;
            this.lblPista.Text = "Aqui aparecera la pista";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 209);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(301, 40);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 209);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 22);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerificar.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.Black;
            this.btnVerificar.Location = new System.Drawing.Point(367, 196);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 35);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            // 
            // lstFrutas
            // 
            this.lstFrutas.FormattingEnabled = true;
            this.lstFrutas.ItemHeight = 24;
            this.lstFrutas.Location = new System.Drawing.Point(0, 29);
            this.lstFrutas.Name = "lstFrutas";
            this.lstFrutas.Size = new System.Drawing.Size(313, 172);
            this.lstFrutas.TabIndex = 9;
            // 
            // gbFrutas
            // 
            this.gbFrutas.Controls.Add(this.lstFrutas);
            this.gbFrutas.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrutas.Location = new System.Drawing.Point(17, 283);
            this.gbFrutas.Name = "gbFrutas";
            this.gbFrutas.Size = new System.Drawing.Size(313, 202);
            this.gbFrutas.TabIndex = 8;
            this.gbFrutas.TabStop = false;
            this.gbFrutas.Text = "Frutas Disponibles";
            // 
            // gbIntentos
            // 
            this.gbIntentos.Controls.Add(this.lstIntentos);
            this.gbIntentos.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntentos.Location = new System.Drawing.Point(404, 283);
            this.gbIntentos.Name = "gbIntentos";
            this.gbIntentos.Size = new System.Drawing.Size(313, 191);
            this.gbIntentos.TabIndex = 9;
            this.gbIntentos.TabStop = false;
            this.gbIntentos.Text = "Intentos Incorrectos";
            // 
            // lstIntentos
            // 
            this.lstIntentos.FormattingEnabled = true;
            this.lstIntentos.ItemHeight = 24;
            this.lstIntentos.Location = new System.Drawing.Point(0, 30);
            this.lstIntentos.Name = "lstIntentos";
            this.lstIntentos.Size = new System.Drawing.Size(313, 172);
            this.lstIntentos.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(303, 536);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = " X Salir ";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMostrar.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(503, 196);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(199, 35);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "Mostrar Frutas ";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(138, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "❤️";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(483, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "🍇";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "🍎";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(336, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "⭐";
            // 
            // FrmFnutivinanza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 651);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbIntentos);
            this.Controls.Add(this.gbFrutas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPista);
            this.Controls.Add(this.lblPistaTitulo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFnutivinanza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRUTIVINANZA";
            this.gbFrutas.ResumeLayout(false);
            this.gbIntentos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblPistaTitulo;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ListBox lstFrutas;
        private System.Windows.Forms.GroupBox gbFrutas;
        private System.Windows.Forms.GroupBox gbIntentos;
        private System.Windows.Forms.ListBox lstIntentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}