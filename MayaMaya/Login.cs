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
        public static int personeel_id;
        public static string persoon = "";
        
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
            //kijk of ww in database staat
            SqlCommand command = new SqlCommand("select AFDELING, PERSONEEL_ID, NAAM from Personeel where WACHTWOORD = '" + password + "'", conn);
            SqlDataReader reader = command.ExecuteReader();
            
            string afdeling = "4";
            while (reader.Read())
            {
                afdeling = (string)reader["AFDELING"];
                personeel_id = (int)reader["PERSONEEL_ID"];
                persoon = (string)reader["NAAM"];
            }
            conn.Close();
            //^^als ww er instaat word via je ww je persso_id,naam en afdeling binnen gehaald
            //vver wordt terug gegeven weleke afdeling straks bij forms gegeven moet worden. 4 is als ww fout is je doet er niks mee maar je moet iets terug geven 
            if (afdeling == "Bediening")
            {
                return "Bediening";
            }
            else if(afdeling == "Bar")
            {
                return "Bar";
            }
            else if (afdeling == "Keuken")
            {
                return "Keuken";
            }
            else
            {
                return "4";
            }
            

            
        }
    }
}
