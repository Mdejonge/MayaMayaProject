using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayaMaya
{
    class Main
    {
        public void leesMenuItems()
        {
            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaConnectionString"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM Menu_Items", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                //Get values form all the fields
                int item_id = (int)reader["ITEM_ID"];
                string itemNaam = (string)reader["ITEM_NAAM"];
                int voorraad = (int)reader["VOORRAAD"];
                float prijs = (float)(double)reader["PRIJS"];
                int btw = (int)reader["BTW_HEFFING"];;
            }

        }
    }
}
