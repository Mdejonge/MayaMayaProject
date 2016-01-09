using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    class Bestellingen
    {
        public List<Item> Items = new List<Item>();
        public Bestellingen()
        {
            getItems();
        }

        public void getItems()
        {
            SqlConnection conn;
            Methodes methode = new Methodes();

            //Database Connection
            methode.ConnectDatabase(out conn);

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT Menu_Items.ITEM_ID, Menu_Items.CATEGORIE_ID, KAART_ID, Menu_Items.ITEM_NAAM, Menu_Items.VOORRAAD, Menu_Items.PRIJS, Menu_Items.BTW_HEFFING FROM Menu_Items INNER JOIN Menu_Categorie ON Menu_Items.CATEGORIE_ID = Menu_Categorie.CATEGORIE_ID", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                Items.Add(new Item(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetDouble(5), reader.GetInt32(6)));
            }

            conn.Close();
        }
    }

}
