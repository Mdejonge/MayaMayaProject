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
        public void getLunchItems(out List<string> LunchItemNaam, out List<int> LunchItemVoorraad)
        {
            LunchItemNaam = new List<string>();
            LunchItemVoorraad = new List<int>();

            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT DISTINCT Menu_Items.ITEM_NAAM, Menu_Items.VOORRAAD FROM Menu_Items INNER JOIN Menu_Categorie ON Menu_Items.CATEGORIE_ID = '1' INNER JOIN Menukaart ON Menu_Categorie.KAART_ID = Menukaart.KAART_ID", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                //Get values form all the fields
                string itemNaam = (string)reader["ITEM_NAAM"];
                LunchItemNaam.Add(itemNaam);
                int voorraad = (int)reader["VOORRAAD"];
                LunchItemVoorraad.Add(voorraad);
            }
        }
    }
}
