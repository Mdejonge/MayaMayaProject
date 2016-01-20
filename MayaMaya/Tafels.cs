using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace MayaMaya
{
    class Tafels
    {
        public static int tafelnummer;


        public int tafelnummers { get; internal set; }
        public int tafelstatus { get; internal set; }

        public static int reserveering(int gekozenTafel,out int tafelstatus)
        {
            tafelstatus = 0;
            
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
                


                while (reader.Read())
                {
                    tafelstatus = (int)reader["Beschikbaarheid"];

                }

                
                    return tafelstatus;
                    
                    
                

                
               

            }

            return tafelstatus;


        }
        public static int reserveeringDeel2(int gekozenTafel)
        {
            int bezetcode = 2;
            int tafelstatus = 1;
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

            return tafelstatus;
        }



    }
}
