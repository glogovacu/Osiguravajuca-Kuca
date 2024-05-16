using OsiguravajucaKuca.SQLKlase;
using System;
using System.Windows.Forms;

namespace OsiguravajucaKuca.Forms
{
    public partial class FormAgent : Form
    {
        private int _id;
        private SqlIzlistavanje _sqlIzlistavanje;
        private SqlUpisivanje _sqlUpisivanje;
        private SqlUpitnici _sqlUpitnici;
        
        public FormAgent(int id)
        {
            InitializeComponent();
            _id = id;
            _sqlIzlistavanje = new SqlIzlistavanje();
            _sqlUpisivanje = new SqlUpisivanje();
            _sqlUpitnici = new SqlUpitnici();
        }

        private void FormAgent_Load(object sender, EventArgs e)
        {
            dataKorisniciSvi.DataSource = _sqlIzlistavanje.GetTable("KORISNIK");
            dataKorisnici.DataSource = _sqlIzlistavanje.GetKorisnikeSaNacinomZakazivanje();
            dataSastanci.DataSource = _sqlIzlistavanje.GetTable("SASTANAK");
            dataPlacanja.DataSource = _sqlIzlistavanje.GetTable("PLACANJE");
            dataStete.DataSource = _sqlIzlistavanje.GetTable("STETA");
            dataUgovori.DataSource = _sqlIzlistavanje.GetTable("UGOVOR");
            SqlHelperi.FillPoliseComboBox(cmbPolise);
            lblDobrodosli.Text = "Dobrodosli, " + _sqlUpitnici.GetImeAgentaById(_id);
        }

        private void btnZakaziSastanak_Click(object sender, EventArgs e)
        {
            int idKorisnika = 0;

            if (dataKorisnici.SelectedCells.Count == 0)
            {
                MessageBox.Show("Izaberite bar jedan red");
            }
            int selectedRowIndex = dataKorisnici.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataKorisnici.Rows[selectedRowIndex];

            idKorisnika = Convert.ToInt32(selectedRow.Cells["ID_KORISNIKA"].Value);

            _sqlUpisivanje.InsertSastanak(idKorisnika, _id, dateSastanka.Value);

            dataSastanci.DataBindings.Clear();
            dataSastanci.DataSource = _sqlIzlistavanje.GetTable("SASTANAK");

            dataKorisnici.DataBindings.Clear();
            dataKorisnici.DataSource = _sqlIzlistavanje.GetKorisnikeSaNacinomZakazivanje();


        }

        private void btnPremija_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSteta_Click(object sender, EventArgs e)
        {
           
        }

        private void txtFiltrirajKorisnika_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSteta_Click_1(object sender, EventArgs e)
        {
            int idKorisnika = 0;

            if (dataKorisniciSvi.SelectedCells.Count == 0)
            {
                MessageBox.Show("Izaberite bar jedan red");
            }
            int selectedRowIndex = dataKorisniciSvi.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataKorisniciSvi.Rows[selectedRowIndex];
            idKorisnika = Convert.ToInt32(selectedRow.Cells["ID_KORISNIKA"].Value);

            _sqlUpisivanje.InsertUgovor(idKorisnika, this._id, _sqlUpitnici.GetPoliseIdByIme(cmbPolise.Text));
            _sqlUpisivanje.InsertSteta(_sqlUpitnici.GetPoliseIdByIme(cmbPolise.Text), SqlHelperi.GetLastUgovorId(), Convert.ToSingle(numPolje.Value));
            dataUgovori.DataBindings.Clear();
            dataUgovori.DataSource = _sqlIzlistavanje.GetTable("UGOVOR");

            dataPlacanja.DataBindings.Clear();
            dataPlacanja.DataSource = _sqlIzlistavanje.GetTable("PLACANJE");
        }

        private void btnPremija_Click_1(object sender, EventArgs e)
        {
            int idKorisnika = 0;

            if (dataKorisniciSvi.SelectedCells.Count == 0)
            {
                MessageBox.Show("Izaberite bar jedan red");
            }
            int selectedRowIndex = dataKorisniciSvi.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataKorisniciSvi.Rows[selectedRowIndex];
            idKorisnika = Convert.ToInt32(selectedRow.Cells["ID_KORISNIKA"].Value);

            _sqlUpisivanje.InsertUgovor(idKorisnika, this._id, _sqlUpitnici.GetPoliseIdByIme(cmbPolise.Text));
            _sqlUpisivanje.InsertPlacanje(_sqlUpitnici.GetPoliseIdByIme(cmbPolise.Text), SqlHelperi.GetLastUgovorId(), Convert.ToSingle(numPolje.Value));
            dataUgovori.DataBindings.Clear();
            dataUgovori.DataSource = _sqlIzlistavanje.GetTable("UGOVOR");

            dataPlacanja.DataBindings.Clear();
            dataPlacanja.DataSource = _sqlIzlistavanje.GetTable("PLACANJE");
        }

        private void btnUpisiDatum_Click(object sender, EventArgs e)
        {
            int idPlacanja = 0;

            if (dataStete.SelectedCells.Count == 0)
            {
                MessageBox.Show("Izaberite bar jedan red");
            }
            int selectedRowIndex = dataStete.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataStete.Rows[selectedRowIndex];
            idPlacanja = Convert.ToInt32(selectedRow.Cells["ID_STETE"].Value);
            _sqlUpisivanje.UpdateStetaDatum(idPlacanja, dateTimePicker1.Value);

            dataStete.DataBindings.Clear();
            dataStete.DataSource = _sqlIzlistavanje.GetTable("STETA");
        }

        private void btnDatumPlacanja_Click(object sender, EventArgs e)
        {
            int idPlacanja = 0;

            if (dataPlacanja.SelectedCells.Count == 0)
            {
                MessageBox.Show("Izaberite bar jedan red");
            }
            int selectedRowIndex = dataPlacanja.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataPlacanja.Rows[selectedRowIndex];
            idPlacanja = Convert.ToInt32(selectedRow.Cells["ID_PLACANJA"].Value);
            _sqlUpisivanje.UpdatePlacanjeDatum(idPlacanja, dateTimePicker1.Value);

            dataPlacanja.DataBindings.Clear();
            dataPlacanja.DataSource = _sqlIzlistavanje.GetTable("PLACANJE");
        }
    }
}
