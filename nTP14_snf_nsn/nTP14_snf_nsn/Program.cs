using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTP14_snf_nsn
{
    
    
    class Dikdortgen
    {
        private int a, b;
        public Dikdortgen(int a,int b)
        {
            
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a * b;
        }
        public int CevreHesapla() {
            return 2*(a + b);
        }
    }
    
    
    
    
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen d = new Dikdortgen(3, 4);
            Console.WriteLine("Dikdörtgenin Alanı ={0}",d.AlanHesapla());
            Console.WriteLine("Dikdörtgenin Çevresi={0}", d.CevreHesapla());
        }
    }
}