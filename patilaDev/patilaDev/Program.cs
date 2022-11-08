using System;

namespace patilaDev
{
    internal class Program
    {
        static void Main(string[] args)
        {



            byte a = 8;
            Console.WriteLine(a);

            sbyte b = 12;
            Console.WriteLine(b);

            short c = 400;
            Console.WriteLine(c);

            ushort d = 10142;
            Console.WriteLine(d);

            int e = 788;
            Console.WriteLine(e);

            long f = 96542;
            Console.WriteLine(f);

            float g =45.8554f;
            Console.WriteLine(g);

            double h = 9.548785;
            Console.WriteLine(h);

            string name_surmane = "Odesia";
            Console.WriteLine(name_surmane);


            bool e1 = 10 > 4;
            Console.WriteLine(e1);

            bool r1 = 2 > 7;
            Console.WriteLine(r1);

            DateTime dtt = DateTime.Now;
            Console.WriteLine(dtt);

            string dataTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Date:" +dataTime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("Hour:"+hour);



            object i5 = 13;
            Console.WriteLine(i5);

            object d3 = 23;
            Console.WriteLine(d3);

            object s2 = 13245743353;
            Console.WriteLine(s2);

            object g4 = "Mozart Lacrimosa";
            Console.WriteLine(g4);


            string str2 = string.Empty;
            str2 = "Titan";
            Console.WriteLine(str2); 
            
            int num1 = 6;
            int num2 = 8;

            Console.WriteLine(num2+num2);

            Console.WriteLine(num1*num2);

            Console.WriteLine(num1/num2);


            string num3 = "234";
            int num4 = 221;
            string newString = num3 + num4.ToString();
            int newInt = Convert.ToInt32(num3) + num4;

            Console.WriteLine("int>new number="+newInt);

        }
    }
}
