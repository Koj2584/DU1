using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int penize = 10000;

        private void button34_Click(object sender, EventArgs e)
        {
            int policko = Int32.Parse(((Button)sender).Text);
            label2.Text = "Vsadil jsi na políčko " + policko;
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }
    }
}
