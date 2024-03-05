using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{
    public class YayinEvi
    {
        string isim;
        private List<Kitap> kitaplar;
        private List<Editor> editorler;
        public  YayinEvi(string isim)
        {
            this.kitaplar = new List<Kitap>();
            this.editorler = new List<Editor>();
            this.isim = isim;
        }
        public void addKitap(Kitap k)
        {
            kitaplar.Add(k);
        }
        public void removeKitap(Kitap k)
        {
            kitaplar.Remove(k);
        }
        public void addEditor(Editor e) {
            editorler.Add(e);
        }
        public void removeEditor(Editor e) {  editorler.Remove(e);}
        public Editor[] getEditorler()
        {
            Editor[] sonuc= new Editor[editorler.Count];
            for(int i=0;i<editorler.Count;i++)
            {
                sonuc[i]= editorler[i];
               
            }
            return sonuc;
        }
    }
}
