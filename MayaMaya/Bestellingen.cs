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
        public List<Item> bestellingen = new List<Item>();
        public Dictionary<int, int> dictionary = new Dictionary<int, int>();
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

        public void addItem(int id, out int aantal)
        {
            aantal = 1;

            foreach (Item item in bestellingen)
            {
                if (id == item.id)
                {
                    aantal++;
                }
            }

            dictionary.Add(id, aantal);

            foreach (Item item in Items)
            {
                if(id == item.id)
                {
                    bestellingen.Add(item);
                    break;
                }
            }
        }

        public void saveItem(int aantal)
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            int bestel_id = 0;

            //Database Connection
            methode.ConnectDatabase(out conn);

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT MAX(BESTEL_ID) FROM Bestellingen", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bestel_id = reader.GetInt32(0);
            }
            conn.Close();

            //Database Connection
            methode.ConnectDatabase(out conn);

            foreach (var pair in dictionary)
            {
                var key = pair.Key;
                var value = pair.Value;
            }

            foreach (Item item in bestellingen)
            {
                //Run SQL command
                command = new SqlCommand("INSERT INTO Bestel_Items(BESTEL_ID, ITEM_ID, AANTAL) VALUES(@bestel_id, @item_id, @aantal)", conn);
                command.Parameters.AddWithValue("@bestel_id", bestel_id);
                command.Parameters.AddWithValue("@item_id", item.id);
                command.Parameters.AddWithValue("@aantal", aantal);
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            

            conn.Close();
        }

        public void SaveBestelling(float totaalprijs)
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            methode.ConnectDatabase(out conn);

            SqlCommand command = new SqlCommand("INSERT INTO Bestellingen(DATUM_TIJD, TAFELNUMMER, PERSONEEL_ID, BETAALD_BEDRAG, BESTELTOTAAL, BETAALWIJZE, STATUS) VALUES(@datum_tijd, @tafelnummer, @personeel_id, @betaald_bedrag, @besteltotaal, @betaalwijze, @status)", conn);
            command.Parameters.AddWithValue("@datum_tijd", DateTime.Now);
            command.Parameters.AddWithValue("@tafelnummer", Tafels.tafelnummer);
            command.Parameters.AddWithValue("@personeel_id", 6);
            command.Parameters.AddWithValue("@betaald_bedrag", 0);
            command.Parameters.AddWithValue("@besteltotaal", totaalprijs);
            command.Parameters.AddWithValue("@betaalwijze", "pin");
            command.Parameters.AddWithValue("@status", 0);
            command.Connection = conn;
            command.ExecuteNonQuery();

            conn.Close();
        }
    }

}
