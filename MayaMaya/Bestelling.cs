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
        public int aantal;

        Bestellingen tijdelijkebestelling = new Bestellingen();
        public Bestelling(string Soort, int tafelnummer)
        {
            InitializeComponent();
            Soortpublic = Soort;

            Bestellingen producten = new Bestellingen();

            lbl_Tafelnummer.Text = "Tafel " + tafelnummer.ToString();

            //Voegt Items aan juiste ViewList toe
            foreach (Item item in producten.Items)
            {
                if(item.kaart_id == 1)
                {
                    ListViewItem Lunch = new ListViewItem(item.naam);
                    Lunch.SubItems.Add(item.Voorraad.ToString());
                    Lunch.SubItems.Add(item.Prijs.ToString());
                    Lunch.SubItems.Add(item.id.ToString());
                    Lunch.SubItems.Add("1");
                    ListViewLunch.Items.Add(Lunch);
                } else if (item.kaart_id == 2)
                {
                    ListViewItem Diner = new ListViewItem(item.naam);
                    Diner.SubItems.Add(item.Voorraad.ToString());
                    Diner.SubItems.Add(item.Prijs.ToString());
                    Diner.SubItems.Add(item.id.ToString());
                    ListViewDiner.Items.Add(Diner);
                }
                else if(item.kaart_id == 3)
                {
                    ListViewItem Dranken = new ListViewItem(item.naam);
                    Dranken.SubItems.Add(item.Voorraad.ToString());
                    Dranken.SubItems.Add(item.Prijs.ToString());
                    Dranken.SubItems.Add(item.id.ToString());
                    ListViewDranken.Items.Add(Dranken);
                }
            }
        }

        private void ListViewLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Lunch = this.ListViewLunch.SelectedItems;

            foreach (ListViewItem item in Lunch)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkebestelling.addItem(itemNummer);

                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                bestellijst.SubItems.Add(aantal.ToString());
                bestellijst.SubItems.Add(itemNummer.ToString());

                ListViewBestellijst.Items.Add(bestellijst);

            }

            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);          
        }

        private void ListViewBestellijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewBestellijst.SelectedItems)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkebestelling.removeItem(itemNummer);
                //Verwijderd item
                ListViewBestellijst.Items.Remove(item);

                //Berekent totaalprijs - van verdwijderd item
                string prijsString = item.SubItems[1].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs - prijsFloat;

                //DIT IS ITEM ID -- item.SubItems[2]
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);
        }

        private void ListViewDiner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Diner = this.ListViewDiner.SelectedItems;

            foreach (ListViewItem item in Diner)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkebestelling.addItem(itemNummer);
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

        private void ListViewDranken_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Dranken = this.ListViewDranken.SelectedItems;

            Bestellingen tijdelijk = new Bestellingen();

            foreach (ListViewItem item in Dranken)
            {
                int itemNummer = Convert.ToInt32(item.SubItems[3].Text);
                tijdelijkebestelling.addItem(itemNummer);
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

        private void Bestelling_Load(object sender, EventArgs e)
        {
            switch(this.Soortpublic)
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

        private void lbl_Terug_Click(object sender, EventArgs e)
        {
            totaalPrijs = 0;
            Tafel_Geselecteerd_Form tafelGeselecteerd = new Tafel_Geselecteerd_Form(Tafels.tafelnummer);

            tafelGeselecteerd.Show();

            this.Hide();
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            tijdelijkebestelling.SaveBestelling();
        }
    }
}
