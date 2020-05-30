namespace MrRobot
{
    partial class FormCategory
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
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazwaKategorii = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKategorie = new System.Windows.Forms.DataGridView();
            this.textBoxSzukajKategorii = new System.Windows.Forms.TextBox();
            this.iconButtonEdytujKategorie = new FontAwesome.Sharp.IconButton();
            this.iconButtonUsunKategorie = new FontAwesome.Sharp.IconButton();
            this.iconButtonDodajKategorie = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonWroc = new FontAwesome.Sharp.IconButton();
            this.iconButtonSzukajKategorie = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpis.Location = new System.Drawing.Point(180, 217);
            this.textBoxOpis.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(216, 155);
            this.textBoxOpis.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label2.Location = new System.Drawing.Point(26, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Opis";
            // 
            // textBoxNazwaKategorii
            // 
            this.textBoxNazwaKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazwaKategorii.Location = new System.Drawing.Point(180, 180);
            this.textBoxNazwaKategorii.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazwaKategorii.Name = "textBoxNazwaKategorii";
            this.textBoxNazwaKategorii.Size = new System.Drawing.Size(216, 26);
            this.textBoxNazwaKategorii.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(26, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nazwa kategorii";
            // 
            // dataGridViewKategorie
            // 
            this.dataGridViewKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorie.Location = new System.Drawing.Point(423, 80);
            this.dataGridViewKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewKategorie.Name = "dataGridViewKategorie";
            this.dataGridViewKategorie.RowHeadersWidth = 51;
            this.dataGridViewKategorie.RowTemplate.Height = 24;
            this.dataGridViewKategorie.Size = new System.Drawing.Size(424, 504);
            this.dataGridViewKategorie.TabIndex = 25;
            this.dataGridViewKategorie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKategorie_CellClick);
            // 
            // textBoxSzukajKategorii
            // 
            this.textBoxSzukajKategorii.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSzukajKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxSzukajKategorii.Location = new System.Drawing.Point(423, 26);
            this.textBoxSzukajKategorii.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSzukajKategorii.Name = "textBoxSzukajKategorii";
            this.textBoxSzukajKategorii.Size = new System.Drawing.Size(297, 31);
            this.textBoxSzukajKategorii.TabIndex = 23;
            // 
            // iconButtonEdytujKategorie
            // 
            this.iconButtonEdytujKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonEdytujKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdytujKategorie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEdytujKategorie.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonEdytujKategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonEdytujKategorie.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdytujKategorie.IconColor = System.Drawing.Color.White;
            this.iconButtonEdytujKategorie.IconSize = 24;
            this.iconButtonEdytujKategorie.Location = new System.Drawing.Point(282, 392);
            this.iconButtonEdytujKategorie.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonEdytujKategorie.Name = "iconButtonEdytujKategorie";
            this.iconButtonEdytujKategorie.Rotation = 0D;
            this.iconButtonEdytujKategorie.Size = new System.Drawing.Size(114, 42);
            this.iconButtonEdytujKategorie.TabIndex = 84;
            this.iconButtonEdytujKategorie.Text = "Edytuj";
            this.iconButtonEdytujKategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdytujKategorie.UseVisualStyleBackColor = true;
            // 
            // iconButtonUsunKategorie
            // 
            this.iconButtonUsunKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonUsunKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsunKategorie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUsunKategorie.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonUsunKategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonUsunKategorie.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonUsunKategorie.IconColor = System.Drawing.Color.White;
            this.iconButtonUsunKategorie.IconSize = 24;
            this.iconButtonUsunKategorie.Location = new System.Drawing.Point(152, 392);
            this.iconButtonUsunKategorie.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonUsunKategorie.Name = "iconButtonUsunKategorie";
            this.iconButtonUsunKategorie.Rotation = 0D;
            this.iconButtonUsunKategorie.Size = new System.Drawing.Size(114, 42);
            this.iconButtonUsunKategorie.TabIndex = 83;
            this.iconButtonUsunKategorie.Text = "Usuń";
            this.iconButtonUsunKategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsunKategorie.UseVisualStyleBackColor = true;
            this.iconButtonUsunKategorie.Click += new System.EventHandler(this.iconButtonUsunKategorie_Click);
            // 
            // iconButtonDodajKategorie
            // 
            this.iconButtonDodajKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonDodajKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDodajKategorie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDodajKategorie.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonDodajKategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonDodajKategorie.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonDodajKategorie.IconColor = System.Drawing.Color.White;
            this.iconButtonDodajKategorie.IconSize = 24;
            this.iconButtonDodajKategorie.Location = new System.Drawing.Point(21, 392);
            this.iconButtonDodajKategorie.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonDodajKategorie.Name = "iconButtonDodajKategorie";
            this.iconButtonDodajKategorie.Rotation = 0D;
            this.iconButtonDodajKategorie.Size = new System.Drawing.Size(114, 42);
            this.iconButtonDodajKategorie.TabIndex = 82;
            this.iconButtonDodajKategorie.Text = "Dodaj";
            this.iconButtonDodajKategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDodajKategorie.UseVisualStyleBackColor = true;
            this.iconButtonDodajKategorie.Click += new System.EventHandler(this.iconButtonDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(107, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 33);
            this.label3.TabIndex = 85;
            this.label3.Text = "Dane kategorii";
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
            this.iconButtonWroc.TabIndex = 86;
            this.iconButtonWroc.Text = "Wróć";
            this.iconButtonWroc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonWroc.UseVisualStyleBackColor = true;
            // 
            // iconButtonSzukajKategorie
            // 
            this.iconButtonSzukajKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSzukajKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonSzukajKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSzukajKategorie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSzukajKategorie.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonSzukajKategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSzukajKategorie.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSzukajKategorie.IconColor = System.Drawing.Color.White;
            this.iconButtonSzukajKategorie.IconSize = 24;
            this.iconButtonSzukajKategorie.Location = new System.Drawing.Point(733, 20);
            this.iconButtonSzukajKategorie.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSzukajKategorie.Name = "iconButtonSzukajKategorie";
            this.iconButtonSzukajKategorie.Rotation = 0D;
            this.iconButtonSzukajKategorie.Size = new System.Drawing.Size(114, 42);
            this.iconButtonSzukajKategorie.TabIndex = 87;
            this.iconButtonSzukajKategorie.Text = "Szukaj";
            this.iconButtonSzukajKategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSzukajKategorie.UseVisualStyleBackColor = true;
            this.iconButtonSzukajKategorie.Click += new System.EventHandler(this.iconButtonSzukajKategorie_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.iconButtonSzukajKategorie);
            this.Controls.Add(this.iconButtonWroc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButtonEdytujKategorie);
            this.Controls.Add(this.iconButtonUsunKategorie);
            this.Controls.Add(this.iconButtonDodajKategorie);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazwaKategorii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKategorie);
            this.Controls.Add(this.textBoxSzukajKategorii);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazwaKategorii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKategorie;
        private System.Windows.Forms.TextBox textBoxSzukajKategorii;
        private FontAwesome.Sharp.IconButton iconButtonEdytujKategorie;
        private FontAwesome.Sharp.IconButton iconButtonUsunKategorie;
        private FontAwesome.Sharp.IconButton iconButtonDodajKategorie;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonWroc;
        private FontAwesome.Sharp.IconButton iconButtonSzukajKategorie;
    }
}