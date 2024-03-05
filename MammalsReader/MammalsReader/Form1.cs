using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MammalsReader
{
    public class Mammal
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Length { get; set; }
    }
    public partial class Form1 : Form
    {
        private List<Mammal> mammals = new List<Mammal>();
        private string csvFilePath = "d:mammals.csv";
        public Form1()
        {
            InitializeComponent();
            LoadDataFromCsv();
        }

        private void LoadDataFromCsv()
        {
            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(',');
                    Mammal mammal = new Mammal
                    {
                        Name = parts[0],
                        Population = int.Parse(parts[1]),
                        Length = double.Parse(parts[2])
                    };
                    mammals.Add(mammal);
                }
                dataGridView1.DataSource = mammals;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the data in the DataGridView back to the CSV file
            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                writer.WriteLine("Name,Population,Length");
                foreach (Mammal mammal in mammals)
                {
                    writer.WriteLine($"{mammal.Name},{mammal.Population},{mammal.Length}");
                }
            }
            MessageBox.Show("Kaydedildi!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataGridView
            Mammal mammal = new Mammal();
            mammals.Add(mammal);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mammals;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected row from the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                mammals.RemoveAt(selectedIndex);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mammals;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the selected row in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                Mammal mammal = mammals[selectedIndex];
                mammal.Name = txtName.Text;
                mammal.Population = int.Parse(txtPopulation.Text);
                mammal.Length = double.Parse(txtLength.Text);
                dataGridView1.Refresh();
            }
        }
    }