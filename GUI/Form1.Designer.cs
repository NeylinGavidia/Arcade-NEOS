namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.txtHistorial = new System.Windows.Forms.TextBox();
            this.txtAcusar = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnInterrogar = new System.Windows.Forms.Button();
            this.btnAcusar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(42, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DETECTIVE NODO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Cyan;
            this.lblNombre.Location = new System.Drawing.Point(42, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Yellow;
            this.lblRol.Location = new System.Drawing.Point(42, 113);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 20);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.ForeColor = System.Drawing.Color.LightGreen;
            this.lblHabitacion.Location = new System.Drawing.Point(42, 146);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(69, 20);
            this.lblHabitacion.TabIndex = 3;
            this.lblHabitacion.Text = "Habitación";
            // 
            // txtHistorial
            // 
            this.txtHistorial.BackColor = System.Drawing.Color.Black;
            this.txtHistorial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorial.ForeColor = System.Drawing.Color.LightGray;
            this.txtHistorial.Location = new System.Drawing.Point(46, 316);
            this.txtHistorial.Multiline = true;
            this.txtHistorial.Name = "txtHistorial";
            this.txtHistorial.ReadOnly = true;
            this.txtHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorial.Size = new System.Drawing.Size(258, 113);
            this.txtHistorial.TabIndex = 5;
            // 
            // txtAcusar
            // 
            this.txtAcusar.BackColor = System.Drawing.Color.White;
            this.txtAcusar.ForeColor = System.Drawing.Color.Black;
            this.txtAcusar.Location = new System.Drawing.Point(46, 275);
            this.txtAcusar.Name = "txtAcusar";
            this.txtAcusar.Size = new System.Drawing.Size(140, 20);
            this.txtAcusar.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Green;
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(445, 256);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar Caso";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Gray;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(173, 186);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Gray;
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(46, 186);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 9;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnInterrogar
            // 
            this.btnInterrogar.BackColor = System.Drawing.Color.Blue;
            this.btnInterrogar.ForeColor = System.Drawing.Color.White;
            this.btnInterrogar.Location = new System.Drawing.Point(46, 229);
            this.btnInterrogar.Name = "btnInterrogar";
            this.btnInterrogar.Size = new System.Drawing.Size(75, 23);
            this.btnInterrogar.TabIndex = 10;
            this.btnInterrogar.Text = "Interrogar";
            this.btnInterrogar.UseVisualStyleBackColor = false;
            this.btnInterrogar.Click += new System.EventHandler(this.btnInterrogar_Click);
            // 
            // btnAcusar
            // 
            this.btnAcusar.BackColor = System.Drawing.Color.Red;
            this.btnAcusar.ForeColor = System.Drawing.Color.White;
            this.btnAcusar.Location = new System.Drawing.Point(173, 229);
            this.btnAcusar.Name = "btnAcusar";
            this.btnAcusar.Size = new System.Drawing.Size(75, 23);
            this.btnAcusar.TabIndex = 11;
            this.btnAcusar.Text = "Acusar";
            this.btnAcusar.UseVisualStyleBackColor = false;
            this.btnAcusar.Click += new System.EventHandler(this.btnAcusar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.btnAcusar);
            this.Controls.Add(this.btnInterrogar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtAcusar);
            this.Controls.Add(this.txtHistorial);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detective Nodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.TextBox txtHistorial;
        private System.Windows.Forms.TextBox txtAcusar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnInterrogar;
        private System.Windows.Forms.Button btnAcusar;
    }
}

