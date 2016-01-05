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
        public static float totaalPrijs;
        public Bestelling()
        {
            InitializeComponent();

            Bestellingen bestelling = new Bestellingen();

            List<int> LunchItemID = new List<int>();
            List<string> LunchItemNaam = new List<string>();
            List<int> LunchItemVoorraad = new List<int>();
            List<float> LunchItemPrijs = new List<float>();

            bestelling.getLunchItems(out LunchItemID, out LunchItemNaam, out LunchItemVoorraad, out LunchItemPrijs);


            foreach (string value in LunchItemNaam)
            {
                ListViewItem Lunch = new ListViewItem(value);

                foreach (int voorraad in LunchItemVoorraad)
                {
                    Lunch.SubItems.Add(voorraad.ToString());

                    foreach(float prijs in LunchItemPrijs)
                    {
                        Lunch.SubItems.Add(prijs.ToString());

                        foreach(int id in LunchItemID)
                        {
                            Lunch.SubItems.Add(id.ToString());
                        }
                    }
                }

                ListViewLunch.Items.Add(Lunch);
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
    }
}
