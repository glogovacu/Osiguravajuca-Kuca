using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OsiguravajucaKuca.SQLKlase
{
    public class SqlUpisivanje
    {
        private readonly string _connectionString;

        public SqlUpisivanje()
        {
            _connectionString = SqlConnectionString.ConnectionString;
        }

        public void UpisiKorisnika(string ime, string prezime, string jmbg, string telefon, string email, string sifra, string datumRodjenja)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                string sqlQuery = "INSERT INTO KORISNIK (IME_KORISNIKA, PREZIME_KORISNIKA, JMBG_KORISNIKA, TELEFON_KORISNIKA, EMAIL_KORISNIKA, SIFRA_KORISNIKA, DATUMRODJENJA_KORISNIKA) VALUES (@Ime, @Prezime, @Jmbg, @Telefon, @Email, @Sifra, @DatumRodjenja)";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Ime", ime);
                    cmd.Parameters.AddWithValue("@Prezime", prezime);
                    cmd.Parameters.AddWithValue("@Jmbg", jmbg);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sifra", sifra);
                    cmd.Parameters.AddWithValue("@DatumRodjenja", datumRodjenja);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void ZakaziSastanak(int id, string nacin)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                string query = $"UPDATE KORISNIK SET NACINZAKAZIVANJA_KORISNIKA = @NewValue WHERE ID_KORISNIKA = @KorisnikId";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@NewValue", nacin);
                command.Parameters.AddWithValue("@KorisnikId", id);

                command.ExecuteNonQuery();
            }
        }
        public void InsertSastanak(int id_korisnika, int id_agenta, DateTime datum_sastanka)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Sastanak (ID_KORISNIKA, ID_AGENTA, DATUM_SASTANKA) " +
                    "VALUES (@id_korisnika, @id_agenta, @datum_sastanka)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_korisnika", id_korisnika);
                command.Parameters.AddWithValue("@id_agenta", id_agenta);
                command.Parameters.AddWithValue("@datum_sastanka", datum_sastanka);

                command.ExecuteNonQuery();
            }
        }
        public void InsertPlacanje(int id_polise, int id_ugovora, float premija)
        {
            int id_korisnika;
            int id_agenta;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sastanakQuery = "SELECT ID_KORISNIKA, ID_AGENTA FROM UGOVOR WHERE ID_UGOVORA = @IdSastanka";
                SqlCommand sastanakCommand = new SqlCommand(sastanakQuery, connection);
                sastanakCommand.Parameters.AddWithValue("@IdSastanka", id_ugovora);

                using (SqlDataReader reader = sastanakCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id_korisnika = Convert.ToInt32(reader["ID_KORISNIKA"]);
                        id_agenta = Convert.ToInt32(reader["ID_AGENTA"]);
                    }
                    else
                    {
                        MessageBox.Show("Kao da ne postoje id_agenta i id_korisnika ili id_sastanka");
                        return;
                    }
                }

                string placanjeQuery = "INSERT INTO PLACANJE (ID_POLISE, ID_KORISNIKA, ID_AGENTA, ID_UGOVORA, PREMIJA_PLACANJA) " +
                    "VALUES (@IdPolise, @IdKorisnika, @IdAgenta, @IdSastanka, @Premija)";

                SqlCommand placanjeCommand = new SqlCommand(placanjeQuery, connection);
                placanjeCommand.Parameters.AddWithValue("@IdPolise", id_polise);
                placanjeCommand.Parameters.AddWithValue("@IdKorisnika", id_korisnika);
                placanjeCommand.Parameters.AddWithValue("@IdAgenta", id_agenta);
                placanjeCommand.Parameters.AddWithValue("@IdSastanka", id_ugovora);
                placanjeCommand.Parameters.AddWithValue("@Premija", premija);

                placanjeCommand.ExecuteNonQuery();
            }
        }
        
        public void InsertSteta(int id_polise, int id_ugovora, float steta)
        {
            int id_korisnika;
            int id_agenta;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sastanakQuery = "SELECT ID_KORISNIKA, ID_AGENTA FROM UGOVOR WHERE ID_UGOVORA = @IdSastanka";
                SqlCommand sastanakCommand = new SqlCommand(sastanakQuery, connection);
                sastanakCommand.Parameters.AddWithValue("@IdSastanka", id_ugovora);

                using (SqlDataReader reader = sastanakCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id_korisnika = Convert.ToInt32(reader["ID_KORISNIKA"]);
                        id_agenta = Convert.ToInt32(reader["ID_AGENTA"]);
                    }
                    else
                    {
                        MessageBox.Show("Kao da ne postoje id_agenta i id_korisnika ili id_sastanka");
                        return;
                    }
                }

                string placanjeQuery = "INSERT INTO STETA (ID_POLISE, ID_KORISNIKA, ID_AGENTA, ID_UGOVORA, OTPLATA_STETE) " +
                    "VALUES (@IdPolise, @IdKorisnika, @IdAgenta, @IdSastanka, @Steta)";

                SqlCommand stetaCommand = new SqlCommand(placanjeQuery, connection);
                stetaCommand.Parameters.AddWithValue("@IdPolise", id_polise);
                stetaCommand.Parameters.AddWithValue("@IdKorisnika", id_korisnika);
                stetaCommand.Parameters.AddWithValue("@IdAgenta", id_agenta);
                stetaCommand.Parameters.AddWithValue("@IdSastanka", id_ugovora);
                stetaCommand.Parameters.AddWithValue("@Steta", steta);

                stetaCommand.ExecuteNonQuery();
            }
        }
        public void InsertUgovor(int idKorisnika, int idAgenta, int idPolise)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Ugovor (ID_KORISNIKA, ID_AGENTA, ID_POLISE, DATUM_UGOVORA) " +
                               "VALUES (@idKorisnika, @idAgenta, @idPolise, @datum)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idKorisnika", idKorisnika);
                command.Parameters.AddWithValue("@idAgenta", idAgenta);
                command.Parameters.AddWithValue("@idPolise", idPolise);
                command.Parameters.AddWithValue("@datum", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }
        public void UpdatePlacanjeDatum(int placanjeId, DateTime newDatumPlacanja)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE PLACANJE SET DATUM_PLACANJA = @NewDatumPlacanja WHERE ID_PLACANJA = @PlacanjeId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewDatumPlacanja", newDatumPlacanja);
                command.Parameters.AddWithValue("@PlacanjeId", placanjeId);

                command.ExecuteNonQuery();
            }
        }
        public void UpdateStetaDatum(int stetaId, DateTime newDatumPrijave)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "UPDATE STETA SET DATUM_PRIJAVE = @NewDatumPrijave WHERE ID_STETE = @StetaId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewDatumPrijave", newDatumPrijave);
                command.Parameters.AddWithValue("@StetaId", stetaId);

                command.ExecuteNonQuery();
            }
        }

    }
}
