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
        public Bestellingen()
        {
        }

        public void getLunchItems(out List<int> LunchItemID, out List<string> LunchItemNaam, out List<int> LunchItemVoorraad, out List<float> LunchItemPrijs)
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            LunchItemID = new List<int>();
            LunchItemNaam = new List<string>();
            LunchItemVoorraad = new List<int>();
            LunchItemPrijs = new List<float>();

            //Database Connection
            methode.ConnectDatabase(out conn);

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT DISTINCT Menu_Items.ITEM_ID, Menu_Items.ITEM_NAAM, Menu_Items.VOORRAAD, Menu_Items.PRIJS FROM Menu_Items INNER JOIN Menu_Categorie ON Menu_Items.CATEGORIE_ID = '1' OR Menu_Items.CATEGORIE_ID = '2' OR Menu_Items.CATEGORIE_ID = '3' INNER JOIN Menukaart ON Menu_Categorie.KAART_ID = Menukaart.KAART_ID", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                //Get values form all the fields
                int itemID = (int)reader["ITEM_ID"];
                LunchItemID.Add(itemID);
                string itemNaam = (string)reader["ITEM_NAAM"];
                LunchItemNaam.Add(itemNaam);
                int voorraad = (int)reader["VOORRAAD"];
                LunchItemVoorraad.Add(voorraad);
                float prijs = (float)(double)reader["PRIJS"];
                LunchItemPrijs.Add(prijs);
            }
        }

        public void getDinerItems(out List<int> DinerItemID, out List<string> DinerItemNaam, out List<int> DinerItemVoorraad, out List<float> DinerItemPrijs)
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            DinerItemID = new List<int>();
            DinerItemNaam = new List<string>();
            DinerItemVoorraad = new List<int>();
            DinerItemPrijs = new List<float>();

            //Database Connection
            methode.ConnectDatabase(out conn);

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT DISTINCT Menu_Items.ITEM_ID, Menu_Items.ITEM_NAAM, Menu_Items.VOORRAAD, Menu_Items.PRIJS FROM Menu_Items INNER JOIN Menu_Categorie ON Menu_Items.CATEGORIE_ID = '4' OR Menu_Items.CATEGORIE_ID = '5' OR Menu_Items.CATEGORIE_ID = '6' OR Menu_Items.CATEGORIE_ID = '7' INNER JOIN Menukaart ON Menu_Categorie.KAART_ID = Menukaart.KAART_ID", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                //Get values form all the fields
                int itemID = (int)reader["ITEM_ID"];
                DinerItemID.Add(itemID);
                string itemNaam = (string)reader["ITEM_NAAM"];
                DinerItemNaam.Add(itemNaam);
                int voorraad = (int)reader["VOORRAAD"];
                DinerItemVoorraad.Add(voorraad);
                float prijs = (float)(double)reader["PRIJS"];
                DinerItemPrijs.Add(prijs);
            }
        }

        public void getDrankenItems(out List<int> DrankenItemID, out List<string> DrankenItemNaam, out List<int> DrankenItemVoorraad, out List<float> DrankenItemPrijs)
        {
            SqlConnection conn;
            Methodes methode = new Methodes();
            DrankenItemID = new List<int>();
            DrankenItemNaam = new List<string>();
            DrankenItemVoorraad = new List<int>();
            DrankenItemPrijs = new List<float>();

            //Database Connection
            methode.ConnectDatabase(out conn);

            //Run SQL command
            SqlCommand command = new SqlCommand("SELECT DISTINCT Menu_Items.ITEM_ID, Menu_Items.ITEM_NAAM, Menu_Items.VOORRAAD, Menu_Items.PRIJS FROM Menu_Items INNER JOIN Menu_Categorie ON Menu_Items.CATEGORIE_ID = '9' OR Menu_Items.CATEGORIE_ID = '10' OR Menu_Items.CATEGORIE_ID = '11' OR Menu_Items.CATEGORIE_ID = '12' INNER JOIN Menukaart ON Menu_Categorie.KAART_ID = Menukaart.KAART_ID;", conn);
            SqlDataReader reader = command.ExecuteReader();

            //Process results(record for record)
            while (reader.Read())
            {
                //Get values form all the fields
                int itemID = (int)reader["ITEM_ID"];
                DrankenItemID.Add(itemID);
                string itemNaam = (string)reader["ITEM_NAAM"];
                DrankenItemNaam.Add(itemNaam);
                int voorraad = (int)reader["VOORRAAD"];
                DrankenItemVoorraad.Add(voorraad);
                float prijs = (float)(double)reader["PRIJS"];
                DrankenItemPrijs.Add(prijs);
            }
        }
    }

}
