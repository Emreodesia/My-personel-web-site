

using System;

namespace My_app
{
    internal class Program
    {

        static void Main(string[] args)

        {
           
            int saat = Convert.ToInt32(Console.ReadLine());
            double ToplamTutar = 0;

            if(saat>=24) // 24 saate eşit ya da fazla mı
            {

                ToplamTutar = ((saat / 24) * 15) + ((saat % 24) * 0.5);

            }
            else if (saat<=5) // 5 saate eşit veya az mı ?
            {

                ToplamTutar = saat * 1;



              
            }


            else // 5 saaten fazla ise 

            {

                ToplamTutar = 5 + ((saat - 5) * 0.5);

            }
            Console.WriteLine(ToplamTutar);
            Console.ReadLine();//Ekranda beklemesi için 






        }
    }
}











//Console.WriteLine("Dizi boyutunu giriniz");

//int boyut = Convert.ToInt32(Console.ReadLine());
//int[] sayılar = new int[boyut];
//var r = new Random();
//for (int i = 0; i < sayılar.Length; i++)

//    sayılar[i] = r.Next(1, 10);
//foreach (int S in sayılar)

//    Console.WriteLine($"{S,5} {S * S,5} ");

//Console.WriteLine("Analiz tamamlandı ");



////tanımlama ve başlatma  //atama 

//int[] numaralar = { 3, 5, 7, 8, 10 };


//for (int i = 0; i < numaralar.Length; i++)
//{
//    Console.WriteLine($"numaralar[{i}]= "
//        + $" {numaralar[i]}");

//}





////Tanımlama 
//int[] numaralar;

////Başlatma
//numaralar = new int[3];


//numaralar[0] = 3;
//numaralar[1] = 5;
//numaralar[2] = 7;

//for (int i = 0; i < numaralar.Length; i++)
//{

//    Console.WriteLine(numaralar[i]);

//}




















//Console.WriteLine("Bir sayı giriniz ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 2;
//do
//{
//    Console.WriteLine("{0,3}", i);
//    i += 2;

//} while (i <= n);





//int i = 10;
//while (i > 0)
//{
//    Console.WriteLine("{0,-3}{1,-3 }", i, i * i);
//    i -= 1;


//}

//Console.WriteLine("Analiz tamamlandı");





//int sayac = 1;
//while (sayac <= 10)
//{
//    //Console.WriteLine(sayac);
//    //Alan kazanmak için
//    //Console.WriteLine("{ 0,5 }",sayac);
//    //Console.Write(); x ekseni çıkart
//    //Console.WriteLine("{0,-3}" sayac);
//    Console.WriteLine("{0,-3}{1,-3 } ", sayac, sayac * sayac);
//    sayac += 1;

//}
//Console.ReadKey();















//static void Main(string[] args)



//                  int i = 0;

//                    while (i < 10) 


//                        Console.WriteLine( i);
//                        i++;
//                        Console.WriteLine("Analiz ediliyor ");

//                        Console.ReadKey();




//                    Console.WriteLine("Analiz işlemi tamamlandı ");






//static void Main(string[] args)

//{
//    int i = 0;
//    int sayac = 0;
//    while (i < 10)
//    {
//        sayac++;
//        Console.WriteLine(sayac);

//    }
//     Console.ReadKey();
