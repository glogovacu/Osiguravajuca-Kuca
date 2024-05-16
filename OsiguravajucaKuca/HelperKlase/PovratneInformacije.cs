using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsiguravajucaKuca.Klase
{
    public class PovratneInformacije
    {
        public static void Uspesno()
        {
            MessageBox.Show("Uspesno uradnjena radnja");
        }
        public static void Neuspesno()
        {
            MessageBox.Show("Neuspesno uradnjena radnja");
        }
        public static void PraznaPolja()
        {
            MessageBox.Show("Neka polja su prazna");
        }
        public static void UspesanSastanak()
        {
            MessageBox.Show("Uspesno ste zakazali sastanka!");
        }
        public static void NeuspesanSastanak()
        {
            MessageBox.Show("Vec imate zakazano, ako niste zakazali i vidite ovu poruku pozovite 555-333");
        }
    }
}
