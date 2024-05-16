using OsiguravajucaKuca.Forms;
using OsiguravajucaKuca.Klase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsiguravajucaKuca.SQLKlase
{
    public class SqlUpitnici
    {
        public SqlUpitnici() 
        { 

        }
        public Form GetLoginForm(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string agentQuery = "SELECT ID_AGENTA FROM AGENT WHERE EMAIL_AGENTA = @Email AND SIFRA_AGENTA = @Password";
                SqlCommand agentCommand = new SqlCommand(agentQuery, connection);
                agentCommand.Parameters.AddWithValue("@Email", email);
                agentCommand.Parameters.AddWithValue("@Password", password);

                int agentId = Convert.ToInt32(agentCommand.ExecuteScalar());

                string korisnikQuery = "SELECT ID_KORISNIKA FROM KORISNIK WHERE EMAIL_KORISNIKA = @Email AND SIFRA_KORISNIKA = @Password";
                SqlCommand korisnikCommand = new SqlCommand(korisnikQuery, connection);
                korisnikCommand.Parameters.AddWithValue("@Email", email);
                korisnikCommand.Parameters.AddWithValue("@Password", password);

                int korisnikId = Convert.ToInt32(korisnikCommand.ExecuteScalar());

                if (agentId > 0)
                {
                    return new FormAgent(agentId);
                }
                else if (korisnikId > 0)
                {
                    return new FormKorisnik(korisnikId);
                }
                else
                {
                    PovratneInformacije.Neuspesno();
                    return null;
                }
            }
        }
        public bool PostijeKorisnici(string email)
        {
            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CheckUserExistence", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.Add("@IsUserExist", SqlDbType.Bit).Direction = ParameterDirection.Output;

                    command.ExecuteNonQuery();

                    bool isUserExist = Convert.ToBoolean(command.Parameters["@IsUserExist"].Value);

                    return isUserExist;
                }
            }
        }
        public int GetPoliseIdByIme(string imePolise)
        {
            int idPolise = 0;

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT ID_POLISE FROM POLISE WHERE IME_POLISE = @ImePolise";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ImePolise", imePolise);

                idPolise = Convert.ToInt32(command.ExecuteScalar());
            }

            return idPolise;
        }
        public string GetImeKorisnikaById(int id)
        {
            string imeKorisnika = string.Empty;

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT IME_KORISNIKA FROM KORISNIK WHERE ID_KORISNIKA = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    imeKorisnika = result.ToString();
                }
            }

            return imeKorisnika;
        }

        public string GetImeAgentaById(int id)
        {
            string imeAgenta = string.Empty;

            using (SqlConnection connection = new SqlConnection(SqlConnectionString.ConnectionString))
            {
                connection.Open();

                string query = "SELECT IME_AGENTA FROM AGENT WHERE ID_AGENTA = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    imeAgenta = result.ToString();
                }
            }

            return imeAgenta;
        }
    }
}
