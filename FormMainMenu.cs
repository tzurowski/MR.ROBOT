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
        public bool isSeller = false;
        public bool isLoggedIn = false;
        private Color sideMenuColor = Color.FromArgb(51, 51, 76);
        private Color subMenuColor = Color.FromArgb(41, 41, 61);
        private Color activeColor = Color.FromArgb(0, 150, 136);
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            panelAccountSubMenu.Visible = false;
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
        public void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = sideMenuColor;
                currentBtn.ForeColor = activeColor;
                currentBtn.IconColor = activeColor;
                //Left border button
                leftBorderBtn.BackColor = activeColor; 
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
                if (panelAccountSubMenu.Visible == true)
                    panelAccountSubMenu.Visible = false;
                if (currentBtn == (IconButton)iconButtonLogOut || currentBtn == (IconButton)iconButtonProfile)
                    currentBtn.BackColor = subMenuColor;
                    
                else
                    currentBtn.BackColor = sideMenuColor;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }

        private void iconButtonShop_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormShop());
            labelTitleChildForm.Text = "Sklep";
        }

        private void iconButtonCart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormCart());
            labelTitleChildForm.Text = "Koszyk";
        }

        private void iconButtonOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormOrders());
            labelTitleChildForm.Text = "Zamówienia";
        }

        public void iconButtonAccount_Click(object sender, EventArgs e)
        {
            if (isLoggedIn == false)
            {
                ActivateButton(sender);
                OpenChildForm(new FormLogIn(this));
                labelTitleChildForm.Text = "Zaloguj";
            }
            else if(isLoggedIn == true)
            {
                ActivateButton(sender);
                //OpenChildForm(new FormProfile(this));
                //labelTitleChildForm.Text = "Profil użytkownika";
                if (panelAccountSubMenu.Visible == false)
                    panelAccountSubMenu.Visible = true;
            }
            else
            {
                ActivateButton(sender);
                OpenChildForm(new FormRegistration(this));
                labelTitleChildForm.Text = "Rejestracja";
            }
        }

        private void iconButtonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfile(this));
            if (panelAccountSubMenu.Visible == true)
                panelAccountSubMenu.Visible = false;
            labelTitleChildForm.Text = "Profil";
            iconCurrentChildForm.IconChar = iconButtonLogOut.IconChar;
        }

        private void iconButtonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomyślnie wylogowano");
            isAdmin = false;
            isLoggedIn = false;
            ActivateButton(iconButtonAccount);
            OpenChildForm(new FormLogIn(this));
            labelTitleChildForm.Text = "Zaloguj";
            iconButtonAccount.Text = " Zaloguj";
            login = "";
            if (panelAccountSubMenu.Visible == true)
                panelAccountSubMenu.Visible = false;
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
