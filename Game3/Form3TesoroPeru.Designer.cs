namespace Game3
{
    partial class Form3TesoroPeru
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
            this.picEscena = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblInventarioTitulo = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEscena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(103, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(602, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🏆 EL TESORO PERDIDO DEL PERÚ 🏆";
            // 
            // picEscena
            // 
            this.picEscena.Location = new System.Drawing.Point(216, 67);
            this.picEscena.Name = "picEscena";
            this.picEscena.Size = new System.Drawing.Size(376, 180);
            this.picEscena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEscena.TabIndex = 1;
            this.picEscena.TabStop = false;
            this.picEscena.Click += new System.EventHandler(this.picEscena_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Location = new System.Drawing.Point(202, 250);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(400, 120);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "label1";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblInventarioTitulo
            // 
            this.lblInventarioTitulo.AutoSize = true;
            this.lblInventarioTitulo.Location = new System.Drawing.Point(226, 381);
            this.lblInventarioTitulo.Name = "lblInventarioTitulo";
            this.lblInventarioTitulo.Size = new System.Drawing.Size(65, 16);
            this.lblInventarioTitulo.TabIndex = 3;
            this.lblInventarioTitulo.Text = "Inventario";
            // 
            // lblInventario
            // 
            this.lblInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInventario.Location = new System.Drawing.Point(213, 413);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(250, 80);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "Vacío";
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(213, 510);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(133, 42);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "◀⬅⬅\r\nOpción 1";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(430, 510);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(149, 42);
            this.btnDerecha.TabIndex = 6;
            this.btnDerecha.Text = " ⬅⬅▶︎\r\nOpción 2";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(312, 576);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(150, 38);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // Form3TesoroPeru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 639);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblInventarioTitulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.picEscena);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form3TesoroPeru";
            this.Text = "El Tesoro Perdido del Perú";
            ((System.ComponentModel.ISupportInitialize)(this.picEscena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picEscena;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblInventarioTitulo;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnReiniciar;
    }
}