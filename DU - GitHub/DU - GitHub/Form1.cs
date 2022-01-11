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
        int penize = 10000;
        int sazka = 0;
        public Form1()
        {
            InitializeComponent();
            money.Text = penize + "$";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int policko = Int32.Parse(((Button)sender).Text);
            label2.Text = "Výběr je " + policko;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (penize >= 10)
            {
                sazka += 10;
                penize -= 10;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (sazka > 0)
            {
                sazka -= 10;
                penize += 10;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }
    }
}
