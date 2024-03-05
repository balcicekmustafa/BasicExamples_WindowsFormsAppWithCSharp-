using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTP_17
{
    class EkranIslem
    {
        public void EkranaYaz(params int[] sayilar)
        {   
            if(sayilar.Length == 0) {
                Console.WriteLine("Parametre olmadığı için metottan çıkılıyor.");
                return;
            }
            Console.WriteLine("Parametreden gelen değerler:");
            foreach(var s in sayilar) {
            Console.WriteLine(s);}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
