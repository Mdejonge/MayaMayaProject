using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    class Login
    {
        public string wachtwoordcorrect(string password)
        {
            Methodes methode = new Methodes();
            SqlConnection conn;

            methode.ConnectDatabase(out conn);
            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("select AFDELING from Personeel where WACHTWOORD = '" + password + "'", conn);
            SqlDataReader reader = command.ExecuteReader();
            
            string afdeling = "4";
            while (reader.Read())
            {
                afdeling = (string)reader["AFDELING"];
                
            }
            conn.Close();

            if (afdeling == "Bediening")
            {
                return "1";
            }
            else if(afdeling == "Bar")
            {
                return "2";
            }
            else if (afdeling == "Keuken")
            {
                return "3";
            }
            else
            {
                return "4";
            }
            

            
        }
    }
}
