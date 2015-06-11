using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Workout_tracker
{
    class Database
    {
        //Database connectie
         private OleDbConnection connection;

        public Database(string bestand)
        {
            string provider;

            provider = "Provider=Microsoft.ACE.OLEDB.12.0";

            string connectionString = provider + ";Data Source=" + bestand;
            connection = new OleDbConnection(connectionString);
        }

        //Ophalen van materiaalsoorten uit de database en het meegeven van de eerder gekozen spiersoort voor specifieke selectie
        public List<string> GetMateriaal(string s)
        {
            string sql = "SELECT DISTINCT Materiaal FROM Oefening WHERE Spiergroep = '" + s + "'";
            OleDbCommand command = new OleDbCommand(sql, connection);


            List<string> Materialen = new List<string>();

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string eenMateriaal = Convert.ToString(reader[0]);
                    Materialen.Add(eenMateriaal);
                }
            }

            catch
            {
                return null;
            }

            finally
            {
                connection.Close();
            }

            return Materialen;
        }

        //Ophalen van oefeningen uit de database en meegeven van spiergroep en materiaal voor specifieke selectie
        public List<string> GetOefening(string m, string s)
        {
            string sql = "SELECT DISTINCT Oefening FROM Oefening WHERE Materiaal = '" + m + "'" + "AND Spiergroep = '" + s + "'";
            OleDbCommand command = new OleDbCommand(sql, connection);


            List<string> Oefeningen = new List<string>();

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string eenOefening = Convert.ToString(reader[0]);
                    Oefeningen.Add(eenOefening);
                }
            }

            catch
            {
                return null;
            }

            finally
            {
                connection.Close();
            }

            return Oefeningen;
        }

        //Ophalen van spiergroepen uit de database
        public List<string> GetSpiergroep()
        {
            string sql = "SELECT DISTINCT Spiergroep FROM Oefening";
            OleDbCommand command = new OleDbCommand(sql, connection);


            List<string> Spiergroepen = new List<string>();

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string eenSPiergroep = Convert.ToString(reader[0]);
                    Spiergroepen.Add(eenSPiergroep);
                }
            }

            catch
            {
                return null;
            }

            finally
            {
                connection.Close();
            }

            return Spiergroepen;
        }

        //Bijschrijven van waardes in de databse vanuit de applicatie
        public bool VoegToe(string o, int s, int r, int g, string c, string p)
        {
            try
            {
                connection.Open();
                string sql = @"INSERT INTO " + p + " (Oefening, Sets, Herhalingen, Gewicht, Commentaar) VALUES('" + o + "', " + "'" + s + "', " + "'" + r + "', " + "'" + g + "', " + "'" + c + "')";
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
                return false;
            }

            finally
            {
                connection.Close();
            }

            return true;
        }

        //Ophalen resultaten
        public List<Resultaten> GetResultaten(string p)
        {
            string sql = "SELECT * FROM " + p + " ORDER BY Oefening, Entry";
            OleDbCommand command = new OleDbCommand(sql, connection);


            List<Resultaten> Resultaten = new List<Resultaten>();

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string oefening = Convert.ToString(reader["Oefening"]);
                    int sets = Convert.ToInt32(reader["Sets"]);
                    int herhalingen = Convert.ToInt32(reader["Herhalingen"]);
                    int gewicht = Convert.ToInt32(reader["Gewicht"]);
                    string commentaar = Convert.ToString(reader["Commentaar"]);

                    Resultaten.Add(new Resultaten(oefening, sets, herhalingen, gewicht, commentaar));
                }
            }

            catch
            {
                return null;
            }

            finally
            {
                connection.Close();
            }

            return Resultaten;
        }
    }
}
