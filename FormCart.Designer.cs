namespace MrRobot
{
    partial class FormCart
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
            this.buttonDodajZamowienie = new System.Windows.Forms.Button();
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.buttonUsunZListy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodajZamowienie
            // 
            this.buttonDodajZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajZamowienie.Location = new System.Drawing.Point(678, 435);
            this.buttonDodajZamowienie.Name = "buttonDodajZamowienie";
            this.buttonDodajZamowienie.Size = new System.Drawing.Size(228, 51);
            this.buttonDodajZamowienie.TabIndex = 1;
            this.buttonDodajZamowienie.Text = "Dodaj Zamowienie";
            this.buttonDodajZamowienie.UseVisualStyleBackColor = true;
            this.buttonDodajZamowienie.Click += new System.EventHandler(this.buttonDodajZamowienie_Click);
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.ItemHeight = 42;
            this.listBoxProdukty.Location = new System.Drawing.Point(415, 90);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(491, 298);
            this.listBoxProdukty.TabIndex = 2;
            // 
            // buttonUsunZListy
            // 
            this.buttonUsunZListy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsunZListy.Location = new System.Drawing.Point(444, 435);
            this.buttonUsunZListy.Name = "buttonUsunZListy";
            this.buttonUsunZListy.Size = new System.Drawing.Size(228, 51);
            this.buttonUsunZListy.TabIndex = 3;
            this.buttonUsunZListy.Text = "Usun z listy";
            this.buttonUsunZListy.UseVisualStyleBackColor = true;
            this.buttonUsunZListy.Click += new System.EventHandler(this.buttonUsunZListy_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 562);
            this.Controls.Add(this.buttonUsunZListy);
            this.Controls.Add(this.listBoxProdukty);
            this.Controls.Add(this.buttonDodajZamowienie);
            this.Name = "FormCart";
            this.Text = "DormCart";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDodajZamowienie;
        private System.Windows.Forms.ListBox listBoxProdukty;
        private System.Windows.Forms.Button buttonUsunZListy;
    }
}