namespace Game1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstSospechosos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.btnInterrogar = new System.Windows.Forms.Button();
            this.btnAcusar = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.relojMaquina = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstSospechosos
            // 
            this.lstSospechosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSospechosos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSospechosos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSospechosos.ForeColor = System.Drawing.Color.White;
            this.lstSospechosos.FormattingEnabled = true;
            this.lstSospechosos.ItemHeight = 19;
            this.lstSospechosos.Location = new System.Drawing.Point(36, 22);
            this.lstSospechosos.Name = "lstSospechosos";
            this.lstSospechosos.Size = new System.Drawing.Size(208, 249);
            this.lstSospechosos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXPEDIENTE DE SOSPECHOSOS:";
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.Lime;
            this.txtPantalla.Location = new System.Drawing.Point(290, 22);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(369, 249);
            this.txtPantalla.TabIndex = 2;
            // 
            // btnInterrogar
            // 
            this.btnInterrogar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInterrogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterrogar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterrogar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInterrogar.Location = new System.Drawing.Point(36, 306);
            this.btnInterrogar.Name = "btnInterrogar";
            this.btnInterrogar.Size = new System.Drawing.Size(100, 37);
            this.btnInterrogar.TabIndex = 3;
            this.btnInterrogar.Text = "INTERROGAR";
            this.btnInterrogar.UseVisualStyleBackColor = false;
            this.btnInterrogar.Click += new System.EventHandler(this.btnInterrogar_Click);
            // 
            // btnAcusar
            // 
            this.btnAcusar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAcusar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcusar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcusar.ForeColor = System.Drawing.Color.Red;
            this.btnAcusar.Location = new System.Drawing.Point(261, 306);
            this.btnAcusar.Name = "btnAcusar";
            this.btnAcusar.Size = new System.Drawing.Size(124, 37);
            this.btnAcusar.TabIndex = 4;
            this.btnAcusar.Text = "ACUSAR ASESINO";
            this.btnAcusar.UseVisualStyleBackColor = false;
            this.btnAcusar.Click += new System.EventHandler(this.btnAcusar_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorial.Location = new System.Drawing.Point(512, 306);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(147, 37);
            this.btnHistorial.TabIndex = 5;
            this.btnHistorial.Text = "REVISAR HISTORIAL";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // relojMaquina
            // 
            this.relojMaquina.Interval = 30;
            this.relojMaquina.Tick += new System.EventHandler(this.relojMaquina_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 369);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnAcusar);
            this.Controls.Add(this.btnInterrogar);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSospechosos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Detective Nodo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSospechosos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btnInterrogar;
        private System.Windows.Forms.Button btnAcusar;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Timer relojMaquina;
    }
}