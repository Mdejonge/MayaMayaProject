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

            Methodes methode = new Methodes();

            List<int> LunchItemID = new List<int>();
            List<string> LunchItemNaam = new List<string>();
            List<int> LunchItemVoorraad = new List<int>();
            List<float> LunchItemPrijs = new List<float>();

            methode.getLunchItems(out LunchItemID, out LunchItemNaam, out LunchItemVoorraad, out LunchItemPrijs);


            foreach (string value in LunchItemNaam)
            {
                ListViewItem Lunch = new ListViewItem(value);

                foreach (int voorraad in LunchItemVoorraad)
                {
                    Lunch.SubItems.Add(voorraad.ToString());

                    foreach(float prijs in LunchItemPrijs)
                    {
                        Lunch.SubItems.Add(prijs.ToString());
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
                string prijsString = item.SubItems[2].Text.ToString().Trim();
                float prijsFloat = Single.Parse(prijsString);
                totaalPrijs = totaalPrijs + prijsFloat;

                ListViewItem bestellijst = new ListViewItem(item.Text);
                bestellijst.SubItems.Add(item.SubItems[2].Text);
                ListViewBestellijst.Items.Add(bestellijst);

            }


            lbl_TotaalPrijs.Text = Convert.ToString(totaalPrijs);          
        }
    }
}
