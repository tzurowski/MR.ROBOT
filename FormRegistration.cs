using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MrRobot
{
    public partial class FormRegistration : Form
    {
        FormMainMenu _form;
        string imie, nazwisko, ulica, kodPocztowy, miejscowosc, nazwaUzytkownika, haslo, potwierdzHaslo, email;
        public FormRegistration(FormMainMenu form)
        {
            InitializeComponent();
            _form = form;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _form.ActivateButton(_form.iconButtonAccount);
            _form.OpenChildForm(new FormLogIn(_form));
            _form.labelTitleChildForm.Text = "Zaloguj";
            _form.iconButtonAccount.Text = "Zaloguj";
        }
        private bool SprawdzFormularz()
        {

            UstawDane();
            if (String.IsNullOrEmpty(imie) ||
                String.IsNullOrEmpty(nazwisko) ||
                String.IsNullOrEmpty(ulica) ||
                String.IsNullOrEmpty(kodPocztowy) ||
                String.IsNullOrEmpty(miejscowosc) ||
                String.IsNullOrEmpty(nazwaUzytkownika) ||
                String.IsNullOrEmpty(haslo) ||
                String.IsNullOrEmpty(potwierdzHaslo) ||
                String.IsNullOrEmpty(email))
            {
                return false;
            }
            else
            {
                if (textBoxHaslo.Text == textBoxPotwierdzHaslo.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void UstawDane()
        {
            imie = textBoxImie.Text.Trim();
            nazwisko = textBoxNazwisko.Text.Trim();
            ulica = textBoxNazwisko.Text.Trim();
            kodPocztowy = textBoxKodPocztowy.Text.Trim();
            miejscowosc = textBoxMiejscowosc.Text.Trim();
            nazwaUzytkownika = textBoxNazwaUzytkownika.Text.Trim();
            haslo = textBoxHaslo.Text.Trim();
            potwierdzHaslo = textBoxPotwierdzHaslo.Text.Trim();
            email = textBoxEmail.Text.Trim();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nazwaUzytkownika = nazwaUzytkownika + "|" + imie + "|" + nazwisko;
            if(SprawdzFormularz())
            {
                Gosc nowyUzytkownik = new Gosc(nazwaUzytkownika, haslo, email, ulica, miejscowosc, kodPocztowy);

                if (nowyUzytkownik.Rejestracja())
                {
                    MessageBox.Show("Zarejestrowano sie poprawnie");
                }
            }
            else
            {
                MessageBox.Show("Podano błędne dane!");
            }
        }
    }
}
