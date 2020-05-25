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
            this.buttonSzukajKategorii = new System.Windows.Forms.Button();
            this.textBoxSzukajKategorii = new System.Windows.Forms.TextBox();
            this.buttonEdytujKategorie = new System.Windows.Forms.Button();
            this.buttonUsunKategorie = new System.Windows.Forms.Button();
            this.buttonDodajKategorie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOpis.Location = new System.Drawing.Point(194, 178);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(326, 126);
            this.textBoxOpis.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Opis";
            // 
            // textBoxNazwaKategorii
            // 
            this.textBoxNazwaKategorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNazwaKategorii.Location = new System.Drawing.Point(194, 142);
            this.textBoxNazwaKategorii.Name = "textBoxNazwaKategorii";
            this.textBoxNazwaKategorii.Size = new System.Drawing.Size(326, 30);
            this.textBoxNazwaKategorii.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nazwa kategorii";
            // 
            // dataGridViewKategorie
            // 
            this.dataGridViewKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorie.Location = new System.Drawing.Point(564, 143);
            this.dataGridViewKategorie.Name = "dataGridViewKategorie";
            this.dataGridViewKategorie.RowHeadersWidth = 51;
            this.dataGridViewKategorie.RowTemplate.Height = 24;
            this.dataGridViewKategorie.Size = new System.Drawing.Size(505, 289);
            this.dataGridViewKategorie.TabIndex = 25;
            // 
            // buttonSzukajKategorii
            // 
            this.buttonSzukajKategorii.Location = new System.Drawing.Point(913, 79);
            this.buttonSzukajKategorii.Name = "buttonSzukajKategorii";
            this.buttonSzukajKategorii.Size = new System.Drawing.Size(103, 38);
            this.buttonSzukajKategorii.TabIndex = 24;
            this.buttonSzukajKategorii.Text = "Szukaj";
            this.buttonSzukajKategorii.UseVisualStyleBackColor = true;
            this.buttonSzukajKategorii.Click += new System.EventHandler(this.buttonSzukajKategorii_Click);
            // 
            // textBoxSzukajKategorii
            // 
            this.textBoxSzukajKategorii.Location = new System.Drawing.Point(578, 87);
            this.textBoxSzukajKategorii.Name = "textBoxSzukajKategorii";
            this.textBoxSzukajKategorii.Size = new System.Drawing.Size(317, 22);
            this.textBoxSzukajKategorii.TabIndex = 23;
            // 
            // buttonEdytujKategorie
            // 
            this.buttonEdytujKategorie.Location = new System.Drawing.Point(357, 324);
            this.buttonEdytujKategorie.Name = "buttonEdytujKategorie";
            this.buttonEdytujKategorie.Size = new System.Drawing.Size(146, 53);
            this.buttonEdytujKategorie.TabIndex = 22;
            this.buttonEdytujKategorie.Text = "Edytuj";
            this.buttonEdytujKategorie.UseVisualStyleBackColor = true;
            // 
            // buttonUsunKategorie
            // 
            this.buttonUsunKategorie.Location = new System.Drawing.Point(205, 324);
            this.buttonUsunKategorie.Name = "buttonUsunKategorie";
            this.buttonUsunKategorie.Size = new System.Drawing.Size(146, 53);
            this.buttonUsunKategorie.TabIndex = 21;
            this.buttonUsunKategorie.Text = "Usun";
            this.buttonUsunKategorie.UseVisualStyleBackColor = true;
            this.buttonUsunKategorie.Click += new System.EventHandler(this.buttonUsunKategorie_Click);
            // 
            // buttonDodajKategorie
            // 
            this.buttonDodajKategorie.Location = new System.Drawing.Point(53, 324);
            this.buttonDodajKategorie.Name = "buttonDodajKategorie";
            this.buttonDodajKategorie.Size = new System.Drawing.Size(146, 53);
            this.buttonDodajKategorie.TabIndex = 20;
            this.buttonDodajKategorie.Text = "Dodaj";
            this.buttonDodajKategorie.UseVisualStyleBackColor = true;
            this.buttonDodajKategorie.Click += new System.EventHandler(this.buttonDodajKategorie_Click);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 653);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNazwaKategorii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKategorie);
            this.Controls.Add(this.buttonSzukajKategorii);
            this.Controls.Add(this.textBoxSzukajKategorii);
            this.Controls.Add(this.buttonEdytujKategorie);
            this.Controls.Add(this.buttonUsunKategorie);
            this.Controls.Add(this.buttonDodajKategorie);
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
        private System.Windows.Forms.Button buttonSzukajKategorii;
        private System.Windows.Forms.TextBox textBoxSzukajKategorii;
        private System.Windows.Forms.Button buttonEdytujKategorie;
        private System.Windows.Forms.Button buttonUsunKategorie;
        private System.Windows.Forms.Button buttonDodajKategorie;
    }
}