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
        int[] sazkaNa = new int[50];
        int[] kolik = new int[50];
        int i = 0;


        Form menu;
        public Form1(Form opener)
        {
            InitializeComponent();
            WindowState = opener.WindowState;
            money.Text = penize + "$";
            vsaditNaVyber.Visible = false;
            menu = opener;
            this.FormClosing += close_game;
        }

        public void close_game(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int policko = Int32.Parse(((Button)sender).Text);
            label2.Text = "Výběr je " + policko;
            vsaditNaVyber.Visible = true;
            label6.Text = "";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            label2.Text = "Výběr je red";
            vsaditNaVyber.Visible = true;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            label2.Text = "Výběr je black";
            vsaditNaVyber.Visible = true;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (penize >= 10)
            {
                sazka += 10;
                penize -= 10;
            } else if(penize >0)
            {
                sazka += penize;
                penize -= penize;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (sazka >= 10)
            {
                sazka -= 10;
                penize += 10;
            } else if(sazka>0)
            {
                penize += sazka;
                sazka -= sazka;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (penize >= sazka)
            {
                penize -= sazka;
                sazka *= 2;
            } else if(penize>0)
            {
                sazka += penize;
                penize -= penize;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (sazka>1)
            {
                penize += sazka / 2;
                sazka -= sazka/2;
            }
            vsadit.Text = sazka + "$";
            money.Text = penize + "$";
        }

        private void vsaditNaVyber_Click(object sender, EventArgs e)
        {
            if (sazka > 0)
            {
                listBox1.Items.Add(label2.Text.Substring(9) + " - " + sazka + "$");
                sazkaNa[i] = int.Parse(label2.Text.Substring(9));
                kolik[i] = sazka;
                i++;
                sazka = 0;
            }
            else
                MessageBox.Show("Prosím zadej číslo vyšší nž 0!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            vsadit.Text = sazka + "$";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int pomocna = penize;
                Random rng = new Random();
                int random = rng.Next(37);
                vyhra.Text = "Číslo je " + random;
                for(int f = listBox1.Items.Count;f>=0;f--)
                {
                    if(random == sazkaNa[f])
                    {
                        if(random==0)
                        {
                            penize += kolik[f]*5;
                        }
                        else
                        {
                            penize += kolik[f] * 2;
                        }
                        label6.Text = "Vyhrál jsi " + (penize - pomocna);
                    }
                }
                money.Text = penize + "$";
                listBox1.Items.Clear();
                for(int f = 49;f>=0;f--)
                {
                    sazkaNa[f] = 0;
                    kolik[f] = 0;
                }

            }
            else
                MessageBox.Show("Prosím vsaď!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
