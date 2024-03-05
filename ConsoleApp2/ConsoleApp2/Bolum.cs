using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

        public class Bolum : Site
        {
            public string Isim { get; set; }
            public double Alan { get; set; }

            public Bolum(double alan, string isim)
            {
                Alan = alan;
                Isim = isim;
            }
        }
    }
}
