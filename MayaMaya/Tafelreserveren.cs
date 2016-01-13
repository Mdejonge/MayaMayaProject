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


            string selected = "";
            try
            {
                selected = TafelSelectBox.SelectedItem.ToString();
            }
            catch 

            {
                string errormessage = "je moet wel een tafel aanklikken als je op reserveren drukt";
                string errorcaption = "ERROR";
                MessageBoxButtons errorbuttons = MessageBoxButtons.OK;
                DialogResult errorresult;
                errorresult = MessageBox.Show(errormessage, errorcaption, errorbuttons);
            }

            string message = selected + " is gereserveerd";
            string caption = "Reservering";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            int gekozenTafel = 0;
            int bezetcode = 2;
            switch (selected)
            {
                case "Tafel1":
                    gekozenTafel = 1;
                    break;


                case "Tafel2":
                    gekozenTafel = 2;
                    break;


                case "Tafel3":
                    gekozenTafel = 3;
                    break;


                case "Tafel4":
                    gekozenTafel = 4;
                    break;


                case "Tafel5":
                    gekozenTafel = 5;
                    break;


                case "Tafel6":
                    gekozenTafel = 6;
                    break;


                case "Tafel7":
                    gekozenTafel = 7;
                    break;


                case "Tafel8":
                    gekozenTafel = 8;
                    break;


                case "Tafel9":
                    gekozenTafel = 9;
                    break;


                case "Tafel10":
                    gekozenTafel = 10;
                    break;


                default:
                    gekozenTafel = 0;
                    break;


            }
            if (gekozenTafel != 0)
            {
                Methodes methode1 = new Methodes();
                SqlConnection conn1;

                methode1.ConnectDatabase(out conn1);
                //Connect to database
                string connString1 = ConfigurationManager
                    .ConnectionStrings["MayaMayaDatabase"]
                    .ConnectionString;
                conn1 = new SqlConnection(connString1);
                conn1.Open();
                string sqlcom1 = string.Format("SELECT Beschikbaarheid FROM Tafels WHERE tafelnummer={0}", gekozenTafel);

                SqlCommand command1 = new SqlCommand(sqlcom1, conn1);
                SqlDataReader reader = command1.ExecuteReader();
                int tafelstatus = 1;


                while (reader.Read())
                {
                    tafelstatus = (int)reader["Beschikbaarheid"];

                }
                if (tafelstatus != 1)
                {
                    message = selected + " kan niet worden gereserveert\n er zitten hier al mensen";
                }

                else
                {
                    message = selected + " is gereserveerd";




                    Methodes methode = new Methodes();
                    SqlConnection conn;

                    methode.ConnectDatabase(out conn);
                    //Connect to database
                    string connString = ConfigurationManager
                        .ConnectionStrings["MayaMayaDatabase"]
                        .ConnectionString;
                    conn = new SqlConnection(connString);
                    conn.Open();
                    string sql = string.Format("UPDATE Tafels SET beschikbaarheid='{0}' WHERE tafelnummer={1}", bezetcode, gekozenTafel);


                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();





                }
                result = MessageBox.Show(message, caption, buttons);

            }




        }

        private void terugButton_Click(object sender, EventArgs e)
        {
            TafelOverzicht settingsForm = new TafelOverzicht();
            settingsForm.Show();

            this.Hide();
        }

        private void Tafelreserveren_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);
        }
    }
}

