using OsiguravajucaKuca.Klase;
using OsiguravajucaKuca.SQLKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsiguravajucaKuca.Forms
{
    public partial class FormKorisnik : Form
    {
        private int _id;
        private SqlUpisivanje _sqlU;
        private SqlIzlistavanje _sqlIzlistavanje;
        private SqlUpitnici _sqlUpitnici;
        public FormKorisnik(int id)
        {
            InitializeComponent();
            _id = id;
            _sqlU = new SqlUpisivanje();
            _sqlIzlistavanje = new SqlIzlistavanje();
            _sqlUpitnici = new SqlUpitnici();
        }

        private void FormKorisnik_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _sqlIzlistavanje.GetImePoliseForKorisnik(_id);
            lblDobrodosli.Text = "Dobrodosli, " + _sqlUpitnici.GetImeKorisnikaById(_id);
        }

        private void btnZakazi_Click(object sender, EventArgs e)
        {
            if(cmbSastanak.Text == "")
            {
                PovratneInformacije.PraznaPolja();
                return;
            }
            if (SqlHelperi.IsNacinZakazivanjaNotNull(_id))
            {
                PovratneInformacije.NeuspesanSastanak();
                return;
            }
            _sqlU.ZakaziSastanak(_id, cmbSastanak.Text);
            MessageBox.Show("Uspesno ste zakazali sastanka!");


        }

        private void btnSteta_Click(object sender, EventArgs e)
        {
            if(!Provera())
            {
                MessageBox.Show("Ne mozete prijaviti stetu nemate polisu");
                return;
            }
            if (cmbSteta.Text == "")
            {
                PovratneInformacije.PraznaPolja();
                return;
            }
            if (SqlHelperi.IsNacinZakazivanjaNotNull(_id))
            {
                PovratneInformacije.NeuspesanSastanak();
                return;
            }
            _sqlU.ZakaziSastanak(_id, cmbSastanak.Text);
            PovratneInformacije.UspesanSastanak();
        }
        private bool Provera()
        {
            bool isPopulated = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        isPopulated = true;
                        break;
                    }
                }

                if (isPopulated)
                {
                    break;
                }
            }

            return isPopulated;
        }
    }
}
