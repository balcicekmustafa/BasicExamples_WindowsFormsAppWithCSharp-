using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace nTP_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StreamReader reader = new StreamReader("C:\\Users\\balci\\Desktop\\text.txt");
            /*Console.WriteLine("Text dosyası başarıyla açıldı.");
            Console.ReadKey();
            reader.Close();*/
            /* string satir=reader.ReadLine();
             while( satir != null ) { 
                 Console.WriteLine( satir );
                 satir = reader.ReadLine();
             }
             Console.ReadKey();*/
            StreamWriter writer = new StreamWriter("C:\\Users\\balci\\Desktop\\text.txt");
            /*using (writer)
            {
                for(int i=0;i<100;i++)
                {
                    writer.Write(i+", ");
                    //  writer.WriteLine(i);
                }*/
            FileStream fs =new FileStream("C:\\Users\\balci\\Desktop\\text2.txt",FileMode.Create);
                
            }
        }
    }
}
