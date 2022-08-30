using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string kurs1 = "matematik";
            string kurs2 = "fen bilgisi";
            string kurs3 = "tarih";*/

            //arrayler

            string[] kurslar = new string[] { "matematik", "turkce", "fen" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine(kurslar.LongLength);

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            /*string userName= Console.ReadLine();
            Console.WriteLine(userName);*/

        }
    }
}
