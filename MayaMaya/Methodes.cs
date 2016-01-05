using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    class Methodes
    {
        //Constructor
        public Methodes()
        {
        }
        
        public void ConnectDatabase(out SqlConnection conn)
        {
            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            conn = new SqlConnection(connString);
            conn.Open();
        }
    }
    class Berkeningen
    {
        
        
        public bool wachtwoordcorrect(string username, string password)
        {
            
            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("select * from Personeel where NAAM = '" + username + "' and WACHTWOORD = '" + password +"'", conn);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
                //int id = (int)reader["id"];
                //string afdeling = (string) reader["AFDELING"];
                //string naam = (string)reader["NAAM"];
                //string wachtwoord = (string) reader["WACHTWOORD"];
            ////Run SQL command
            SqlCommand command = new SqlCommand("", conn);
            SqlDataReader reader = command.ExecuteReader();

                //Werknemer werknemer = new Werknemer(id, afdeling, naam, wachtwoord);
                //werknemers.add(werknemer);
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
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
        }
    }
}
