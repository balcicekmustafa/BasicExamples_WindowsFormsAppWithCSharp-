namespace nTP_Lab5_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           StreamWriter writer = new StreamWriter("C:\\Users\\balci\\Desktop\\Ogrenciler\\" + textBox1.Text + " " + textBox2.Text + ".txt")
        
        }
    }
    }
}