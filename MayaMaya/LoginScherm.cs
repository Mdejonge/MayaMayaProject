using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    public partial class LoginScherm : Form
    {
        public LoginScherm()
        {
            InitializeComponent();


        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            string password = textboxWw.Text;


            Login berekening = new Login();
            if (berekening.wachtwoordcorrect(password)== "1" ) 
            {
                // naar Tafeloverzichtform
                TafelOverzicht settingsForm = new TafelOverzicht();
                settingsForm.Show();

                this.Hide();

            }
            else if (berekening.wachtwoordcorrect(password) == "2")
            {
                //naar keukenoverzichtform
                BarOverzicht settingsForm = new BarOverzicht();
                settingsForm.Show();

                this.Hide();

            }
            else if (berekening.wachtwoordcorrect(password) == "3")
            {
                //naar baroverzichtform
                KeukenOverzicht settingsForm = new KeukenOverzicht();
                settingsForm.Show();

                this.Hide();

            }

            else
            {
                
                WwLabel.ForeColor = Color.Red;
                string message = "Wachtwoord is incorrect";
                string caption = "ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                
                WwLabel.ForeColor = Color.Black;

            }
        }

        private void LoginScherm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);
        }
    }
}
