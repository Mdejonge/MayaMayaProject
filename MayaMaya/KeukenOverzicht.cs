﻿using System;
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
    public partial class KeukenOverzicht : Form
    {
        public KeukenOverzicht()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form1 afrekeningscherm_salih = new Form1();
            afrekeningscherm_salih.Show();
        }
    }
}
