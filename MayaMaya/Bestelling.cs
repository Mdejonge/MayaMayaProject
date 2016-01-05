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
        public string Soortpublic;
        public static float totaalPrijs;
        public Bestelling(string Soort)
        {
            InitializeComponent();
            Soortpublic = Soort;

            Bestellingen bestelling = new Bestellingen();

            //Lunch Item
            List<int> LunchItemID = new List<int>();
            List<string> LunchItemNaam = new List<string>();
            List<int> LunchItemVoorraad = new List<int>();
            List<float> LunchItemPrijs = new List<float>();

            //Diner Item
            List<int> DinerItemID = new List<int>();
            List<string> DinerItemNaam = new List<string>();
            List<int> DinerItemVoorraad = new List<int>();
            List<float> DinerItemPrijs = new List<float>();

            //Dranken Item
            List<int> DrankenItemID = new List<int>();
            List<string> DrankenItemNaam = new List<string>();
            List<int> DrankenItemVoorraad = new List<int>();
            List<float> DrankenItemPrijs = new List<float>();

            bestelling.getLunchItems(out LunchItemID, out LunchItemNaam, out LunchItemVoorraad, out LunchItemPrijs);
            bestelling.getDinerItems(out DinerItemID, out DinerItemNaam, out DinerItemVoorraad, out DinerItemPrijs);
            bestelling.getDrankenItems(out DrankenItemID, out DrankenItemNaam, out DrankenItemVoorraad, out DrankenItemPrijs);

            //Voegt Lunch item toe aan ListViewLunch
            foreach (string value in LunchItemNaam)
            {
                ListViewItem Lunch = new ListViewItem(value);

                foreach (int voorraad in LunchItemVoorraad)
                {
                    Lunch.SubItems.Add(voorraad.ToString());

                    foreach (float prijs in LunchItemPrijs)
                    {
                        Lunch.SubItems.Add(prijs.ToString());

                        foreach (int id in LunchItemID)
                        {
                            Lunch.SubItems.Add(id.ToString());
                        }
                    }
                }

                ListViewLunch.Items.Add(Lunch);
            }

            //Voegt Diner item toe aan ListViewDiner
            foreach (string value in DinerItemNaam)
            {
                ListViewItem Diner = new ListViewItem(value);

                foreach (int voorraad in DinerItemVoorraad)
                {
                    Diner.SubItems.Add(voorraad.ToString());

                    foreach (float prijs in DinerItemPrijs)
                    {
                        Diner.SubItems.Add(prijs.ToString());

                        foreach (int id in DinerItemID)
                        {
                            Diner.SubItems.Add(id.ToString());
                        }
                    }
                }

                ListViewDiner.Items.Add(Diner);
            }

            //Voegt Dranken item toe aan ListViewDranken
            foreach (string value in DrankenItemNaam)
            {
                ListViewItem Dranken = new ListViewItem(value);

                foreach (int voorraad in DrankenItemVoorraad)
                {
                    Dranken.SubItems.Add(voorraad.ToString());

                    foreach (float prijs in DinerItemPrijs)
                    {
                        Dranken.SubItems.Add(prijs.ToString());

                        foreach (int id in DinerItemID)
                        {
                            Dranken.SubItems.Add(id.ToString());
                        }
                    }
                }

                ListViewDranken.Items.Add(Dranken);
            }


        }

        private void ListViewLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Lunch = this.ListViewLunch.SelectedItems;

            foreach(ListViewItem item in Lunch)
            {
                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                bestellijst.SubItems.Add(item.SubItems[3]);
                ListViewBestellijst.Items.Add(bestellijst);


                //DIT IS ITEM ID -- item.SubItems[3]
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);          
        }

        private void ListViewBestellijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewBestellijst.SelectedItems)
            {
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
                //Berekent totaalprijs
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                //Voegt producten toe aan bestellijst
                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2]);
                bestellijst.SubItems.Add(item.SubItems[3]);
                ListViewBestellijst.Items.Add(bestellijst);


                //DIT IS ITEM ID -- item.SubItems[3]
            }
            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);

        }

        private void ListViewDranken_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection Dranken = this.ListViewDranken.SelectedItems;

            foreach(ListViewItem item in Dranken)
            {
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
    }
}
