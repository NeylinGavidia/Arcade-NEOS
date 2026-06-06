namespace ArcadeGUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGame1 = new System.Windows.Forms.Button();
            this.btnGame2 = new System.Windows.Forms.Button();
            this.btnGame3 = new System.Windows.Forms.Button();
            this.btnGame4 = new System.Windows.Forms.Button();
            this.btnGame5 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(209, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(591, 333);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(456, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGame1
            // 
            this.btnGame1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGame1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame1.ForeColor = System.Drawing.Color.Yellow;
            this.btnGame1.Location = new System.Drawing.Point(37, 480);
            this.btnGame1.Name = "btnGame1";
            this.btnGame1.Size = new System.Drawing.Size(189, 43);
            this.btnGame1.TabIndex = 2;
            this.btnGame1.Text = "Detective";
            this.btnGame1.UseVisualStyleBackColor = false;
            // 
            // btnGame2
            // 
            this.btnGame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGame2.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame2.ForeColor = System.Drawing.Color.Navy;
            this.btnGame2.Location = new System.Drawing.Point(272, 480);
            this.btnGame2.Name = "btnGame2";
            this.btnGame2.Size = new System.Drawing.Size(189, 43);
            this.btnGame2.TabIndex = 3;
            this.btnGame2.Text = "Frutivinanza";
            this.btnGame2.UseVisualStyleBackColor = false;
            // 
            // btnGame3
            // 
            this.btnGame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGame3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGame3.Location = new System.Drawing.Point(517, 480);
            this.btnGame3.Name = "btnGame3";
            this.btnGame3.Size = new System.Drawing.Size(189, 43);
            this.btnGame3.TabIndex = 4;
            this.btnGame3.Text = "AUN NO SE";
            this.btnGame3.UseVisualStyleBackColor = false;
            // 
            // btnGame4
            // 
            this.btnGame4.BackColor = System.Drawing.Color.Gold;
            this.btnGame4.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGame4.Location = new System.Drawing.Point(759, 480);
            this.btnGame4.Name = "btnGame4";
            this.btnGame4.Size = new System.Drawing.Size(189, 43);
            this.btnGame4.TabIndex = 5;
            this.btnGame4.Text = "Dungeon\'s";
            this.btnGame4.UseVisualStyleBackColor = false;
            // 
            // btnGame5
            // 
            this.btnGame5.BackColor = System.Drawing.Color.Coral;
            this.btnGame5.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame5.ForeColor = System.Drawing.Color.Purple;
            this.btnGame5.Location = new System.Drawing.Point(272, 638);
            this.btnGame5.Name = "btnGame5";
            this.btnGame5.Size = new System.Drawing.Size(189, 43);
            this.btnGame5.TabIndex = 6;
            this.btnGame5.Text = "POKENEOS";
            this.btnGame5.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(517, 638);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(189, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(991, 726);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGame5);
            this.Controls.Add(this.btnGame4);
            this.Controls.Add(this.btnGame3);
            this.Controls.Add(this.btnGame2);
            this.Controls.Add(this.btnGame1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Name = "GUI";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGame1;
        private System.Windows.Forms.Button btnGame2;
        private System.Windows.Forms.Button btnGame3;
        private System.Windows.Forms.Button btnGame4;
        private System.Windows.Forms.Button btnGame5;
        private System.Windows.Forms.Button btnSalir;
    }
}

