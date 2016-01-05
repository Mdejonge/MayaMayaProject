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
        public Tafel_Geselecteerd_Form()
        {
            InitializeComponent();
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            Bestelling Bestelling = new Bestelling();

            Bestelling.Show();

            this.Hide();
        }
    }
}
