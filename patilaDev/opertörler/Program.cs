using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opertörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlem atama 

            int x = 3;
            int y = 5;
            y = y + 2;

            Console.WriteLine(y);
            Console.ReadLine();

            y *= 10;
            Console.WriteLine(y);
            Console.ReadLine();

            y /= 1;
            Console.WriteLine(y);
            Console.ReadLine();

            x *= 6;
            Console.WriteLine(x);
            Console.ReadLine();

            //Mantıksal opertörler

            bool ısSuccessful=true;
            bool ısCompleted=false;

            if (ısSuccessful && ısSuccessful)
            {
                Console.WriteLine("Perfect");

            }
            if (ısSuccessful || ısCompleted)
            {
                Console.WriteLine("Great");
            }

            if (ısSuccessful&& !ısCompleted)
            {
                Console.WriteLine("Final");
            }
        
            Console.ReadLine();

            //İlişkisel opretörler

            int a = 20;
            int b = 10;
            bool sonuc = a < b;

            sonuc= a > b;
            Console.WriteLine(sonuc);

            sonuc= a>b;
            Console.WriteLine(sonuc);

            sonuc = a<b;
            Console.WriteLine(sonuc);

            Console.ReadLine();

            int sayı1 = 10;
            int sayı2 = 5;
            int sonuc1 = sayı1 / sayı2;
            Console.WriteLine(sonuc1);

            int sonuc2 = sayı1 * sayı2;
            Console.WriteLine(sonuc2);

            sonuc1 =sayı2 + sayı2;
            Console.WriteLine(sonuc1);

            sonuc2 = sayı2 / sayı1;
            Console.WriteLine(sonuc2);

            Console.WriteLine("İşlem bitti");
            Console.ReadLine();

            //Mod alma

             sonuc1 =20%3 ;
            Console.WriteLine(sonuc1);
       
            Console.ReadLine(); 
        }
    }
}
