using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nTP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double say1, say2,toplama,cikarma,carpma,bolme,kalan;
            say1=Convert.ToDouble(textBox1.Text);
            say2=Convert.ToDouble(textBox2.Text);   
            toplama= say1 + say2;
            cikarma= say1 - say2;
            carpma= say1 * say2;
            bolme= say1 / say2;
            kalan= say1 % say2;
            textBox3.Text = Convert.ToString(toplama);
            textBox4.Text = Convert.ToString(cikarma);
            textBox5.Text = Convert.ToString(carpma);
            textBox6.Text = Convert.ToString(bolme);
            textBox7.Text = Convert.ToString(kalan);
        }
    }
}
