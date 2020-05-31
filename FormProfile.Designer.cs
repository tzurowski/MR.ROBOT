namespace MrRobot
{
    partial class FormProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonEdytujDane = new FontAwesome.Sharp.IconButton();
            this.iconButtonAdminPanel = new FontAwesome.Sharp.IconButton();
            this.iconButtonSellerPanel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 30.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(381, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MrRobot.Properties.Resources._64495;
            this.pictureBox1.Location = new System.Drawing.Point(340, 141);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonEdytujDane
            // 
            this.iconButtonEdytujDane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonEdytujDane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonEdytujDane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEdytujDane.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonEdytujDane.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonEdytujDane.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonEdytujDane.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButtonEdytujDane.IconColor = System.Drawing.Color.White;
            this.iconButtonEdytujDane.IconSize = 24;
            this.iconButtonEdytujDane.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonEdytujDane.Location = new System.Drawing.Point(340, 348);
            this.iconButtonEdytujDane.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonEdytujDane.Name = "iconButtonEdytujDane";
            this.iconButtonEdytujDane.Rotation = 0D;
            this.iconButtonEdytujDane.Size = new System.Drawing.Size(195, 47);
            this.iconButtonEdytujDane.TabIndex = 86;
            this.iconButtonEdytujDane.Text = " Edytuj dane";
            this.iconButtonEdytujDane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEdytujDane.UseVisualStyleBackColor = true;
            this.iconButtonEdytujDane.Click += new System.EventHandler(this.iconButtonEdytujDane_Click);
            // 
            // iconButtonAdminPanel
            // 
            this.iconButtonAdminPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAdminPanel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAdminPanel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonAdminPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonAdminPanel.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.iconButtonAdminPanel.IconColor = System.Drawing.Color.White;
            this.iconButtonAdminPanel.IconSize = 24;
            this.iconButtonAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonAdminPanel.Location = new System.Drawing.Point(304, 485);
            this.iconButtonAdminPanel.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdminPanel.Name = "iconButtonAdminPanel";
            this.iconButtonAdminPanel.Rotation = 0D;
            this.iconButtonAdminPanel.Size = new System.Drawing.Size(262, 47);
            this.iconButtonAdminPanel.TabIndex = 87;
            this.iconButtonAdminPanel.Text = " Panel administratora";
            this.iconButtonAdminPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAdminPanel.UseVisualStyleBackColor = true;
            this.iconButtonAdminPanel.Click += new System.EventHandler(this.iconButtonAdminPanel_Click);
            // 
            // iconButtonSellerPanel
            // 
            this.iconButtonSellerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSellerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconButtonSellerPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSellerPanel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSellerPanel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonSellerPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButtonSellerPanel.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconButtonSellerPanel.IconColor = System.Drawing.Color.White;
            this.iconButtonSellerPanel.IconSize = 24;
            this.iconButtonSellerPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSellerPanel.Location = new System.Drawing.Point(304, 417);
            this.iconButtonSellerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonSellerPanel.Name = "iconButtonSellerPanel";
            this.iconButtonSellerPanel.Rotation = 0D;
            this.iconButtonSellerPanel.Size = new System.Drawing.Size(262, 47);
            this.iconButtonSellerPanel.TabIndex = 88;
            this.iconButtonSellerPanel.Text = " Panel sprzedawcy";
            this.iconButtonSellerPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSellerPanel.UseVisualStyleBackColor = true;
            this.iconButtonSellerPanel.Click += new System.EventHandler(this.iconButtonSellerPanel_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.iconButtonSellerPanel);
            this.Controls.Add(this.iconButtonAdminPanel);
            this.Controls.Add(this.iconButtonEdytujDane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonEdytujDane;
        private FontAwesome.Sharp.IconButton iconButtonAdminPanel;
        private FontAwesome.Sharp.IconButton iconButtonSellerPanel;
    }
}