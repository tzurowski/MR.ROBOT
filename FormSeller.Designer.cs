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
            this.textBoxSzukajProduktu = new System.Windows.Forms.TextBox();
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
            this.iconButtonEdytujProdukt = new FontAwesome.Sharp.IconButton();
            this.iconButtonUsunProdukt = new FontAwesome.Sharp.IconButton();
            this.iconButtonDodajProdukt = new FontAwesome.Sharp.IconButton();
            this.iconButtonSzukajProdukt = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.iconButtonWroc = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSzukajProduktu
            // 
            this.textBoxSzukajProduktu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSzukajProduktu.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.textBoxSzukajProduktu.Location = new System.Drawing.Point(425, 33);
            this.textBoxSzukajProduktu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSzukajProduktu.Name = "textBoxSzukajProduktu";
            this.textBoxSzukajProduktu.Size = new System.Drawing.Size(298, 34);
            this.textBoxSzukajProduktu.TabIndex = 3;
            // 
            // dataGridViewProdukty
            // 
            this.dataGridViewProdukty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdukty.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdukty.Location = new System.Drawing.Point(425, 93);
            this.dataGridViewProdukty.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProdukty.Name = "dataGridViewProdukty";
            this.dataGridViewProdukty.RowHeadersWidth = 51;
            this.dataGridViewProdukty.RowTemplate.Height = 24;
            this.dataGridViewProdukty.Size = new System.Drawing.Size(424, 487);
            this.dataGridViewProdukty.TabIndex = 5;
            this.dataGridViewProdukty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdukty_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(21, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa produktu";
            // 
            // textBoxNazwaProduktu
            // 
            this.textBoxNazwaProduktu.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxNazwaProduktu.Location = new System.Drawing.Point(172, 143);
            this.textBoxNazwaProduktu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazwaProduktu.Name = "textBoxNazwaProduktu";
            this.textBoxNazwaProduktu.Size = new System.Drawing.Size(224, 27);
            this.textBoxNazwaProduktu.TabIndex = 7;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxOpis.Location = new System.Drawing.Point(172, 177);
            this.textBoxOpis.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(224, 124);
            this.textBoxOpis.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label2.Location = new System.Drawing.Point(21, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis";
            // 
            // textBoxPlatforma
            // 
            this.textBoxPlatforma.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxPlatforma.Location = new System.Drawing.Point(172, 308);
            this.textBoxPlatforma.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlatforma.Name = "textBoxPlatforma";
            this.textBoxPlatforma.Size = new System.Drawing.Size(224, 27);
            this.textBoxPlatforma.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label3.Location = new System.Drawing.Point(21, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Platforma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label4.Location = new System.Drawing.Point(21, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategoria";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxCena.Location = new System.Drawing.Point(172, 376);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(224, 27);
            this.textBoxCena.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label5.Location = new System.Drawing.Point(21, 376);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label6.Location = new System.Drawing.Point(21, 410);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zdjęcie";
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(172, 342);
            this.comboBoxKategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(176, 27);
            this.comboBoxKategoria.TabIndex = 18;
            // 
            // buttonEdytujKategorie
            // 
            this.buttonEdytujKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.buttonEdytujKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdytujKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdytujKategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEdytujKategorie.Location = new System.Drawing.Point(355, 342);
            this.buttonEdytujKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdytujKategorie.Name = "buttonEdytujKategorie";
            this.buttonEdytujKategorie.Size = new System.Drawing.Size(41, 27);
            this.buttonEdytujKategorie.TabIndex = 19;
            this.buttonEdytujKategorie.Text = "+/-";
            this.buttonEdytujKategorie.UseVisualStyleBackColor = false;
            this.buttonEdytujKategorie.Click += new System.EventHandler(this.buttonEdytujKategorie_Click);
            // 
            // comboBoxObrazki
            // 
            this.comboBoxObrazki.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.comboBoxObrazki.FormattingEnabled = true;
            this.comboBoxObrazki.Location = new System.Drawing.Point(172, 410);
            this.comboBoxObrazki.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxObrazki.Name = "comboBoxObrazki";
            this.comboBoxObrazki.Size = new System.Drawing.Size(224, 27);
            this.comboBoxObrazki.TabIndex = 20;
            // 
            // buttonZamowieniaDoRealizacji
            // 
            this.buttonZamowieniaDoRealizacji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.buttonZamowieniaDoRealizacji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZamowieniaDoRealizacji.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonZamowieniaDoRealizacji.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonZamowieniaDoRealizacji.Location = new System.Drawing.Point(25, 538);
            this.buttonZamowieniaDoRealizacji.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZamowieniaDoRealizacji.Name = "buttonZamowieniaDoRealizacji";
            this.buttonZamowieniaDoRealizacji.Size = new System.Drawing.Size(375, 42);
            this.buttonZamowieniaDoRealizacji.TabIndex = 21;
            this.buttonZamowieniaDoRealizacji.Text = "Przejrzyj zamowienia do realizacji";
            this.buttonZamowieniaDoRealizacji.UseVisualStyleBackColor = false;
            // 
            // iconButtonEdytujProdukt
            // 
            this.iconButtonEdytujProdukt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonEdytujProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdytujProdukt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEdytujProdukt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonEdytujProdukt.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonEdytujProdukt.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdytujProdukt.IconColor = System.Drawing.Color.White;
            this.iconButtonEdytujProdukt.IconSize = 24;
            this.iconButtonEdytujProdukt.Location = new System.Drawing.Point(286, 471);
            this.iconButtonEdytujProdukt.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonEdytujProdukt.Name = "iconButtonEdytujProdukt";
            this.iconButtonEdytujProdukt.Rotation = 0D;
            this.iconButtonEdytujProdukt.Size = new System.Drawing.Size(114, 42);
            this.iconButtonEdytujProdukt.TabIndex = 87;
            this.iconButtonEdytujProdukt.Text = "Edytuj";
            this.iconButtonEdytujProdukt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdytujProdukt.UseVisualStyleBackColor = true;
            this.iconButtonEdytujProdukt.Click += new System.EventHandler(this.iconButtonEdytujProdukt_Click);
            // 
            // iconButtonUsunProdukt
            // 
            this.iconButtonUsunProdukt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonUsunProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsunProdukt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUsunProdukt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonUsunProdukt.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonUsunProdukt.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonUsunProdukt.IconColor = System.Drawing.Color.White;
            this.iconButtonUsunProdukt.IconSize = 24;
            this.iconButtonUsunProdukt.Location = new System.Drawing.Point(156, 471);
            this.iconButtonUsunProdukt.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonUsunProdukt.Name = "iconButtonUsunProdukt";
            this.iconButtonUsunProdukt.Rotation = 0D;
            this.iconButtonUsunProdukt.Size = new System.Drawing.Size(114, 42);
            this.iconButtonUsunProdukt.TabIndex = 86;
            this.iconButtonUsunProdukt.Text = "Usuń";
            this.iconButtonUsunProdukt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsunProdukt.UseVisualStyleBackColor = true;
            this.iconButtonUsunProdukt.Click += new System.EventHandler(this.iconButtonUsunProdukt_Click);
            // 
            // iconButtonDodajProdukt
            // 
            this.iconButtonDodajProdukt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonDodajProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDodajProdukt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDodajProdukt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonDodajProdukt.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonDodajProdukt.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonDodajProdukt.IconColor = System.Drawing.Color.White;
            this.iconButtonDodajProdukt.IconSize = 24;
            this.iconButtonDodajProdukt.Location = new System.Drawing.Point(25, 471);
            this.iconButtonDodajProdukt.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonDodajProdukt.Name = "iconButtonDodajProdukt";
            this.iconButtonDodajProdukt.Rotation = 0D;
            this.iconButtonDodajProdukt.Size = new System.Drawing.Size(114, 42);
            this.iconButtonDodajProdukt.TabIndex = 85;
            this.iconButtonDodajProdukt.Text = "Dodaj";
            this.iconButtonDodajProdukt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDodajProdukt.UseVisualStyleBackColor = true;
            this.iconButtonDodajProdukt.Click += new System.EventHandler(this.iconButtonDodajProdukt_Click);
            // 
            // iconButtonSzukajProdukt
            // 
            this.iconButtonSzukajProdukt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSzukajProdukt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonSzukajProdukt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSzukajProdukt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSzukajProdukt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonSzukajProdukt.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSzukajProdukt.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSzukajProdukt.IconColor = System.Drawing.Color.White;
            this.iconButtonSzukajProdukt.IconSize = 24;
            this.iconButtonSzukajProdukt.Location = new System.Drawing.Point(735, 29);
            this.iconButtonSzukajProdukt.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSzukajProdukt.Name = "iconButtonSzukajProdukt";
            this.iconButtonSzukajProdukt.Rotation = 0D;
            this.iconButtonSzukajProdukt.Size = new System.Drawing.Size(114, 42);
            this.iconButtonSzukajProdukt.TabIndex = 88;
            this.iconButtonSzukajProdukt.Text = "Szukaj";
            this.iconButtonSzukajProdukt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSzukajProdukt.UseVisualStyleBackColor = true;
            this.iconButtonSzukajProdukt.Click += new System.EventHandler(this.iconButtonSzukajProdukt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(120, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 33);
            this.label7.TabIndex = 89;
            this.label7.Text = "Dane produktu";
            // 
            // iconButtonWroc
            // 
            this.iconButtonWroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonWroc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonWroc.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonWroc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonWroc.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonWroc.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButtonWroc.IconColor = System.Drawing.Color.White;
            this.iconButtonWroc.IconSize = 24;
            this.iconButtonWroc.Location = new System.Drawing.Point(20, 20);
            this.iconButtonWroc.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonWroc.Name = "iconButtonWroc";
            this.iconButtonWroc.Rotation = 0D;
            this.iconButtonWroc.Size = new System.Drawing.Size(100, 42);
            this.iconButtonWroc.TabIndex = 90;
            this.iconButtonWroc.Text = "Wróć";
            this.iconButtonWroc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonWroc.UseVisualStyleBackColor = true;
            this.iconButtonWroc.Click += new System.EventHandler(this.iconButtonWroc_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.iconButtonWroc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButtonSzukajProdukt);
            this.Controls.Add(this.iconButtonEdytujProdukt);
            this.Controls.Add(this.iconButtonUsunProdukt);
            this.Controls.Add(this.iconButtonDodajProdukt);
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
            this.Controls.Add(this.textBoxSzukajProduktu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSeller";
            this.Text = "FormSeller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSzukajProduktu;
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
        private FontAwesome.Sharp.IconButton iconButtonEdytujProdukt;
        private FontAwesome.Sharp.IconButton iconButtonUsunProdukt;
        private FontAwesome.Sharp.IconButton iconButtonDodajProdukt;
        private FontAwesome.Sharp.IconButton iconButtonSzukajProdukt;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButtonWroc;
    }
}