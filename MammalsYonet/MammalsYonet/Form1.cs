using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MammalsYonet
{
    public class Mammal
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Length { get; set; }
    }
    public partial class Form1 : Form
    {
        private List<Mammal> mammals;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromCsv();

            // Bind the data to the DataGridView
            dataGridView1.DataSource = mammals;
        }
        private void LoadDataFromCsv()
        {
            mammals = new List<Mammal>();

            // Read data from the CSV file
            using (var reader = new StreamReader("d:mammals.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    var mammal = new Mammal
                    {
                        Name = values[0],
                        Population = int.Parse(values[1]),
                        Length = double.Parse(values[2])
                    };

                    mammals.Add(mammal);
                }
            }
        }
    }
}
