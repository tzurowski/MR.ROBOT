using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MrRobot
{
    public partial class FormLogIn : Form
    {

        FormMainMenu _form;
        public static bool isLogin = false;
        public FormLogIn(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Zaloguj(textBox1.Text.Trim(), textBox2.Text.Trim());
        }

        public void Zaloguj(string login, string haslo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tzuro\OneDrive\Studia\6 Inżynieria oprogramowania\MrRobot\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string loginQuery = "SELECT * FROM LoginTable WHERE username='" + login + "'and password = '" + haslo + "'";
            SqlDataAdapter sda = new SqlDataAdapter(loginQuery, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                _form.ActivateButton(_form.iconButton1, Color.FromArgb(0, 150, 136));
                _form.OpenChildForm(new FormShop());
                _form.labelTitleChildForm.Text = "Sklep";
                _form.iconButton5.Text = "Wyloguj";
                _form.login = login;
            }
            else
            {
                MessageBox.Show("Podano błędne dane");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButton5, Color.FromArgb(0, 150, 136));
            _form.OpenChildForm(new FormRegistration(_form));
            _form.labelTitleChildForm.Text = "Rejestracja";
            _form.iconButton5.Text = "Zarejestruj";
        }
    }
}
