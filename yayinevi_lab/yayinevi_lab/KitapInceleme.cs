using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{
    public class KitapInceleme
    {
        private List<EditorKitapGorus> gorusler;
        private Kitap kitap;
        public KitapInceleme(Kitap kitap) {
            this.gorusler=new List<EditorKitapGorus>();
            this.kitap=kitap;
        }
        public void addKitapGorus(Editor editor,string acıklama,editorIncelemeEnum karar)
        {
            gorusler.Add(new EditorKitapGorus(editor, acıklama, karar));

        }
        public editorIncelemeEnum getKarar()
        {
            editorIncelemeEnum sonuc = 0;
            int redsayisi = 0;
            int duzenlenecekler = 0;
            int onay = 0;
            for(int i = 0; i < gorusler.Count;)
            {
                editorIncelemeEnum karar = gorusler[i].Karar;
                if (karar == editorIncelemeEnum.REDDEDILDI) redsayisi++;
                else if (karar == editorIncelemeEnum.DUZENLENECEK) duzenlenecekler++;
                else if(karar==editorIncelemeEnum.ONAYLANDI) onay++;
            }
            if (redsayisi > 0) sonuc = editorIncelemeEnum.REDDEDILDI;
            else if (duzenlenecekler > 0) sonuc = editorIncelemeEnum.DUZENLENECEK;
            else if (onay > 0 && onay==gorusler.Count) sonuc = editorIncelemeEnum.ONAYLANDI;
            return sonuc;
        }    
    }
}
