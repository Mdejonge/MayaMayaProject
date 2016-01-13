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
    public partial class TafelOverzicht : Form
    {
        public TafelOverzicht()
        {
            InitializeComponent();



            Methodes methode = new Methodes();
            SqlConnection conn;

            methode.ConnectDatabase(out conn);
            //Connect to database
            string connString = ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("select * from Tafels ", conn);
            SqlDataReader reader = command.ExecuteReader();
            int tafelstatus = 2;
            int tafelnummer = 1;

            while (reader.Read())
            {
                tafelstatus = (int)reader["Beschikbaarheid"];
                tafelnummer = (int)reader["TAFELNUMMER"];



                switch(tafelnummer)
                {

                    case 1:
                    if (tafelstatus == 2)//bezet
                    {
                        Tafel1.BackColor = Color.Blue;
                        TafelLabel1.BackColor = Color.Blue;
                        TafelLabel1.Text = "Bezet";
                    }
                    else if (tafelstatus == 3)//in verwerking
                    {
                        Tafel1.BackColor = Color.Red;
                        TafelLabel1.BackColor = Color.Red;
                        TafelLabel1.Text = "Verwerking";

                        }
                    else if (tafelstatus == 4)//klaar voor servering
                    {
                        Tafel1.BackColor = Color.Green;
                        TafelLabel1.BackColor = Color.Green;
                        TafelLabel1.Text = "Gereed";

                        }
                    else  //vrij (1 is vrij)
                    {
                        Tafel1.BackColor = Color.Yellow;
                        TafelLabel1.BackColor = Color.Yellow;
                        TafelLabel1.Text = "Vrij";
                        }
                        break;

                    case 2:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel2.BackColor = Color.Blue;
                            TafelLabel2.BackColor = Color.Blue;
                            TafelLabel2.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel2.BackColor = Color.Red;
                            TafelLabel2.BackColor = Color.Red;
                            TafelLabel2.Text = "Verwerking";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel2.BackColor = Color.Green;
                            TafelLabel2.BackColor = Color.Green;
                            TafelLabel2.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel2.BackColor = Color.Yellow;
                            TafelLabel2.BackColor = Color.Yellow;
                            TafelLabel2.Text = "Vrij";
                        }
                        break;

                    case 3:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel3.BackColor = Color.Blue;
                            TafelLabel3.BackColor = Color.Blue;
                            TafelLabel3.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel3.BackColor = Color.Red;
                            TafelLabel3.BackColor = Color.Red;
                            TafelLabel3.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel3.BackColor = Color.Green;
                            TafelLabel3.BackColor = Color.Green;
                            TafelLabel3.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel3.BackColor = Color.Yellow;
                            TafelLabel3.BackColor = Color.Yellow;
                            TafelLabel3.Text = "Vrij";
                        }
                        break;

                    case 4:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel4.BackColor = Color.Blue;
                            TafelLabel4.BackColor = Color.Blue;
                            TafelLabel4.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel4.BackColor = Color.Red;
                            TafelLabel4.BackColor = Color.Red;
                            TafelLabel4.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel4.BackColor = Color.Green;
                            TafelLabel4.BackColor = Color.Green;
                            TafelLabel4.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel4.BackColor = Color.Yellow;
                            TafelLabel4.BackColor = Color.Yellow;
                            TafelLabel4.Text = "Vrij";
                        }
                        break;
                    case 5:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel5.BackColor = Color.Blue;
                            TafelLabel5.BackColor = Color.Blue;
                            TafelLabel5.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel5.BackColor = Color.Red;
                            TafelLabel5.BackColor = Color.Red;
                            TafelLabel5.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel5.BackColor = Color.Green;
                            TafelLabel5.BackColor = Color.Green;
                            TafelLabel5.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel5.BackColor = Color.Yellow;
                            TafelLabel5.BackColor = Color.Yellow;
                            TafelLabel5.Text = "Vrij";
                        }
                        break;

                    case 6:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel6.BackColor = Color.Blue;
                            TafelLabel6.BackColor = Color.Blue;
                            TafelLabel6.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel6.BackColor = Color.Red;
                            TafelLabel6.BackColor = Color.Red;
                            TafelLabel6.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel6.BackColor = Color.Green;
                            TafelLabel6.BackColor = Color.Green;
                            TafelLabel6.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel6.BackColor = Color.Yellow;
                            TafelLabel6.BackColor = Color.Yellow;
                            TafelLabel6.Text = "Vrij";
                        }
                        break;

                    case 7:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel7.BackColor = Color.Blue;
                            TafelLabel7.BackColor = Color.Blue;
                            TafelLabel7.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel7.BackColor = Color.Red;
                            TafelLabel7.BackColor = Color.Red;
                            TafelLabel7.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel7.BackColor = Color.Green;
                            TafelLabel7.BackColor = Color.Green;
                            TafelLabel7.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel7.BackColor = Color.Yellow;
                            TafelLabel7.BackColor = Color.Yellow;
                            TafelLabel7.Text = "Vrij";
                        }
                        break;

                    case 8:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel8.BackColor = Color.Blue;
                            TafelLabel8.BackColor = Color.Blue;
                            TafelLabel8.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel8.BackColor = Color.Red;
                            TafelLabel8.BackColor = Color.Red;
                            TafelLabel8.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel8.BackColor = Color.Green;
                            TafelLabel8.BackColor = Color.Green;
                            TafelLabel8.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel8.BackColor = Color.Yellow;
                            TafelLabel8.BackColor = Color.Yellow;
                            TafelLabel8.Text = "Vrij";
                        }
                        break;

                    case 9:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel9.BackColor = Color.Blue;
                            TafelLabel9.BackColor = Color.Blue;
                            TafelLabel9.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel9.BackColor = Color.Red;
                            TafelLabel9.BackColor = Color.Red;
                            TafelLabel9.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel9.BackColor = Color.Green;
                            TafelLabel9.BackColor = Color.Green;
                            TafelLabel9.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel9.BackColor = Color.Yellow;
                            TafelLabel9.BackColor = Color.Yellow;
                            TafelLabel9.Text = "Vrij";
                        }
                        break;

                    case 10:
                        if (tafelstatus == 2)//bezet
                        {
                            Tafel10.BackColor = Color.Blue;
                            TafelLabel10.BackColor = Color.Blue;
                            TafelLabel10.Text = "Bezet";
                        }
                        else if (tafelstatus == 3)//in verwerking
                        {
                            Tafel10.BackColor = Color.Red;
                            TafelLabel10.BackColor = Color.Red;
                            TafelLabel10.Text = "Bezig";
                        }
                        else if (tafelstatus == 4)//klaar voor reservering
                        {
                            Tafel10.BackColor = Color.Green;
                            TafelLabel10.BackColor = Color.Green;
                            TafelLabel10.Text = "Gereed";
                        }
                        else  //vrij (1 is vrij)
                        {
                            Tafel10.BackColor = Color.Yellow;
                            TafelLabel10.BackColor = Color.Yellow;
                            TafelLabel10.Text = "Vrij";
                        }
                        break;
                }





            }
            conn.Close();



        }

        private void TafelLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Tafel1_Click(object sender, EventArgs e)
        {
            
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(1);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string message = "Geel: Lege tafel \nRood: Order in verwerking \nBlauw: Tafel bezet \nGroen: Bestelling gereed voor serveering";

            string caption = "Hulp";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        private void ReserveerButton_Click(object sender, EventArgs e)
        {
            Tafelreserveren reserveerform = new Tafelreserveren();
            reserveerform.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginScherm loginform = new LoginScherm();
            loginform.Show();
            this.Close();
        }

        private void Tafel2_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(2);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel3_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(3);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel4_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(4);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel5_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(5);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel6_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(6);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel7_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(7);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel8_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(8);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void TafelLabel9_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(9);

            TafelGeselecteerd.Show();

            this.Hide();
        }

        private void Tafel10_Click(object sender, EventArgs e)
        {
            Tafel_Geselecteerd_Form TafelGeselecteerd = new Tafel_Geselecteerd_Form(10);

            TafelGeselecteerd.Show();

            this.Hide();
        }
    }
}
