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



        private void button1_Click(object sender, EventArgs e)
        {
            commentaarscherm commentaar = new commentaarscherm();
            commentaar.Show();
        }

        public void button5_Click(object sender, EventArgs e)
        {

            string invoer = textBox1.Text;
            int invoer_getal = Int32.Parse(invoer);
            BedragBerekening.Items.Add("" + invoer_getal.ToString("C2"));
            double fooiEnEind = invoer_getal + total;
            BedragBerekening.Items.Add("" + fooiEnEind.ToString("C2"));

        }

        public void button3_Click(object sender, EventArgs e)
        {
            TabelProduct.Items.Clear();
            TabelPrijs.Items.Clear();
            BedragBerekening.Items.Clear();
            subtotal = 0;
            total = 0;
            TotaalBTW = 0;



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (total == 0)
            {
                string message = "You did not enter a server name. Cancel this operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    // Closes the parent form.

                    this.Close();

                }

                //errorscherm errornoinvoer = new errorscherm();
                //errornoinvoer.Show();
            }
            else
            {
                succesafgerondscherm successcherm = new succesafgerondscherm();
                successcherm.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabelProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BedragBerekening_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelPrijs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TabelPrijs_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
    

