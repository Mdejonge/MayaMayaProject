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

            SqlCommand command = new SqlCommand("select afdeling from Personeel where WACHTWOORD = '" + password + "'", conn);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
                //int id = (int)reader["id"];

                //string naam = (string)reader["NAAM"];
                //string wachtwoord = (string) reader["WACHTWOORD"];
                ////Run SQL command
                //SqlCommand command = new SqlCommand("", conn);
                //SqlDataReader reader = command.ExecuteReader();

                //Werknemer werknemer = new Werknemer(id, afdeling, naam, wachtwoord);
                //werknemers.add(werknemer);

                //NAAM = '" + username + "' and 

            }
            if ((count)&& (1==1))//hier straks de afdeling
            {
                return "1";
            }
            else if((count ==1)&&(1==1))
            {
                return "2";
            }
            else if ((count == 1)&&(1==1))
            {
                return "3";
            }
            else
            {
                return "4";
            }
            ////Run SQL command
            //SqlCommand command = new SqlCommand("", conn);
            //SqlDataReader reader = command.ExecuteReader();

            //if (1 == 1/* checken van wachtwoord via database*/)
            //{
            //    return true;
            //}
            //else
            //    return false;

            conn.Close();
        }
    }
}
