using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MrRobot
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string login = "";
        public bool isAdmin = false;
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //labelTitleChildForm.Text = childForm.Text;
        }

        //metody
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 51, 76);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 150, 136));
            OpenChildForm(new FormShop());
            labelTitleChildForm.Text = "Sklep";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 150, 136));
            OpenChildForm(new FormCart());
            labelTitleChildForm.Text = "Koszyk";
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 150, 136));
            OpenChildForm(new FormOrders());
            labelTitleChildForm.Text = "Zamówienia";
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 150, 136));
            OpenChildForm(new FormSettings());
            labelTitleChildForm.Text = "Ustawienia";
        }

        public void iconButton5_Click(object sender, EventArgs e)
        {
            if (iconButton5.Text == "Zaloguj")
            {
                ActivateButton(sender, Color.FromArgb(0, 150, 136));
                OpenChildForm(new FormLogIn(this));
                labelTitleChildForm.Text = "Zaloguj";
            }
            else if(iconButton5.Text == "Wyloguj")
            {
                ActivateButton(sender, Color.FromArgb(0, 150, 136));
                OpenChildForm(new FormProfile(this));
                labelTitleChildForm.Text = "Profil użytkownika";
            }
            else
            {
                ActivateButton(sender, Color.FromArgb(0, 150, 136));
                OpenChildForm(new FormRegistration(this));
                labelTitleChildForm.Text = "Rejestracja";
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            //iconCurrentChildForm.IconColor = Color.MediumPurple;
            labelTitleChildForm.Text = "Strona główna";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
