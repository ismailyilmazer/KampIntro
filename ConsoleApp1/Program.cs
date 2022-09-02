using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");

            int sayi1;
            int sayi2; 

            sayi1 = 23;sayi2 = 75;
            sayi1 = sayi2;
            sayi2 = 123;
            Console.WriteLine(sayi1);



            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 4, 5, 6 };
            sayilar1 = sayilar2;
            sayilar2[0]=111;

            Console.WriteLine(sayilar1[0]);




        }
    }
}
