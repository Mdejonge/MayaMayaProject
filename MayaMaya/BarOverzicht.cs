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
    public partial class BarOverzicht : Form
    {
        public BarOverzicht()
        {
            InitializeComponent();
        }

        private void BarOverzicht_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 250, 240);
        }
    }
}
