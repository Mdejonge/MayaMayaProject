using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LeesMenu();
        }

        public void LeesMenu()
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
                string itemNaam = (string)reader["ITEM_NAAM"];
                int voorraad = (int)reader["VOORRAAD"];
                float prijs = (float)(double)reader["PRIJS"];
                int btw = (int)reader["BTW_HEFFING"];

                //Add items to list
                ListViewItem menuItems = new ListViewItem(itemNaam);
                menuItems.SubItems.Add(voorraad.ToString());
                menuItems.SubItems.Add(prijs.ToString());
                menuItems.SubItems.Add(btw.ToString());
                listviewItems.Items.Add(menuItems);
            }

        }
    }
}
