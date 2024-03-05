using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nTP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte skor1, skor2;
            skor1 = 4;
            skor2 = 5;
            if (skor1 > skor2) { MessageBox.Show("1. TAKIM KAZANDI."); }

        }
    }
}
