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
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonDodajZamowienie = new FontAwesome.Sharp.IconButton();
            this.iconButtonUsunZListy = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxProdukty.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.ItemHeight = 36;
            this.listBoxProdukty.Location = new System.Drawing.Point(23, 20);
            this.listBoxProdukty.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(452, 328);
            this.listBoxProdukty.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.iconButtonDodajZamowienie);
            this.panel1.Controls.Add(this.iconButtonUsunZListy);
            this.panel1.Controls.Add(this.listBoxProdukty);
            this.panel1.Location = new System.Drawing.Point(192, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 424);
            this.panel1.TabIndex = 4;
            // 
            // iconButtonDodajZamowienie
            // 
            this.iconButtonDodajZamowienie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButtonDodajZamowienie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonDodajZamowienie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDodajZamowienie.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonDodajZamowienie.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonDodajZamowienie.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonDodajZamowienie.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonDodajZamowienie.IconColor = System.Drawing.Color.White;
            this.iconButtonDodajZamowienie.IconSize = 24;
            this.iconButtonDodajZamowienie.Location = new System.Drawing.Point(255, 364);
            this.iconButtonDodajZamowienie.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonDodajZamowienie.Name = "iconButtonDodajZamowienie";
            this.iconButtonDodajZamowienie.Rotation = 0D;
            this.iconButtonDodajZamowienie.Size = new System.Drawing.Size(220, 42);
            this.iconButtonDodajZamowienie.TabIndex = 7;
            this.iconButtonDodajZamowienie.Text = "Dodaj zamówienie";
            this.iconButtonDodajZamowienie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDodajZamowienie.UseVisualStyleBackColor = true;
            this.iconButtonDodajZamowienie.Click += new System.EventHandler(this.iconButtonDodajZamowienie_Click);
            // 
            // iconButtonUsunZListy
            // 
            this.iconButtonUsunZListy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButtonUsunZListy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonUsunZListy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUsunZListy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonUsunZListy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonUsunZListy.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonUsunZListy.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButtonUsunZListy.IconColor = System.Drawing.Color.White;
            this.iconButtonUsunZListy.IconSize = 24;
            this.iconButtonUsunZListy.Location = new System.Drawing.Point(23, 364);
            this.iconButtonUsunZListy.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonUsunZListy.Name = "iconButtonUsunZListy";
            this.iconButtonUsunZListy.Rotation = 0D;
            this.iconButtonUsunZListy.Size = new System.Drawing.Size(220, 42);
            this.iconButtonUsunZListy.TabIndex = 6;
            this.iconButtonUsunZListy.Text = "Usuń z listy";
            this.iconButtonUsunZListy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUsunZListy.UseVisualStyleBackColor = true;
            this.iconButtonUsunZListy.Click += new System.EventHandler(this.iconButtonUsunZListy_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCart";
            this.Text = "DormCart";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProdukty;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonUsunZListy;
        private FontAwesome.Sharp.IconButton iconButtonDodajZamowienie;
    }
}