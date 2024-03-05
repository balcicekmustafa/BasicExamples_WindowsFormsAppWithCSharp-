using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YayinEviApp
{
    public partial class Form1 : Form
    {
        

        public YayinEvi seciliYayinEvi;
        public Form1()
        {
            InitializeComponent();
        }

        private void YayinEviEkleButton_Click(object sender, EventArgs e)
        {
            string adi = YayinEviAdiTextBox.Text;
         
            YayinEvi yayinEvi = new YayinEvi(adi);
            seciliYayinEvi = yayinEvi;
            YayinEvleriComboBox.Items.Add(yayinEvi);
            YayinEvleriComboBox.SelectedItem = yayinEvi;

        }

        private void YayinEvleriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliYayinEvi = (YayinEvi)YayinEvleriComboBox.SelectedItem;            
            KitapListesiListBox.DataSource = seciliYayinEvi.Kitaplar;
            EditorListesiListBox.DataSource = seciliYayinEvi.Editorler;
            if (seciliYayinEvi == (YayinEvi)YayinEvleriComboBox.SelectedItem)
            {
                MessageBox.Show("Seçilen Yayın evinin Adı:" + seciliYayinEvi.Adi);
            }
        }

        private void KitapEkleButton_Click(object sender, EventArgs e)
        {
            string kitapAdi = KitapAdiTextBox.Text;
            string kitapYazari = KitapYazariTextBox.Text;
            Kitap kitap = new Kitap(kitapAdi, kitapYazari,  seciliYayinEvi);
            seciliYayinEvi.KitapEkle(kitap); 
            KitapListesiListBox.DataSource = null;
            KitapListesiListBox.DataSource = seciliYayinEvi.Kitaplar;
            MessageBox.Show("Kitap Başaryla Eklendi:" + kitap.Adi);

        }

        private void KitapCikarButton_Click(object sender, EventArgs e)
        {
            Kitap seciliKitap = (Kitap)KitapListesiListBox.SelectedItem;
            seciliYayinEvi.KitapCikar(seciliKitap);           
            KitapListesiListBox.DataSource = null;
            KitapListesiListBox.DataSource = seciliYayinEvi.Kitaplar;
            MessageBox.Show("Kitap Başaryla Silindi:" + seciliKitap.Adi+" "+" Yayınevi:"+seciliYayinEvi.Adi);
        }
        private void EditorEkleButton_Click(object sender, EventArgs e)
        {            
            string editorAdi = EditorAdiTextBox.Text;
            Editor editor = new Editor(editorAdi);
            seciliYayinEvi.EditorEkle(editor);            
            EditorListesiListBox.DataSource = null;
            EditorListesiListBox.DataSource = seciliYayinEvi.Editorler;
            MessageBox.Show("Editör Başaryla Eklendi:" + editor.Adi);
        }
         private void button4_Click(object sender, EventArgs e)
        {
            Editor seciliEditor = (Editor)EditorListesiListBox.SelectedItem;
            seciliYayinEvi.EditorCikar(seciliEditor);
           
            EditorListesiListBox.DataSource = null;
            EditorListesiListBox.DataSource = seciliYayinEvi.Editorler;
            MessageBox.Show("Editör Başaryla Çıkarıldı:" + seciliEditor.Adi+" "+"Yayınevi:"+seciliYayinEvi.Adi);

        }
          private void button1_Click(object sender, EventArgs e)
        {
            Kitap seciliKitap = (Kitap)KitapListesiListBox.SelectedItem;
            if (seciliKitap == (Kitap)(KitapListesiListBox.SelectedItem))
            {
                MessageBox.Show("Seçilen Kitap Bilgileri: " + seciliKitap.Adi + " " + seciliKitap.Yazari);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Editor seciliEditor = (Editor)EditorListesiListBox.SelectedItem;
            if (seciliEditor == (Editor)(EditorListesiListBox.SelectedItem))
            {
                MessageBox.Show("Seçilen Editör Bilgileri: " + seciliEditor.Adi );
            }
        }
    }
}
