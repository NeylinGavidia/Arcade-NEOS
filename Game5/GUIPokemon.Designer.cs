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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIPokemon));
            this.pnlCarga = new System.Windows.Forms.Panel();
            this.pnlHistoria = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCarga.SuspendLayout();
            this.pnlHistoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCarga
            // 
            this.pnlCarga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCarga.Controls.Add(this.pnlHistoria);
            this.pnlCarga.Controls.Add(this.label2);
            this.pnlCarga.Controls.Add(this.label3);
            this.pnlCarga.Controls.Add(this.label1);
            this.pnlCarga.Location = new System.Drawing.Point(1, 0);
            this.pnlCarga.Name = "pnlCarga";
            this.pnlCarga.Size = new System.Drawing.Size(904, 547);
            this.pnlCarga.TabIndex = 0;
            // 
            // pnlHistoria
            // 
            this.pnlHistoria.BackColor = System.Drawing.Color.SeaShell;
            this.pnlHistoria.Controls.Add(this.textBox1);
            this.pnlHistoria.Controls.Add(this.pictureBox1);
            this.pnlHistoria.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlHistoria.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoria.Name = "pnlHistoria";
            this.pnlHistoria.Size = new System.Drawing.Size(904, 547);
            this.pnlHistoria.TabIndex = 1;
            this.pnlHistoria.Visible = false;
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
            // GUIPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 543);
            this.Controls.Add(this.pnlCarga);
            this.Name = "GUIPokemon";
            this.Text = "GUIPokemon";
            this.Load += new System.EventHandler(this.GUIPokemon_Load);
            this.Click += new System.EventHandler(this.GUIPokemon_Click);
            this.pnlCarga.ResumeLayout(false);
            this.pnlCarga.PerformLayout();
            this.pnlHistoria.ResumeLayout(false);
            this.pnlHistoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}