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
    public partial class Tafel_Geselecteerd_Form : Form
    {

        public Tafel_Geselecteerd_Form(int tafelnummer)
        {
            InitializeComponent();

            Tafels.tafelnummer = tafelnummer;

            lbl_Tafelnaam.Text = "Tafel " + tafelnummer.ToString();
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            DateTime Lunch = new DateTime(2015, 01, 01, 12, 00, 00);
            DateTime Diner = new DateTime(2015, 01, 01, 18, 00, 00);
            DateTime Nu = new DateTime(2015, 01, 01, 14, 00, 00);
            if (DateTime.Now >= Lunch && DateTime.Now <= Diner) {
                Bestelling Bestelling = new Bestelling("Lunch", Tafels.tafelnummer);

                Bestelling.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Lunch kan alleen besteld worden tussen 12:00 en 18:00");
            }
        }

        private void btn_Terug_Click(object sender, EventArgs e)
        {
            TafelOverzicht settingsForm = new TafelOverzicht();
            settingsForm.Show();
            this.Hide();
        }

        private void btn_Diner_Click(object sender, EventArgs e)
        {
            DateTime Lunch = new DateTime(2015, 01, 01, 12, 00, 00);
            DateTime Diner = new DateTime(2015, 01, 01, 18, 00, 00);
            DateTime Nu = new DateTime(2015, 01, 01, 14, 00, 00);
            if (DateTime.Now >= Diner)
            {
                Bestelling Bestelling = new Bestelling("Diner", Tafels.tafelnummer);
                Bestelling.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Diner kan alleen besteld worden na 18:00");
            }
        }

        private void btn_Dranken_Click(object sender, EventArgs e)
        {
            Bestelling Bestelling = new Bestelling("Dranken", Tafels.tafelnummer);
            Bestelling.Show();
            this.Hide();
        }

        private void Tafel_Geselecteerd_Form_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);
        }
    }
}
