namespace MrRobot
{
    partial class FormAdmin
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
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxKod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPotwierdzHaslo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNazwaUzytkownika = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMiejscowosc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxCzyAdmin = new System.Windows.Forms.ComboBox();
            this.comboBoxCzySprzedawca = new System.Windows.Forms.ComboBox();
            this.dataGridViewUzytkownicy = new System.Windows.Forms.DataGridView();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.iconButtonDodaj = new FontAwesome.Sharp.IconButton();
            this.iconButtonUsun = new FontAwesome.Sharp.IconButton();
            this.iconButtonEdytuj = new FontAwesome.Sharp.IconButton();
            this.iconButtonWroc = new FontAwesome.Sharp.IconButton();
            this.iconButtonSzukaj = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxMail.Location = new System.Drawing.Point(207, 412);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(192, 27);
            this.textBoxMail.TabIndex = 70;
            // 
            // textBoxKod
            // 
            this.textBoxKod.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxKod.Location = new System.Drawing.Point(207, 242);
            this.textBoxKod.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKod.Name = "textBoxKod";
            this.textBoxKod.Size = new System.Drawing.Size(192, 27);
            this.textBoxKod.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(20, 242);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "Kod pocztowy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(20, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "Adres email";
            // 
            // textBoxPotwierdzHaslo
            // 
            this.textBoxPotwierdzHaslo.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxPotwierdzHaslo.Location = new System.Drawing.Point(207, 378);
            this.textBoxPotwierdzHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPotwierdzHaslo.Name = "textBoxPotwierdzHaslo";
            this.textBoxPotwierdzHaslo.Size = new System.Drawing.Size(192, 27);
            this.textBoxPotwierdzHaslo.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(20, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Potwierdź hasło";
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxHaslo.Location = new System.Drawing.Point(207, 344);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(192, 27);
            this.textBoxHaslo.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(20, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 61;
            this.label7.Text = "Hasło";
            // 
            // textBoxNazwaUzytkownika
            // 
            this.textBoxNazwaUzytkownika.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxNazwaUzytkownika.Location = new System.Drawing.Point(207, 310);
            this.textBoxNazwaUzytkownika.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazwaUzytkownika.Name = "textBoxNazwaUzytkownika";
            this.textBoxNazwaUzytkownika.Size = new System.Drawing.Size(192, 27);
            this.textBoxNazwaUzytkownika.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(20, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Nazwa użytkownika";
            // 
            // textBoxMiejscowosc
            // 
            this.textBoxMiejscowosc.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxMiejscowosc.Location = new System.Drawing.Point(207, 276);
            this.textBoxMiejscowosc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMiejscowosc.Name = "textBoxMiejscowosc";
            this.textBoxMiejscowosc.Size = new System.Drawing.Size(192, 27);
            this.textBoxMiejscowosc.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Miejscowosc";
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxUlica.Location = new System.Drawing.Point(207, 208);
            this.textBoxUlica.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(192, 27);
            this.textBoxUlica.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Ulica";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxNazwisko.Location = new System.Drawing.Point(207, 174);
            this.textBoxNazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(192, 27);
            this.textBoxNazwisko.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(20, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Imie";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.textBoxImie.Location = new System.Drawing.Point(207, 140);
            this.textBoxImie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(192, 27);
            this.textBoxImie.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Dane użytkownika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(20, 446);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 71;
            this.label10.Text = "Czy admin?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(20, 480);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 23);
            this.label12.TabIndex = 72;
            this.label12.Text = "Czy sprzedawca?";
            // 
            // comboBoxCzyAdmin
            // 
            this.comboBoxCzyAdmin.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.comboBoxCzyAdmin.FormattingEnabled = true;
            this.comboBoxCzyAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxCzyAdmin.Location = new System.Drawing.Point(207, 446);
            this.comboBoxCzyAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCzyAdmin.Name = "comboBoxCzyAdmin";
            this.comboBoxCzyAdmin.Size = new System.Drawing.Size(192, 27);
            this.comboBoxCzyAdmin.TabIndex = 73;
            // 
            // comboBoxCzySprzedawca
            // 
            this.comboBoxCzySprzedawca.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.comboBoxCzySprzedawca.FormattingEnabled = true;
            this.comboBoxCzySprzedawca.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxCzySprzedawca.Location = new System.Drawing.Point(207, 480);
            this.comboBoxCzySprzedawca.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCzySprzedawca.Name = "comboBoxCzySprzedawca";
            this.comboBoxCzySprzedawca.Size = new System.Drawing.Size(192, 27);
            this.comboBoxCzySprzedawca.TabIndex = 74;
            // 
            // dataGridViewUzytkownicy
            // 
            this.dataGridViewUzytkownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUzytkownicy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUzytkownicy.Location = new System.Drawing.Point(425, 93);
            this.dataGridViewUzytkownicy.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUzytkownicy.Name = "dataGridViewUzytkownicy";
            this.dataGridViewUzytkownicy.RowHeadersWidth = 51;
            this.dataGridViewUzytkownicy.RowTemplate.Height = 24;
            this.dataGridViewUzytkownicy.Size = new System.Drawing.Size(417, 488);
            this.dataGridViewUzytkownicy.TabIndex = 77;
            this.dataGridViewUzytkownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUzytkownicy_CellContentClick);
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSzukaj.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.textBoxSzukaj.Location = new System.Drawing.Point(425, 33);
            this.textBoxSzukaj.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(289, 34);
            this.textBoxSzukaj.TabIndex = 78;
            // 
            // iconButtonDodaj
            // 
            this.iconButtonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDodaj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDodaj.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonDodaj.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonDodaj.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonDodaj.IconColor = System.Drawing.Color.White;
            this.iconButtonDodaj.IconSize = 24;
            this.iconButtonDodaj.Location = new System.Drawing.Point(24, 539);
            this.iconButtonDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonDodaj.Name = "iconButtonDodaj";
            this.iconButtonDodaj.Rotation = 0D;
            this.iconButtonDodaj.Size = new System.Drawing.Size(114, 42);
            this.iconButtonDodaj.TabIndex = 5;
            this.iconButtonDodaj.Text = "Dodaj";
            this.iconButtonDodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDodaj.UseVisualStyleBackColor = true;
            this.iconButtonDodaj.Click += new System.EventHandler(this.iconButtonDodaj_Click);
            // 
            // iconButtonUsun
            // 
            this.iconButtonUsun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonUsun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsun.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUsun.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonUsun.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonUsun.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonUsun.IconColor = System.Drawing.Color.White;
            this.iconButtonUsun.IconSize = 24;
            this.iconButtonUsun.Location = new System.Drawing.Point(155, 539);
            this.iconButtonUsun.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonUsun.Name = "iconButtonUsun";
            this.iconButtonUsun.Rotation = 0D;
            this.iconButtonUsun.Size = new System.Drawing.Size(114, 42);
            this.iconButtonUsun.TabIndex = 80;
            this.iconButtonUsun.Text = "Usuń";
            this.iconButtonUsun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsun.UseVisualStyleBackColor = true;
            this.iconButtonUsun.Click += new System.EventHandler(this.iconButtonUsun_Click);
            // 
            // iconButtonEdytuj
            // 
            this.iconButtonEdytuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonEdytuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdytuj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEdytuj.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonEdytuj.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonEdytuj.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdytuj.IconColor = System.Drawing.Color.White;
            this.iconButtonEdytuj.IconSize = 24;
            this.iconButtonEdytuj.Location = new System.Drawing.Point(285, 539);
            this.iconButtonEdytuj.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonEdytuj.Name = "iconButtonEdytuj";
            this.iconButtonEdytuj.Rotation = 0D;
            this.iconButtonEdytuj.Size = new System.Drawing.Size(114, 42);
            this.iconButtonEdytuj.TabIndex = 81;
            this.iconButtonEdytuj.Text = "Edytuj";
            this.iconButtonEdytuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdytuj.UseVisualStyleBackColor = true;
            this.iconButtonEdytuj.Click += new System.EventHandler(this.iconButtonEdytuj_Click);
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
            this.iconButtonWroc.TabIndex = 82;
            this.iconButtonWroc.Text = "Wróć";
            this.iconButtonWroc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonWroc.UseVisualStyleBackColor = true;
            this.iconButtonWroc.Click += new System.EventHandler(this.iconButtonWroc_Click);
            // 
            // iconButtonSzukaj
            // 
            this.iconButtonSzukaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonSzukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSzukaj.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSzukaj.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonSzukaj.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSzukaj.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSzukaj.IconColor = System.Drawing.Color.White;
            this.iconButtonSzukaj.IconSize = 24;
            this.iconButtonSzukaj.Location = new System.Drawing.Point(728, 29);
            this.iconButtonSzukaj.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSzukaj.Name = "iconButtonSzukaj";
            this.iconButtonSzukaj.Rotation = 0D;
            this.iconButtonSzukaj.Size = new System.Drawing.Size(114, 42);
            this.iconButtonSzukaj.TabIndex = 83;
            this.iconButtonSzukaj.Text = "Szukaj";
            this.iconButtonSzukaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSzukaj.UseVisualStyleBackColor = true;
            this.iconButtonSzukaj.Click += new System.EventHandler(this.iconButtonSzukaj_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.iconButtonSzukaj);
            this.Controls.Add(this.iconButtonWroc);
            this.Controls.Add(this.iconButtonEdytuj);
            this.Controls.Add(this.iconButtonUsun);
            this.Controls.Add(this.iconButtonDodaj);
            this.Controls.Add(this.textBoxSzukaj);
            this.Controls.Add(this.dataGridViewUzytkownicy);
            this.Controls.Add(this.comboBoxCzySprzedawca);
            this.Controls.Add(this.comboBoxCzyAdmin);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxKod);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPotwierdzHaslo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNazwaUzytkownika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMiejscowosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxKod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPotwierdzHaslo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNazwaUzytkownika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMiejscowosc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxCzyAdmin;
        private System.Windows.Forms.ComboBox comboBoxCzySprzedawca;
        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private FontAwesome.Sharp.IconButton iconButtonDodaj;
        private FontAwesome.Sharp.IconButton iconButtonUsun;
        private FontAwesome.Sharp.IconButton iconButtonEdytuj;
        private FontAwesome.Sharp.IconButton iconButtonWroc;
        private FontAwesome.Sharp.IconButton iconButtonSzukaj;
    }
}