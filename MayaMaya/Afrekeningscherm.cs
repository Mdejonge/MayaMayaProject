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
        string Afrekening;
        static double subtotal;
        static double total;
        static double TotaalBTW;
        static double fooiEnEind;
        static int invoer_getal;



        public Form1()
        {
            InitializeComponent();
        }


        private void Databinnenhallen(string custOrder)
        {
            bestelling.product = custOrder.Split('€')[0];
            bestelling.prijs = Convert.ToDouble(custOrder.Split('€')[1]);
            TabelPrijs.Items.Add(bestelling.prijs);
            Afrekening = bestelling.product;
            updatederekening();
        }

        public void updatederekening()
        {
            subtotal += bestelling.prijs;
            total += bestelling.prijs + (bestelling.prijs * BTW);
            TotaalBTW += bestelling.prijs * BTW;
            BedragBerekening.Items.Clear();
            TabelProduct.Items.AddRange(Afrekening.Split('\n'));
            BedragBerekening.Items.Add("" + subtotal.ToString("C2"));
            BedragBerekening.Items.Add("" + TotaalBTW.ToString("C2"));
            BedragBerekening.Items.Add("" + total.ToString("C2"));

        }

        private void changingDropdown(object gemaaktekeuze, EventArgs e)
        {
            if (gemaaktekeuze == cmbDranken)
                Databinnenhallen(cmbDranken.SelectedItem.ToString());
            else if (gemaaktekeuze == cmbDiner)
                Databinnenhallen(cmbDiner.SelectedItem.ToString());
            else if (gemaaktekeuze == cmbLunch)
                Databinnenhallen(cmbLunch.SelectedItem.ToString());
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
            catch(Exception exp)

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
                TabelProduct.Items.Clear();
                TabelPrijs.Items.Clear();
                BedragBerekening.Items.Clear();
                subtotal = 0;
                total = 0;
                TotaalBTW = 0;
                string message = "Grapjes, voer een normaal cijfer in!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    // Closes the parent form.
                    TabelProduct.Items.Clear();
                    TabelPrijs.Items.Clear();
                    BedragBerekening.Items.Clear();
                    Fooiberekening.Items.Clear();
                    fooiBox.Text = "";
                    subtotal = 0;
                    total = 0;
                    TotaalBTW = 0;
                    invoer_getal = 0;
                    fooiEnEind = 0;
                }

            }
            Fooiberekening.Items.Clear();                                   //Berekening FOOI!
            Fooiberekening.Items.Add("" + invoer_getal.ToString("C2"));
            fooiEnEind += invoer_getal + total;
            Fooiberekening.Items.Add("" + fooiEnEind.ToString("C2"));
            

        }

        public void wisitemsbutton_Click(object sender, EventArgs e) // Bij het drukken van CLEAR!
        {
            TabelProduct.Items.Clear();
            TabelPrijs.Items.Clear();
            BedragBerekening.Items.Clear();
            Fooiberekening.Items.Clear();
            fooiBox.Text = "";
            subtotal = 0;
            total = 0;
            TotaalBTW = 0;
            invoer_getal = 0;
            fooiEnEind = 0;



        }

        private void afrondenbutton_Click(object sender, EventArgs e) // bij het drukken van AFREKENEN! 
        {
            int onbezetcode = 1;
            if (total == 0)
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

                succesafgerondscherm successcherm = new succesafgerondscherm();
                successcherm.Show();

                TabelProduct.Items.Clear();
                TabelPrijs.Items.Clear();
                BedragBerekening.Items.Clear();
                Fooiberekening.Items.Clear();
                fooiBox.Text = "";
                subtotal = 0;
                total = 0;
                TotaalBTW = 0;
                invoer_getal = 0;
                fooiEnEind = 0;

                this.Close();
            }

        }
        private void terugbuttonAS_Click_1(object sender, EventArgs e)  //Bij het drukken van de knop TERUG!
        {
            TafelOverzicht tafeloverzicht_koos = new TafelOverzicht();
            tafeloverzicht_koos.Show();
            this.Close();
        }
    }
}
    

