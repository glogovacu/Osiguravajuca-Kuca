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
using OsiguravajucaKuca.Klase;
using OsiguravajucaKuca.SQLKlase;
using OsiguravajucaKuca.Forms;

namespace OsiguravajucaKuca
{
    
    public partial class FormStart : Form
    {
        private SqlUpisivanje _sqlU;
        private SqlUpitnici _sqlUpitnici;
        public FormStart()
        {
            InitializeComponent();
            _sqlU = new SqlUpisivanje();
            _sqlUpitnici = new SqlUpitnici();
        }

        private void Start_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtJMBG.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtSifra.Text == "")
            {
                PovratneInformacije.PraznaPolja();
                return;
            }
            if (txtIme.Text.Any(Char.IsDigit) || txtPrezime.Text.Any(Char.IsDigit) || txtJMBG.Text.Any(Char.IsLetter) || txtTelefon.Text.Any(Char.IsLetter) || dateRodjenje.Value.Date > DateTime.Now.Date)
            {
                PovratneInformacije.Neuspesno();
                return;
            }
            if(_sqlUpitnici.PostijeKorisnici(txtEmail.Text))
            {
                MessageBox.Show("Uneli ste email koji vec postoji u bazi podataka");
                return;
            }    

            _sqlU.UpisiKorisnika(txtIme.Text, txtPrezime.Text, txtJMBG.Text, txtTelefon.Text, txtEmail.Text, txtSifra.Text, $"{dateRodjenje.Value.Year}-{dateRodjenje.Value.Month}-{dateRodjenje.Value.Day}");

            FormKorisnik korisnikForm = new FormKorisnik(SqlHelperi.GetNewestKorisnikId());
            this.Hide();
            korisnikForm.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form = new FormLogin();
            form.ShowDialog();
            this.Close();
        }
    }
}
