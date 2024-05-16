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
    public partial class FormLogin : Form
    {
        private SqlUpitnici _sqlUp;
        public FormLogin()
        {
            InitializeComponent();
            _sqlUp = new SqlUpitnici();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form form = _sqlUp.GetLoginForm(txtEmail.Text,txtSifra.Text);
            if(form ==  null )
            {
                return;
            }
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
