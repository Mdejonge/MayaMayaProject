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

            ////Run SQL command
            SqlCommand command = new SqlCommand("", conn);
            SqlDataReader reader = command.ExecuteReader();

            if (1 == 1/* checken van wachtwoord via database*/)
            {
                return true;
            }
            else
                return false;
        }
    }
}
