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
    public partial class succesafgerondscherm : Form
    {
        public succesafgerondscherm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TafelOverzicht tafeloverzicht_koos = new TafelOverzicht();
            tafeloverzicht_koos.Show();
            this.Close();
        }
    }
}
