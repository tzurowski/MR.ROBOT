namespace MrRobot
{
    partial class FormProduct
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
            this.pictureBoxObrazek = new System.Windows.Forms.PictureBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.textBoxPlatforma = new System.Windows.Forms.TextBox();
            this.textBoxKategoria = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.buttonDodajDoKoszyka = new System.Windows.Forms.Button();
            this.buttonWroc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxObrazek
            // 
            this.pictureBoxObrazek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxObrazek.Location = new System.Drawing.Point(34, 56);
            this.pictureBoxObrazek.Name = "pictureBoxObrazek";
            this.pictureBoxObrazek.Size = new System.Drawing.Size(379, 404);
            this.pictureBoxObrazek.TabIndex = 0;
            this.pictureBoxObrazek.TabStop = false;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Enabled = false;
            this.textBoxNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazwa.Location = new System.Drawing.Point(433, 56);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(324, 38);
            this.textBoxNazwa.TabIndex = 1;
            this.textBoxNazwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPlatforma
            // 
            this.textBoxPlatforma.Enabled = false;
            this.textBoxPlatforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlatforma.Location = new System.Drawing.Point(433, 100);
            this.textBoxPlatforma.Name = "textBoxPlatforma";
            this.textBoxPlatforma.Size = new System.Drawing.Size(323, 38);
            this.textBoxPlatforma.TabIndex = 2;
            this.textBoxPlatforma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKategoria
            // 
            this.textBoxKategoria.Enabled = false;
            this.textBoxKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKategoria.Location = new System.Drawing.Point(433, 144);
            this.textBoxKategoria.Name = "textBoxKategoria";
            this.textBoxKategoria.Size = new System.Drawing.Size(323, 38);
            this.textBoxKategoria.TabIndex = 3;
            this.textBoxKategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Enabled = false;
            this.textBoxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCena.Location = new System.Drawing.Point(433, 188);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(323, 38);
            this.textBoxCena.TabIndex = 4;
            this.textBoxCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Enabled = false;
            this.textBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpis.Location = new System.Drawing.Point(433, 232);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(555, 228);
            this.textBoxOpis.TabIndex = 5;
            this.textBoxOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDodajDoKoszyka
            // 
            this.buttonDodajDoKoszyka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajDoKoszyka.Location = new System.Drawing.Point(794, 63);
            this.buttonDodajDoKoszyka.Name = "buttonDodajDoKoszyka";
            this.buttonDodajDoKoszyka.Size = new System.Drawing.Size(194, 81);
            this.buttonDodajDoKoszyka.TabIndex = 6;
            this.buttonDodajDoKoszyka.Text = "Dodaj Do Koszyka";
            this.buttonDodajDoKoszyka.UseVisualStyleBackColor = true;
            // 
            // buttonWroc
            // 
            this.buttonWroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWroc.Location = new System.Drawing.Point(794, 158);
            this.buttonWroc.Name = "buttonWroc";
            this.buttonWroc.Size = new System.Drawing.Size(194, 68);
            this.buttonWroc.TabIndex = 7;
            this.buttonWroc.Text = "Wróć";
            this.buttonWroc.UseVisualStyleBackColor = true;
            this.buttonWroc.Click += new System.EventHandler(this.buttonWroc_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 541);
            this.Controls.Add(this.buttonWroc);
            this.Controls.Add(this.buttonDodajDoKoszyka);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxKategoria);
            this.Controls.Add(this.textBoxPlatforma);
            this.Controls.Add(this.textBoxNazwa);
            this.Controls.Add(this.pictureBoxObrazek);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxObrazek;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.TextBox textBoxPlatforma;
        private System.Windows.Forms.TextBox textBoxKategoria;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Button buttonDodajDoKoszyka;
        private System.Windows.Forms.Button buttonWroc;
    }
}