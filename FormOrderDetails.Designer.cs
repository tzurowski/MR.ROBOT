namespace MrRobot
{
    partial class FormOrderDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.iconButtonWroc = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(247, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista zamowionych produktow";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(210, 141);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 326);
            this.listBox1.TabIndex = 1;
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
            this.iconButtonWroc.TabIndex = 92;
            this.iconButtonWroc.Text = "Wróć";
            this.iconButtonWroc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonWroc.UseVisualStyleBackColor = true;
            this.iconButtonWroc.Click += new System.EventHandler(this.iconButtonWroc_Click);
            // 
            // FormOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 608);
            this.Controls.Add(this.iconButtonWroc);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrderDetails";
            this.Text = "FormOrderDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton iconButtonWroc;
    }
}