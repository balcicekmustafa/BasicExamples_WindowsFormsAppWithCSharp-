using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace veritabani_baglanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-519M5D3;Initial Catalog=vbtlab;Integrated Security=True";
        SqlConnection connect=new SqlConnection();
        private void Kayit_Ol_Click(object sender, EventArgs e)
        {
            try { 
                if (connect.State==ConnectionState.Closed) {
                    connect.Open();       
                }
                string str = "select * from Users";
                string kayit = "insert into Users (FirstName,LastName,_Password) values(@FirstName,@LastName,@_Password)";
                SqlCommand command = new SqlCommand(str, connect);
                command.Parameters.AddWithValue("@FirstName", txt_Ad);
                command.Parameters.AddWithValue("@LastName", txt_soyad);
                command.Parameters.AddWithValue("@_Password", txt_sifre);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Yeni Kullanıcı Eklendi");
            }
            catch(Exception hata) {
                MessageBox.Show("Hata Meydana Geldi"+hata);
            }
        }
    }
}
