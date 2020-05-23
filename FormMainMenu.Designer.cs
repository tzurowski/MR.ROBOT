namespace MrRobot
{
    partial class FormMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonProfile = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.iconButtonAccount = new FontAwesome.Sharp.IconButton();
            this.iconButtonOrders = new FontAwesome.Sharp.IconButton();
            this.iconButtonCart = new FontAwesome.Sharp.IconButton();
            this.iconButtonShop = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonMaximize = new FontAwesome.Sharp.IconButton();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAccountSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.panelAccountSubMenu);
            this.panelMenu.Controls.Add(this.iconButtonAccount);
            this.panelMenu.Controls.Add(this.iconButtonOrders);
            this.panelMenu.Controls.Add(this.iconButtonCart);
            this.panelMenu.Controls.Add(this.iconButtonShop);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 674);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonProfile
            // 
            this.iconButtonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButtonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonProfile.FlatAppearance.BorderSize = 0;
            this.iconButtonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProfile.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButtonProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonProfile.IconSize = 36;
            this.iconButtonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProfile.Location = new System.Drawing.Point(0, 60);
            this.iconButtonProfile.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonProfile.Name = "iconButtonProfile";
            this.iconButtonProfile.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.iconButtonProfile.Rotation = 0D;
            this.iconButtonProfile.Size = new System.Drawing.Size(220, 60);
            this.iconButtonProfile.TabIndex = 4;
            this.iconButtonProfile.Text = " Profil";
            this.iconButtonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonProfile.UseVisualStyleBackColor = false;
            this.iconButtonProfile.Click += new System.EventHandler(this.iconButtonProfile_Click);
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.iconButtonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLogOut.IconSize = 36;
            this.iconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogOut.Location = new System.Drawing.Point(0, 0);
            this.iconButtonLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.iconButtonLogOut.Rotation = 0D;
            this.iconButtonLogOut.Size = new System.Drawing.Size(220, 60);
            this.iconButtonLogOut.TabIndex = 5;
            this.iconButtonLogOut.Text = " Wyloguj";
            this.iconButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogOut.UseVisualStyleBackColor = false;
            this.iconButtonLogOut.Click += new System.EventHandler(this.iconButtonLogOut_Click);
            // 
            // iconButtonAccount
            // 
            this.iconButtonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAccount.FlatAppearance.BorderSize = 0;
            this.iconButtonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAccount.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButtonAccount.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAccount.IconSize = 36;
            this.iconButtonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccount.Location = new System.Drawing.Point(0, 270);
            this.iconButtonAccount.Name = "iconButtonAccount";
            this.iconButtonAccount.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAccount.Rotation = 0D;
            this.iconButtonAccount.Size = new System.Drawing.Size(220, 60);
            this.iconButtonAccount.TabIndex = 5;
            this.iconButtonAccount.Text = " Zaloguj";
            this.iconButtonAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAccount.UseVisualStyleBackColor = true;
            this.iconButtonAccount.Click += new System.EventHandler(this.iconButtonAccount_Click);
            // 
            // iconButtonOrders
            // 
            this.iconButtonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOrders.FlatAppearance.BorderSize = 0;
            this.iconButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonOrders.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconButtonOrders.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOrders.IconSize = 36;
            this.iconButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.Location = new System.Drawing.Point(0, 210);
            this.iconButtonOrders.Name = "iconButtonOrders";
            this.iconButtonOrders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonOrders.Rotation = 0D;
            this.iconButtonOrders.Size = new System.Drawing.Size(220, 60);
            this.iconButtonOrders.TabIndex = 3;
            this.iconButtonOrders.Text = " Zamówienia";
            this.iconButtonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOrders.UseVisualStyleBackColor = true;
            this.iconButtonOrders.Click += new System.EventHandler(this.iconButtonOrders_Click);
            // 
            // iconButtonCart
            // 
            this.iconButtonCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCart.FlatAppearance.BorderSize = 0;
            this.iconButtonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCart.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.iconButtonCart.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCart.IconSize = 36;
            this.iconButtonCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCart.Location = new System.Drawing.Point(0, 150);
            this.iconButtonCart.Name = "iconButtonCart";
            this.iconButtonCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCart.Rotation = 0D;
            this.iconButtonCart.Size = new System.Drawing.Size(220, 60);
            this.iconButtonCart.TabIndex = 2;
            this.iconButtonCart.Text = " Koszyk";
            this.iconButtonCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCart.UseVisualStyleBackColor = true;
            this.iconButtonCart.Click += new System.EventHandler(this.iconButtonCart_Click);
            // 
            // iconButtonShop
            // 
            this.iconButtonShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonShop.FlatAppearance.BorderSize = 0;
            this.iconButtonShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonShop.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonShop.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.iconButtonShop.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonShop.IconSize = 36;
            this.iconButtonShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonShop.Location = new System.Drawing.Point(0, 90);
            this.iconButtonShop.Name = "iconButtonShop";
            this.iconButtonShop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonShop.Rotation = 0D;
            this.iconButtonShop.Size = new System.Drawing.Size(220, 60);
            this.iconButtonShop.TabIndex = 1;
            this.iconButtonShop.Text = " Sklep";
            this.iconButtonShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonShop.UseVisualStyleBackColor = true;
            this.iconButtonShop.Click += new System.EventHandler(this.iconButtonShop_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MrRobot.Properties.Resources.RobotLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.iconButtonMinimize);
            this.panelTitleBar.Controls.Add(this.iconButtonMaximize);
            this.panelTitleBar.Controls.Add(this.iconButtonClose);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(874, 90);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.AutoSize = true;
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMinimize.IconSize = 24;
            this.iconButtonMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMinimize.Location = new System.Drawing.Point(775, -1);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Rotation = 0D;
            this.iconButtonMinimize.Size = new System.Drawing.Size(33, 33);
            this.iconButtonMinimize.TabIndex = 9;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // iconButtonMaximize
            // 
            this.iconButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMaximize.AutoSize = true;
            this.iconButtonMaximize.FlatAppearance.BorderSize = 0;
            this.iconButtonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMaximize.IconSize = 24;
            this.iconButtonMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMaximize.Location = new System.Drawing.Point(809, -1);
            this.iconButtonMaximize.Name = "iconButtonMaximize";
            this.iconButtonMaximize.Rotation = 0D;
            this.iconButtonMaximize.Size = new System.Drawing.Size(33, 33);
            this.iconButtonMaximize.TabIndex = 8;
            this.iconButtonMaximize.UseVisualStyleBackColor = true;
            this.iconButtonMaximize.Click += new System.EventHandler(this.iconButtonMaximize_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonClose.AutoSize = true;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iconButtonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonClose.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClose.IconSize = 24;
            this.iconButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClose.Location = new System.Drawing.Point(842, 0);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Rotation = 0D;
            this.iconButtonClose.Size = new System.Drawing.Size(33, 33);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(69, 28);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(170, 29);
            this.labelTitleChildForm.TabIndex = 6;
            this.labelTitleChildForm.Text = "Strona główna";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(874, 584);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::MrRobot.Properties.Resources.RobotLogoBlack;
            this.pictureBox2.Location = new System.Drawing.Point(170, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(537, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelAccountSubMenu
            // 
            this.panelAccountSubMenu.Controls.Add(this.iconButtonProfile);
            this.panelAccountSubMenu.Controls.Add(this.iconButtonLogOut);
            this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 330);
            this.panelAccountSubMenu.Name = "panelAccountSubMenu";
            this.panelAccountSubMenu.Size = new System.Drawing.Size(220, 145);
            this.panelAccountSubMenu.TabIndex = 7;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 674);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAccountSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        public FontAwesome.Sharp.IconButton iconButtonShop;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonProfile;
        private FontAwesome.Sharp.IconButton iconButtonOrders;
        private FontAwesome.Sharp.IconButton iconButtonCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        public FontAwesome.Sharp.IconButton iconButtonAccount;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        public System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonMaximize;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private System.Windows.Forms.Panel panelAccountSubMenu;
    }
}

