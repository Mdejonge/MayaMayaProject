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
        public Bestelling()
        {
            InitializeComponent();

            Methodes methode = new Methodes();

            List<string> LunchItemNaam = new List<string>();
            List<int> LunchItemVoorraad = new List<int>();

            methode.getLunchItems(out LunchItemNaam, out LunchItemVoorraad);


            foreach (string value in LunchItemNaam)
            {
                ListViewItem Lunch = new ListViewItem(value);

                foreach (int voorraad in LunchItemVoorraad)
                {
                    Lunch.SubItems.Add(voorraad.ToString());
                }

                ListViewLunch.Items.Add(Lunch);
            }


        }

        private void ListViewLunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemAantal = 0;
            ListView.SelectedListViewItemCollection Lunch = this.ListViewLunch.SelectedItems;

            foreach(ListViewItem item in Lunch)
            {
                if(ListViewBestellijst.Items.Contains(item))
                {
                    MessageBox.Show("Bestaat al");
                }
                else
                {
                    ListViewItem Bestellijst = new ListViewItem(item.Text);
                    Bestellijst.SubItems.Add(itemAantal.ToString());
                    ListViewBestellijst.Items.Add(Bestellijst);
                }
            }
        }
    }
}
