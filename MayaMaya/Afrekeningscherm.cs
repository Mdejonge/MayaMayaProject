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

        public struct Bestellingen
        {
            public string product;
            public double prijs;
        }
        const double BTW = 0.21; //21% BTW
        Bestellingen bestelling = new Bestellingen();
        static double subtotal;
        static double total;
        static double fooiEnEind;
        static double totaalexcl;
        static double totaalbtw;
        static int invoer_getal;
        static double prijsTotaal = 0;
        static double bestelID;
        public List<BesteldeItems>bestelItems = new List<BesteldeItems>();


        public Form1(int tafelnummer)
        {
            InitializeComponent();

            Tafels.tafelnummer = tafelnummer;

            getItems();
            toonItems();
            updatederekening();
        }

        public void updatederekening()
        {
            foreach(BesteldeItems items in bestelItems)
            {
                subtotal += items.prijs;
                totaalbtw += items.prijs / 100 * items.btw;
                prijsTotaal = items.bestelTotaal;
                bestelID = items.bestel_id;
            }

            totaalexcl = subtotal - totaalbtw;

            BedragBerekening.Items.Add(totaalexcl.ToString("C2"));
            BedragBerekening.Items.Add(totaalbtw.ToString("C2"));
            BedragBerekening.Items.Add(subtotal.ToString("C2"));
        }

        private void commentaarbutton_Click(object sender, EventArgs e) // Bij het drukken op de knop COMMENTAAR!
        {
            commentaarscherm commentaar = new commentaarscherm();
            commentaar.Show();
        }

        public void button5_Click(object sender, EventArgs e)  // Bij het drukken op de knop FOOI TOEVOEGEN!
        {
            Fooiberekening.Items.Clear();
            string invoer = fooiBox.Text;
            try {
                 invoer_getal = Int32.Parse(invoer);
            }
            catch

            {
                string message = "De ingevoerde gegevens kloppen niet \nvoer een geldig getal in.";
                string caption = "ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

            if (invoer_getal <= 0)
            {
                Fooiberekening.Items.Clear();
                ListViewAfrekenen.Items.Clear();
                BedragBerekening.Items.Clear();
                subtotal = 0;
                string message = "Grapjes, voer een normaal cijfer in!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    // Closes the parent form.
                    ListViewAfrekenen.Items.Clear();
                    BedragBerekening.Items.Clear();
                    Fooiberekening.Items.Clear();
                    fooiBox.Text = "";
                    subtotal = 0;
                    invoer_getal = 0;
                    fooiEnEind = 0;
                }

            }
            Fooiberekening.Items.Clear();                                   //Berekening FOOI!
            Fooiberekening.Items.Add("" + invoer_getal.ToString("C2"));
            fooiEnEind += invoer_getal + prijsTotaal;
            Fooiberekening.Items.Add("" + fooiEnEind.ToString("C2"));
            

        }


        private void afrondenbutton_Click(object sender, EventArgs e) // bij het drukken van AFREKENEN! 
        {
            int onbezetcode = 1;
            if (subtotal == 0)
            {
                string message = "U heeft niks ingevoerd, wilt u de proggama stoppen?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
   
            }

            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Selecteer een betaalwijze");
            }
            else
            {
                Methodes methode = new Methodes();
                SqlConnection conn;

                methode.ConnectDatabase(out conn);
                // connect to database
                string connString = ConfigurationManager
                    .ConnectionStrings["MayaMayaDatabase"]
                    .ConnectionString;
                conn = new SqlConnection(connString);
                conn.Open();
                string sql = string.Format("UPDATE Tafels SET beschikbaarheid= '{0}' WHERE tafelnummer={1}",  onbezetcode, Tafels.tafelnummer);
                SqlCommand command = new SqlCommand(sql, conn);
                int rowsAffected = command.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string betaalwijze = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                {
                    betaalwijze = "contant";
                }
                else
                {
                    betaalwijze = "pin";
                }

                methode.ConnectDatabase(out conn);
                string insert = string.Format("UPDATE Bestellingen SET BETAALD_BEDRAG='{0}', BETAALWIJZE='{1}', STATUS='1' WHERE BESTEL_ID='{2}'", subtotal, betaalwijze, bestelID, conn);
                SqlCommand update = new SqlCommand(insert, conn);
                update.ExecuteNonQuery();
                conn.Close();


                succesafgerondscherm successcherm = new succesafgerondscherm();
                successcherm.Show();

                ListViewAfrekenen.Items.Clear();
                BedragBerekening.Items.Clear();
                Fooiberekening.Items.Clear();
                fooiBox.Text = "";
                subtotal = 0;
                invoer_getal = 0;
                fooiEnEind = 0;

                this.Close();
            }

        }
        private void terugbuttonAS_Click_1(object sender, EventArgs e)  //Bij het drukken van de knop TERUG!
        {
            fooiBox.Text = "";
            subtotal = 0;
            invoer_getal = 0;
            fooiEnEind = 0;
            TafelOverzicht tafeloverzicht_koos = new TafelOverzicht();
            tafeloverzicht_koos.Show();
            this.Close();
            
        }

        public void getItems()
        {
            Methodes methode = new Methodes();
            SqlConnection conn;

            methode.ConnectDatabase(out conn);

            string sql = string.Format("SELECT Menu_Items.Item_ID, Menu_Items.ITEM_NAAM, Menu_Items.PRIJS, Menu_Items.BTW_HEFFING, Bestellingen.STATUS, Bestelling_Items.AANTAL, Bestellingen.BESTEL_ID, Bestellingen.BETAALWIJZE, Bestellingen.BESTELTOTAAL, Bestellingen.BETAALD_BEDRAG From Bestellingen INNER JOIN Bestelling_Items ON Bestellingen.BESTEL_ID=Bestelling_Items.BESTEL_ID INNER JOIN Menu_Items ON Bestelling_Items.ITEM_ID=Menu_Items.ITEM_ID WHERE TAFELNUMMER ={0} AND STATUS = 0", Tafels.tafelnummer, conn);
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bestelItems.Add(new BesteldeItems(reader.GetInt32(0), reader.GetString(1), reader.GetDouble(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7), reader.GetDouble(8), reader.GetDouble(9)));
            }
        }

        public void toonItems() 
        {

            foreach (BesteldeItems item in bestelItems)
            {
                double itemPrijsTotaal = item.aantal * item.prijs;
                ListViewItem items = new ListViewItem(item.naam);
                items.SubItems.Add(item.aantal.ToString());
                items.SubItems.Add(itemPrijsTotaal.ToString());
                ListViewAfrekenen.Items.Add(items);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);

            
        }
    }
}
    

