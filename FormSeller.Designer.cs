namespace MrRobot
{
    partial class FormSeller
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
            this.buttonDodajProdukt = new System.Windows.Forms.Button();
            this.buttonUsunProdukt = new System.Windows.Forms.Button();
            this.buttonEdytujProdukt = new System.Windows.Forms.Button();
            this.textBoxSzukajProduktu = new System.Windows.Forms.TextBox();
            this.buttonSzukajProduktu = new System.Windows.Forms.Button();
            this.dataGridViewProdukty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwaProduktu = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlatforma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.buttonEdytujKategorie = new System.Windows.Forms.Button();
            this.comboBoxObrazki = new System.Windows.Forms.ComboBox();
            this.buttonZamowieniaDoRealizacji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodajProdukt
            // 
            this.buttonDodajProdukt.Location = new System.Drawing.Point(92, 473);
            this.buttonDodajProdukt.Name = "buttonDodajProdukt";
            this.buttonDodajProdukt.Size = new System.Drawing.Size(146, 53);
            this.buttonDodajProdukt.TabIndex = 0;
            this.buttonDodajProdukt.Text = "Dodaj";
            this.buttonDodajProdukt.UseVisualStyleBackColor = true;
            this.buttonDodajProdukt.Click += new System.EventHandler(this.buttonDodajProdukt_Click);
            // 
            // buttonUsunProdukt
            // 
            this.buttonUsunProdukt.Location = new System.Drawing.Point(244, 473);
            this.buttonUsunProdukt.Name = "buttonUsunProdukt";
            this.buttonUsunProdukt.Size = new System.Drawing.Size(146, 53);
            this.buttonUsunProdukt.TabIndex = 1;
            this.buttonUsunProdukt.Text = "Usun";
            this.buttonUsunProdukt.UseVisualStyleBackColor = true;
            this.buttonUsunProdukt.Click += new System.EventHandler(this.buttonUsunProdukt_Click);
            // 
            // buttonEdytujProdukt
            // 
            this.buttonEdytujProdukt.Location = new System.Drawing.Point(396, 473);
            this.buttonEdytujProdukt.Name = "buttonEdytujProdukt";
            this.buttonEdytujProdukt.Size = new System.Drawing.Size(146, 53);
            this.buttonEdytujProdukt.TabIndex = 2;
            this.buttonEdytujProdukt.Text = "Edytuj";
            this.buttonEdytujProdukt.UseVisualStyleBackColor = true;
            this.buttonEdytujProdukt.Click += new System.EventHandler(this.buttonEdytujProdukt_Click);
            // 
            // textBoxSzukajProduktu
            // 
            this.textBoxSzukajProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSzukajProduktu.Location = new System.Drawing.Point(570, 76);
            this.textBoxSzukajProduktu.Name = "textBoxSzukajProduktu";
            this.textBoxSzukajProduktu.Size = new System.Drawing.Size(396, 30);
            this.textBoxSzukajProduktu.TabIndex = 3;
            // 
            // buttonSzukajProduktu
            // 
            this.buttonSzukajProduktu.Location = new System.Drawing.Point(972, 75);
            this.buttonSzukajProduktu.Name = "buttonSzukajProduktu";
            this.buttonSzukajProduktu.Size = new System.Drawing.Size(103, 38);
            this.buttonSzukajProduktu.TabIndex = 4;
            this.buttonSzukajProduktu.Text = "Szukaj";
            this.buttonSzukajProduktu.UseVisualStyleBackColor = true;
            this.buttonSzukajProduktu.Click += new System.EventHandler(this.buttonSzukajProdukt_Click);
            // 
            // dataGridViewProdukty
            // 
            this.dataGridViewProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdukty.Location = new System.Drawing.Point(556, 132);
            this.dataGridViewProdukty.Name = "dataGridViewProdukty";
            this.dataGridViewProdukty.RowHeadersWidth = 51;
            this.dataGridViewProdukty.RowTemplate.Height = 24;
            this.dataGridViewProdukty.Size = new System.Drawing.Size(546, 424);
            this.dataGridViewProdukty.TabIndex = 5;
            this.dataGridViewProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdukty_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa produktu";
            // 
            // textBoxNazwaProduktu
            // 
            this.textBoxNazwaProduktu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazwaProduktu.Location = new System.Drawing.Point(186, 131);
            this.textBoxNazwaProduktu.Name = "textBoxNazwaProduktu";
            this.textBoxNazwaProduktu.Size = new System.Drawing.Size(326, 30);
            this.textBoxNazwaProduktu.TabIndex = 7;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpis.Location = new System.Drawing.Point(186, 167);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(326, 120);
            this.textBoxOpis.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis";
            // 
            // textBoxPlatforma
            // 
            this.textBoxPlatforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlatforma.Location = new System.Drawing.Point(186, 293);
            this.textBoxPlatforma.Name = "textBoxPlatforma";
            this.textBoxPlatforma.Size = new System.Drawing.Size(326, 30);
            this.textBoxPlatforma.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Platforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategoria";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCena.Location = new System.Drawing.Point(186, 369);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(326, 30);
            this.textBoxCena.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zdjęcie";
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(186, 329);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(275, 33);
            this.comboBoxKategoria.TabIndex = 18;
            // 
            // buttonEdytujKategorie
            // 
            this.buttonEdytujKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdytujKategorie.Location = new System.Drawing.Point(467, 329);
            this.buttonEdytujKategorie.Name = "buttonEdytujKategorie";
            this.buttonEdytujKategorie.Size = new System.Drawing.Size(45, 33);
            this.buttonEdytujKategorie.TabIndex = 19;
            this.buttonEdytujKategorie.Text = "+/-";
            this.buttonEdytujKategorie.UseVisualStyleBackColor = true;
            this.buttonEdytujKategorie.Click += new System.EventHandler(this.buttonEdytujKategorie_Click);
            // 
            // comboBoxObrazki
            // 
            this.comboBoxObrazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxObrazki.FormattingEnabled = true;
            this.comboBoxObrazki.Location = new System.Drawing.Point(186, 408);
            this.comboBoxObrazki.Name = "comboBoxObrazki";
            this.comboBoxObrazki.Size = new System.Drawing.Size(326, 33);
            this.comboBoxObrazki.TabIndex = 20;
            // 
            // buttonZamowieniaDoRealizacji
            // 
            this.buttonZamowieniaDoRealizacji.Location = new System.Drawing.Point(12, 12);
            this.buttonZamowieniaDoRealizacji.Name = "buttonZamowieniaDoRealizacji";
            this.buttonZamowieniaDoRealizacji.Size = new System.Drawing.Size(394, 33);
            this.buttonZamowieniaDoRealizacji.TabIndex = 21;
            this.buttonZamowieniaDoRealizacji.Text = "Przejrzyj zamowienia gotowe do realizacji";
            this.buttonZamowieniaDoRealizacji.UseVisualStyleBackColor = true;
            this.buttonZamowieniaDoRealizacji.Click += new System.EventHandler(this.buttonZamowieniaDoRealizacji_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 706);
            this.Controls.Add(this.buttonZamowieniaDoRealizacji);
            this.Controls.Add(this.comboBoxObrazki);
            this.Controls.Add(this.buttonEdytujKategorie);
            this.Controls.Add(this.comboBoxKategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlatforma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazwaProduktu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProdukty);
            this.Controls.Add(this.buttonSzukajProduktu);
            this.Controls.Add(this.textBoxSzukajProduktu);
            this.Controls.Add(this.buttonEdytujProdukt);
            this.Controls.Add(this.buttonUsunProdukt);
            this.Controls.Add(this.buttonDodajProdukt);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodajProdukt;
        private System.Windows.Forms.Button buttonUsunProdukt;
        private System.Windows.Forms.Button buttonEdytujProdukt;
        private System.Windows.Forms.TextBox textBoxSzukajProduktu;
        private System.Windows.Forms.Button buttonSzukajProduktu;
        private System.Windows.Forms.DataGridView dataGridViewProdukty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNazwaProduktu;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlatforma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.Button buttonEdytujKategorie;
        private System.Windows.Forms.ComboBox comboBoxObrazki;
        private System.Windows.Forms.Button buttonZamowieniaDoRealizacji;
    }
}