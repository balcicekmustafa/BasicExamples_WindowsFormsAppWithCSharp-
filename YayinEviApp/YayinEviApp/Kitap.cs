using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YayinEviApp
{
    public class Kitap
    {
        public string Adi { get; set; }
        public string Yazari { get; set; }
        public YayinEvi YayinEvi { get; set; }

        public Kitap(string adi, string yazari, YayinEvi yayinEvi)
        {
            Adi = adi;
            Yazari = yazari;
            YayinEvi = yayinEvi;
        }
    }
}
