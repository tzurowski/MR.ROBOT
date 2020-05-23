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
using System.Globalization;

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
            Uzytkownik uzytkownik = new Uzytkownik();
            BazaTableAdapters.UzytkownikTableAdapter tableadapterUzytkownik = new BazaTableAdapters.UzytkownikTableAdapter();
            Baza.UzytkownikDataTable tableUzytkownik = new Baza.UzytkownikDataTable();
            tableadapterUzytkownik.GetUser(tableUzytkownik, login, haslo);
            foreach (Baza.UzytkownikRow row in tableUzytkownik.Rows)
            {
                uzytkownik._login = row.UserLogin;
                uzytkownik._haslo = row.UserHaslo;
                uzytkownik._isAdmin = row.UserAdmin;
                uzytkownik._isSeller = row.UserSprzedawca;
                uzytkownik._IDAddress = row.IsUserAdrIDNull()?-1:row.UserAdrID;
            }

            if(uzytkownik._login != null)
            {
                if (uzytkownik._isAdmin == true)
                    _form.isAdmin = true;
                _form.ActivateButton(_form.iconButton1);
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
            _form.ActivateButton(_form.iconButton5);
            _form.OpenChildForm(new FormRegistration(_form));
            _form.labelTitleChildForm.Text = "Rejestracja";
            _form.iconButton5.Text = "Zarejestruj";
        }
    }
}
