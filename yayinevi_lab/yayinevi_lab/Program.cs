using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yayinevi_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YayinEvi yevi = new YayinEvi("Papatya");
            Editor e1 = new Editor("Ayşe", "Bilgili");
            Editor e2 = new Editor("Ali", "Görüş");
            yevi.addEditor(e1);yevi.addEditor(e2);
            Yazar y1 = new Yazar("Veli", "Can");
            Kitap k=new Kitap(y1,"C# ile NTP");
            KitapInceleme kincele = new KitapInceleme(k);
            kincele.addKitapGorus(e1, "1. Paragraf düzeltilmeli", editorIncelemeEnum.DUZENLENECEK);
            kincele.addKitapGorus(e2, "", editorIncelemeEnum.ONAYLANDI);
            k.addInceleme(kincele);
            Console.WriteLine(k.DurumEnum);
            Console.ReadKey();
            }
    }
}
