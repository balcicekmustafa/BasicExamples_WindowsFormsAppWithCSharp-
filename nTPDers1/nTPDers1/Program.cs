using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTPDers1
{
    delegate void sayiDegistir(int n);
    internal class Program
    {
        static int num = 10;
        public static void sayiiEkle(int p)
        {
            num += p;
            Console.WriteLine("İsimli Metot: {0}",num);
        }
        public static void sayiCarp(int q)
        {
            num += q;
        }
        public static int getSayi()
        {
            return num;
        }
        static void Main(string[] args)
        {
            sayiDegistir nc=new delegate (int x)
            {
                Console.WriteLine("Anonim Metot:{0}", x);
            };

           


        }
    }
}
