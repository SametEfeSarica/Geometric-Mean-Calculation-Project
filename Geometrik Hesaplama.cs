using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikOrtalamaHesabıÖdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 2 Sayının Geometrik Ortalaması alınacak. 
            // Küsüratlı çıkabileceği için Double veri tipini kullandım.
            // RedLine komutu ile Double komutu çalışmayacağından komutu "Convert" yardımıyla Double'a dönüştürdüm.

            Console.WriteLine("İlk Sayıyı Girin:");

            Double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı Girin:");

            Double sayi2 = Convert.ToDouble(Console.ReadLine());

            Double sayi3 = Convert.ToDouble(Math.Sqrt(sayi1 * sayi2));

            // Sonuç Yazılacak.
            
            Console.WriteLine("İşte Sonuç:");

            Console.WriteLine(sayi3);

            //Terminalin ekranda Kalması için.

            Console.ReadLine();
        }
    }
}
