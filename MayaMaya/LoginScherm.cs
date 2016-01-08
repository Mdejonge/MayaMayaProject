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
            string username = textboxNaam.Text;
            string password = textboxWw.Text;


            Login berekening = new Login();
            if (berekening.wachtwoordcorrect(username, password))
            {
                TafelOverzicht settingsForm = new TafelOverzicht();
                settingsForm.Show();

                this.Hide();

            }
            else
            {
                NaamLabel.ForeColor = Color.Red;
                WwLabel.ForeColor = Color.Red;
                string message = "Wachtwoord is incorrect";
                string caption = "ERROR";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                NaamLabel.ForeColor = Color.Black;
                WwLabel.ForeColor = Color.Black;

            }
        }
    }
}
