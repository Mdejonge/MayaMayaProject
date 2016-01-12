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
    public partial class Tafelreserveren : Form
    {
        public Tafelreserveren()
        {
            InitializeComponent();
            TafelSelectBox.Items.Add("Tafel1");
            TafelSelectBox.Items.Add("Tafel2");
            TafelSelectBox.Items.Add("Tafel3");
            TafelSelectBox.Items.Add("Tafel4");
            TafelSelectBox.Items.Add("Tafel5");
            TafelSelectBox.Items.Add("Tafel6");
            TafelSelectBox.Items.Add("Tafel7");
            TafelSelectBox.Items.Add("Tafel8");
            TafelSelectBox.Items.Add("Tafel9");
            TafelSelectBox.Items.Add("Tafel10");
        }

        private void TafelSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reserveerTafelButton_Click(object sender, EventArgs e)
        {
            string selected = TafelSelectBox.SelectedItem.ToString();
            string message = selected+"is gereserveerd";
            string caption = "Reservering";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            switch (selected)
            {
                case "Tafel1":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel2":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel3":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel4":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel5":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel6":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel7":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel8":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel9":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

                case "Tafel10":
                    result = MessageBox.Show(message, caption, buttons);
                    break;

            }
        }
    }
}

