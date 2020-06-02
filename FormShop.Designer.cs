namespace MrRobot
{
    partial class FormShop
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
            tableLayoutShopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFiltruj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableLayoutShopPanel
            // 
            tableLayoutShopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutShopPanel.ColumnCount = 3;
            tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutShopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutShopPanel.Location = new System.Drawing.Point(12, 55);
            tableLayoutShopPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutShopPanel.Name = "tableLayoutShopPanel";
            tableLayoutShopPanel.RowCount = 3;
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            tableLayoutShopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            tableLayoutShopPanel.Size = new System.Drawing.Size(1139, 600);
            tableLayoutShopPanel.TabIndex = 0;
            // 
            // comboBoxFiltruj
            // 
            this.comboBoxFiltruj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFiltruj.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFiltruj.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.comboBoxFiltruj.FormattingEnabled = true;
            this.comboBoxFiltruj.Items.AddRange(new object[] {
            "malejaco",
            "rosnaco"});
            this.comboBoxFiltruj.Location = new System.Drawing.Point(895, 12);
            this.comboBoxFiltruj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFiltruj.Name = "comboBoxFiltruj";
            this.comboBoxFiltruj.Size = new System.Drawing.Size(256, 37);
            this.comboBoxFiltruj.TabIndex = 0;
            this.comboBoxFiltruj.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltruj_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.label1.Location = new System.Drawing.Point(541, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sortuj produkty wedlug ceny";
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1163, 748);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltruj);
            this.Controls.Add(tableLayoutShopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormShop";
            this.Text = "FormShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFiltruj;
        private System.Windows.Forms.Label label1;
        public static System.Windows.Forms.TableLayoutPanel tableLayoutShopPanel;
    }
}