using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{
    public enum KitapDurumEnum
    {
        YAYINLANDI,REDDEDILDI,INCELEMEDE
    }
    public class Kitap
    {
        private Yazar yazar;
        private List<KitapInceleme> incelemeler;
        private KitapDurumEnum durum;
        private string adi;
        public Kitap(Yazar yazar, string adi)
        {
            this.yazar = yazar;
            this.incelemeler = new List<KitapInceleme>();
            this.durum = durum;
            this.adi = adi;
        }
        public Yazar Yazar { get { return yazar; } }
        public KitapDurumEnum DurumEnum { get { return durum; } }
        public string Adi { get { return adi; } }    
        public void addInceleme(KitapInceleme inceleme)
        {
            incelemeler.Add(inceleme);
        }
        public void removeInceleme(KitapInceleme inceleme)
        {
            incelemeler.Remove(inceleme);
        }
        private void kitapDurumGuncelle()
        {
            KitapInceleme sonInceleme= incelemeler[incelemeler.Count-1];
            if (sonInceleme.getKarar() == editorIncelemeEnum.REDDEDILDI)
                durum = KitapDurumEnum.REDDEDILDI;
            else if (sonInceleme.getKarar() == editorIncelemeEnum.DUZENLENECEK)
                durum = KitapDurumEnum.INCELEMEDE;
            else if (sonInceleme.getKarar() == editorIncelemeEnum.ONAYLANDI)
                durum = KitapDurumEnum.YAYINLANDI;
        }
    }
}
