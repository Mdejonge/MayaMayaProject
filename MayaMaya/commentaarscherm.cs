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
    public partial class commentaarscherm : Form
    {
        public commentaarscherm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString =
                ConfigurationManager
                .ConnectionStrings["MayaMayaDatabase"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string sql = string.Format("UPDATE ");
        }

        private void commentaarscherm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);
        }
    }
}
