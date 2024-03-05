using Microsoft.VisualBasic.ApplicationServices;

namespace FormsApp_Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\balci\\Desktop\\Ogrenciler\\" + textBox1.Text + " " + textBox2.Text);
            using (writer)
            {
                writer.WriteLine(label1.Text + " " + textBox1.Text);
                writer.WriteLine(label2.Text + " " + textBox2.Text);
                writer.WriteLine(label3.Text + " " + textBox3.Text);
            }
            StreamReader reader = new StreamReader("C:\\Users\\balci\\Desktop\\Ogrenciler\\" + textBox1.Text + " " + textBox2.Text);
            textBox4.Text = reader.ReadToEnd();        }
    }
}