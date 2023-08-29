using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesai_saati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir saat giriniz");
            double saat = Convert.ToDouble(Console.ReadLine());

            //14.satır rastgele bir saat diliminin klavyeden girilmesini ister
            if ((saat >= 18)||(saat < 9,30) )
            //eğer (saat 18 sayısına eşit veya daha küçükse) veya (saat 9.30 dan küçük ise 20. satırda parantez içindeki cümleyi ekrana yaz) 
            {
                Console.WriteLine("şuanda mesai saatinin dışındasın");
              
            }
            else
            //değil ise 26. satırda parantez içindeki kodu ekrana yaz                               
            {
                Console.WriteLine("şuanda mesai saatindesiniz lütfen işinizin başına dönün");
            }
            Console.ReadKey();

        }
    }
}
