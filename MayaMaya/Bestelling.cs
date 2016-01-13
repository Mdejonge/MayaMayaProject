using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayaMaya
{
    public partial class Bestelling : Form
    {
        public List<Item> bestelling = new List<Item>();
        public string Soortpublic;
        public static float totaalPrijs;
        public int tafelnummer;

        Bestellingen tijdelijkeBestelling = new Bestellingen();
        public Bestelling(string Soort, int tafelnummer)
        {
            InitializeComponent();
            Soortpublic = Soort;

            Bestellingen producten = new Bestellingen();

            lbl_Tafelnummer.Text = "Tafel " + tafelnummer.ToString();

            //Voegt Items aan juiste ViewList toe
            foreach (Item item in producten.Items)
            {
                if (item.kaart_id == 1)
                {
                    ListViewItem Lunch = new ListViewItem(item.naam);
                    Lunch.SubItems.Add(item.Voorraad.ToString());
                    Lunch.SubItems.Add(item.Prijs.ToString());
                    Lunch.SubItems.Add(item.id.ToString());
                    Lunch.SubItems.Add("1");
                    ListViewLunch.Items.Add(Lunch);
                }
                else if (item.kaart_id == 2)
                {
                    ListViewItem Diner = new ListViewItem(item.naam);
                    Diner.SubItems.Add(item.Voorraad.ToString());
                    Diner.SubItems.Add(item.Prijs.ToString());
                    Diner.SubItems.Add(item.id.ToString());
                    ListViewDiner.Items.Add(Diner);
                }
                else if (item.kaart_id == 3)
                {
                    ListViewItem Dranken = new ListViewItem(item.naam);
                    Dranken.SubItems.Add(item.Voorraad.ToString());
                    Dranken.SubItems.Add(item.Prijs.ToString());
                    Dranken.SubItems.Add(item.id.ToString());
                    ListViewDranken.Items.Add(Dranken);
                }
            }
        }

        //Klik op item in List View Lunch -- voegt item toe aan bestellijst
        private void ListViewLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Lunch = this.ListViewLunch.SelectedItems;

            foreach (ListViewItem item in Lunch)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);

                tijdelijkeBestelling.addItem(itemNummer);

                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                bestellijst.SubItems.Add(item.SubItems[3]);
                ListViewBestellijst.Items.Add(bestellijst);
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);
        }

        //Klik op item in List View Bestellijst -- verwijderd item van bestellijst
        private void ListViewBestellijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewBestellijst.SelectedItems)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);

                //Verwijderd item
                tijdelijkeBestelling.removeItem(itemNummer);
                ListViewBestellijst.Items.Remove(item);

                //Berekent totaalprijs - van verdwijderd item
                string prijsString = item.SubItems[1].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs - prijsFloat;
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);
        }

        //Klik op item  in List View Diner -- voegt item toe aan bestellijst
        private void ListViewDiner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Diner = this.ListViewDiner.SelectedItems;

            foreach (ListViewItem item in Diner)
            {
                //Voegt item + aantal aan dictionary
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkeBestelling.addItem(itemNummer);

                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                ListViewBestellijst.Items.Add(bestellijst);
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);

        }

        //Klik op item in List View Dranken -- voegt item toe aan bestellijst
        private void ListViewDranken_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Dranken = this.ListViewDranken.SelectedItems;

            Bestellingen tijdelijk = new Bestellingen();

            foreach (ListViewItem item in Dranken)
            {
                //Voegt item + aantal aan dictionary
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkeBestelling.addItem(itemNummer);

                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                ListViewBestellijst.Items.Add(bestellijst);
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);

        }

        //Form bestelling laden en selecteerd juiste tab aan de hand van keuze vorig form
        private void Bestelling_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);

            DateTime LunchDate = new DateTime(2015, 01, 01, 12, 00, 00);
            DateTime DinerDate = new DateTime(2015, 01, 01, 18, 00, 00);
            DateTime Nu = new DateTime(2015, 01, 01, 14, 00, 00);
            if (DateTime.Now >= DinerDate)
            {
                (tabControl1.TabPages[0] as Control).Enabled = false;
            }
            else
            {
                (tabControl1.TabPages[1] as Control).Enabled = false;
            }
            switch (this.Soortpublic)
            {
                case "Lunch":
                    tabControl1.SelectTab(Lunch);
                    break;
                case "Diner":
                    tabControl1.SelectTab(Diner);
                    break;
                case "Dranken":
                    tabControl1.SelectTab(Dranken);
                    break;
                default:
                    break;
            }
        }

        //Knop terug, totaalprijs reset, opent form Tafel Geselecteerd
        private void lbl_Terug_Click(object sender, EventArgs e)
        {
            totaalPrijs = 0;
            Tafel_Geselecteerd_Form tafelGeselecteerd = new Tafel_Geselecteerd_Form(Tafels.tafelnummer);

            tafelGeselecteerd.Show();
            this.Hide();
        }

        //Slaat de bestelling op in de database
        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            tijdelijkeBestelling.SaveBestelling();
            Form1 afrekenscherm = new Form1(Tafels.tafelnummer);

            afrekenscherm.Show();
            this.Hide();
        }
    }
}
