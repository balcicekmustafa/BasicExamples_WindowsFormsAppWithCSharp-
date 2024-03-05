using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Site
    {
        public string Isim { get; set; }
        public int DaireSayisi { get; set; }
        public List<Bolum> OrtakBolumler { get; set; }

        public Site(int daireSayisi, string isim)
        {
            DaireSayisi = daireSayisi;
            Isim = isim;
            OrtakBolumler = new List<Bolum>();
        }

        public void OrtakBolumEkle(Bolum bolum)
        {
            OrtakBolumler.Add(bolum);
        }

        public double GetOrtakAlan()
        {
            double toplamAlan = 0;
            foreach (Bolum bolum in OrtakBolumler)
            {
                toplamAlan += bolum.Alan;
            }
            return toplamAlan;
        }
    }
}

