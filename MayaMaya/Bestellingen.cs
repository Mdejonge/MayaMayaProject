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
        public Dictionary<int, int> dictionary = new Dictionary<int, int>();
        public Bestellingen()
        {
            getItems();
        }

        //Haalt Menu Items op uit database
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

        //Voegt Menu Item van bestellijst toe aan dictionary (id, aantal)
        public void addItem(int id)
        {
            if (dictionary.ContainsKey(id))
            {
                dictionary[id]++;
            }
            else
            {
                dictionary.Add(id, 1);
            }
        }

        //Verwijderd menu Item van verwijderde bestellijst uit dictionary
        public void removeItem(int id)
        {
            if (dictionary.ContainsKey(id))
            {
                dictionary[id]--;
            }
            else
            {
                dictionary.Remove(id);
            }
        }

        //Slaat bestelling op in database
        public void SaveBestelling()
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            methode.ConnectDatabase(out conn);

            SqlCommand command = new SqlCommand("INSERT INTO Bestellingen(DATUM_TIJD, TAFELNUMMER, PERSONEEL_ID, BETAALD_BEDRAG, BESTELTOTAAL, BETAALWIJZE, STATUS) VALUES(@datum_tijd, @tafelnummer, @personeel_id, @betaald_bedrag, @besteltotaal, @betaalwijze, @status)", conn);

            command.Parameters.AddWithValue("@datum_tijd", DateTime.Now);
            command.Parameters.AddWithValue("@tafelnummer", Tafels.tafelnummer);
            command.Parameters.AddWithValue("@personeel_id", Login.personeel_id);
            command.Parameters.AddWithValue("@betaald_bedrag", 0);
            command.Parameters.AddWithValue("@besteltotaal", Bestelling.totaalPrijs);
            command.Parameters.AddWithValue("@betaalwijze", "pin");
            command.Parameters.AddWithValue("@status", 0);
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();

            int bestelid = 0;

            conn.Open();
            SqlCommand getBestelID = new SqlCommand("SELECT MAX(BESTEL_ID) FROM Bestellingen", conn);

            SqlDataReader reader = getBestelID.ExecuteReader();

            while (reader.Read())
            {
                bestelid = reader.GetInt32(0);
            }
            conn.Close();

            conn.Open();
            SqlCommand command2 = new SqlCommand("INSERT INTO Bestelling_Items(BESTEL_ID, ITEM_ID, AANTAL) VALUES(@bestel_id, @item_id, @aantal)");

            foreach (KeyValuePair<int, int> item in dictionary)
            {
                command2.Parameters.Clear();
                command2.Parameters.AddWithValue("@bestel_id", bestelid);
                command2.Parameters.AddWithValue("@item_id", item.Key);
                command2.Parameters.AddWithValue("@aantal", item.Value);
                command2.Connection = conn;
                command2.ExecuteNonQuery();
            }
            conn.Close();

            conn.Open();
            string tafelBezet = string.Format("UPDATE Tafels SET BESCHIKBAARHEID='{0}' WHERE TAFELNUMMER={1}", 3, Tafels.tafelnummer);

            SqlCommand TafelBezet = new SqlCommand(tafelBezet, conn);
            TafelBezet.ExecuteNonQuery();
            conn.Close();
        }
    }

}
