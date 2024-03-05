using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{
    public class Kisi
    {
        private string ad;
        private string soyad;
        public Kisi(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }
        public string Ad
        {
            get { return this.ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return this.soyad; }
            set { soyad = value; }
        }
        
    }
}
