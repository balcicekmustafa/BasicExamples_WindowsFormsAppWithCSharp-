using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nTP8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = 0;
            for(int i = sayi1; i < sayi2; i++) {
                toplam = toplam + i;
            }
            MessageBox.Show("Sayıların Toplamı=" + toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kuvvet;
            for (int i = 0; i < 5; i++)
            {
                kuvvet = Math.Pow(10, i);
                listBox1.Items.Add(kuvvet);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<listBox2.Items.Count;i++)
            {
                if (listBox2.Items[i].ToString() == "Hoparlör"|| listBox2.Items[i].ToString() == "Mikrofon"|| listBox2.Items[i].ToString() == "Monitör")
                {
                    listBox3.Items.Add(listBox2.Items[i]);


                }
                else
                {
                    listBox4.Items.Add(listBox2.Items[i]);
                }
            }
        }
    }
}
