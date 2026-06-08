namespace Game5
{
    partial class GUIPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPokemon));
            this.pnlCarga = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHistoria = new System.Windows.Forms.Panel();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.picChica = new System.Windows.Forms.PictureBox();
            this.picChico = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.pnlName = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlHistoria2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlCarga.SuspendLayout();
            this.pnlHistoria.SuspendLayout();
            this.pnlGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlHistoria2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCarga
            // 
            this.pnlCarga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCarga.Controls.Add(this.label2);
            this.pnlCarga.Controls.Add(this.label3);
            this.pnlCarga.Controls.Add(this.label1);
            this.pnlCarga.Location = new System.Drawing.Point(1, 0);
            this.pnlCarga.Name = "pnlCarga";
            this.pnlCarga.Size = new System.Drawing.Size(904, 547);
            this.pnlCarga.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wingdings", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(843, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "zzzzzzzzzzzzzzzzzzzzzzzzz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(843, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "zzzzzzzzzzzzzzzzzzzzzzzzz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(120, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGANDO ...";
            // 
            // pnlHistoria
            // 
            this.pnlHistoria.BackColor = System.Drawing.Color.SeaShell;
            this.pnlHistoria.Controls.Add(this.pnlGenero);
            this.pnlHistoria.Controls.Add(this.textBox1);
            this.pnlHistoria.Controls.Add(this.pictureBox1);
            this.pnlHistoria.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlHistoria.Location = new System.Drawing.Point(1, 0);
            this.pnlHistoria.Name = "pnlHistoria";
            this.pnlHistoria.Size = new System.Drawing.Size(904, 547);
            this.pnlHistoria.TabIndex = 1;
            this.pnlHistoria.Visible = false;
            // 
            // pnlGenero
            // 
            this.pnlGenero.AutoSize = true;
            this.pnlGenero.BackColor = System.Drawing.Color.Black;
            this.pnlGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGenero.BackgroundImage")));
            this.pnlGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGenero.Controls.Add(this.picChica);
            this.pnlGenero.Controls.Add(this.picChico);
            this.pnlGenero.Location = new System.Drawing.Point(0, 0);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(909, 552);
            this.pnlGenero.TabIndex = 2;
            this.pnlGenero.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGenero_Paint);
            // 
            // picChica
            // 
            this.picChica.BackColor = System.Drawing.Color.Transparent;
            this.picChica.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChica.BackgroundImage")));
            this.picChica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChica.Location = new System.Drawing.Point(519, 229);
            this.picChica.Name = "picChica";
            this.picChica.Size = new System.Drawing.Size(329, 302);
            this.picChica.TabIndex = 1;
            this.picChica.TabStop = false;
            this.picChica.Click += new System.EventHandler(this.picChica_Click);
            // 
            // picChico
            // 
            this.picChico.BackColor = System.Drawing.Color.Transparent;
            this.picChico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picChico.BackgroundImage")));
            this.picChico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picChico.Location = new System.Drawing.Point(39, 87);
            this.picChico.Name = "picChico";
            this.picChico.Size = new System.Drawing.Size(387, 324);
            this.picChico.TabIndex = 0;
            this.picChico.TabStop = false;
            this.picChico.Click += new System.EventHandler(this.picChico_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 329);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(877, 187);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "\r\n  Hola, bienvenido/a al pueblo Paleta.\r\n\r\n  Soy el profesor Oak.";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click_1);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerCarga
            // 
            this.timerCarga.Interval = 2000;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick_1);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.SeaShell;
            this.pnlName.Controls.Add(this.btnOk);
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.textBox2);
            this.pnlName.Controls.Add(this.pictureBox4);
            this.pnlName.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlName.Location = new System.Drawing.Point(1, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(904, 547);
            this.pnlName.TabIndex = 2;
            this.pnlName.Visible = false;
            this.pnlName.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlName_Paint);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Location = new System.Drawing.Point(574, 417);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 31);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Indigo;
            this.txtName.Location = new System.Drawing.Point(29, 417);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(539, 31);
            this.txtName.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 329);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(877, 187);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "\r\nCuéntame un poco sobre ti, ¿cuál es tu nombre?";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(901, 304);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnlHistoria2
            // 
            this.pnlHistoria2.BackColor = System.Drawing.Color.SeaShell;
            this.pnlHistoria2.Controls.Add(this.textBox4);
            this.pnlHistoria2.Controls.Add(this.pictureBox2);
            this.pnlHistoria2.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlHistoria2.Location = new System.Drawing.Point(1, 0);
            this.pnlHistoria2.Name = "pnlHistoria2";
            this.pnlHistoria2.Size = new System.Drawing.Size(904, 547);
            this.pnlHistoria2.TabIndex = 4;
            this.pnlHistoria2.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox4.Location = new System.Drawing.Point(14, 329);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(877, 187);
            this.textBox4.TabIndex = 1;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "\r\nCuéntame un poco sobre ti, ¿cuál es tu nombre?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(901, 304);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // GUIPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.pnlHistoria2);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlHistoria);
            this.Controls.Add(this.pnlCarga);
            this.MaximizeBox = false;
            this.Name = "GUIPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUIPokemon";
            this.Load += new System.EventHandler(this.GUIPokemon_Load);
            this.Click += new System.EventHandler(this.GUIPokemon_Click);
            this.pnlCarga.ResumeLayout(false);
            this.pnlCarga.PerformLayout();
            this.pnlHistoria.ResumeLayout(false);
            this.pnlHistoria.PerformLayout();
            this.pnlGenero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlHistoria2.ResumeLayout(false);
            this.pnlHistoria2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHistoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.PictureBox picChica;
        private System.Windows.Forms.PictureBox picChico;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlHistoria2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}