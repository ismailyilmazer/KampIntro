using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "ismail", "christian", "lisa" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "rose";

            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[1]);
           // //new dedigimiz icin yeni bellek ayrıldı eski degerler kayboldu
            ////isimler[1] ögesi ekrana yazdırıldığında bos görünecektir

            List<string> isimler = new List<string> { "ismail ","christian","rose"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);

            isimler.Add("ivashkov");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);

            
        }
    }
}
