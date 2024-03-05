using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinEviApp
{
    public class YayinEvi
    {
        public string Adi { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public List<Editor> Editorler { get; set; }
        public YayinEvi(string adi)
        {
            Adi = adi;
            
            Kitaplar = new List<Kitap>();
            Editorler = new List<Editor>();
        }       
        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
        public void KitapCikar(Kitap kitap)
        {
            Kitaplar.Remove(kitap);
        }
        public void EditorEkle(Editor editor)
        {
            Editorler.Add(editor);
        }
        public void EditorCikar(Editor editor)
        {
            Editorler.Remove(editor);
        }
        public Kitap[] GetKitaps()
        {
            Kitap[] sonuc=new Kitap[Kitaplar.Count];
            for (int i = 0; i < Kitaplar.Count; i++)
            {
                sonuc[i] = Kitaplar[i];

            }
            return sonuc;
        }
        public Editor[] GetEditors()
        {
            Editor[] sonuc = new Editor[Editorler.Count];
            for (int i = 0;i< Editorler.Count;i++)
            {
                sonuc[i] = Editorler[i];    

            }
            return sonuc;
        }  
    }
}
