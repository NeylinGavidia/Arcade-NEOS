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
            this.lblTitulo.Location = new System.Drawing.Point(77, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(481, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🏆 EL TESORO PERDIDO DEL PERÚ 🏆";
            // 
            // picEscena
            // 
            this.picEscena.Image = global::Game3.Properties.Resources._11;
            this.picEscena.Location = new System.Drawing.Point(97, 54);
            this.picEscena.Margin = new System.Windows.Forms.Padding(2);
            this.picEscena.Name = "picEscena";
            this.picEscena.Size = new System.Drawing.Size(463, 247);
            this.picEscena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEscena.TabIndex = 1;
            this.picEscena.TabStop = false;
            this.picEscena.Click += new System.EventHandler(this.picEscena_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Location = new System.Drawing.Point(97, 294);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(463, 46);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "label1";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblInventarioTitulo
            // 
            this.lblInventarioTitulo.AutoSize = true;
            this.lblInventarioTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventarioTitulo.Location = new System.Drawing.Point(94, 340);
            this.lblInventarioTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventarioTitulo.Name = "lblInventarioTitulo";
            this.lblInventarioTitulo.Size = new System.Drawing.Size(81, 18);
            this.lblInventarioTitulo.TabIndex = 3;
            this.lblInventarioTitulo.Text = "Inventario";
            // 
            // lblInventario
            // 
            this.lblInventario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInventario.Location = new System.Drawing.Point(97, 368);
            this.lblInventario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(188, 65);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "Vacío";
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.DimGray;
            this.btnIzquierda.Location = new System.Drawing.Point(303, 383);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(100, 34);
            this.btnIzquierda.TabIndex = 5;
            this.btnIzquierda.Text = "◀⬅⬅\r\nOpción 1";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDerecha.Location = new System.Drawing.Point(430, 383);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(112, 34);
            this.btnDerecha.TabIndex = 6;
            this.btnDerecha.Text = " ⬅⬅▶︎\r\nOpción 2";
            this.btnDerecha.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Red;
            this.btnReiniciar.Location = new System.Drawing.Point(245, 451);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(112, 31);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click_1);
            // 
            // Form3TesoroPeru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(601, 519);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.lblInventarioTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.picEscena);
            this.Margin = new System.Windows.Forms.Padding(2);
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