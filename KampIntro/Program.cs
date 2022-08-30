using System;

namespace KampIntro
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("hello world");
            //type safety
            string kategoriEtiketi = "guzel urun";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 123;
            Console.WriteLine(ogrenciSayisi);
            double faizOrani = 1.234;
            Console.WriteLine(faizOrani);
            bool sistemeGirisYapmismi = true;
            if (sistemeGirisYapmismi)
            {
                Console.WriteLine("hosgeldiniz");
                
            }
            else
            {
                Console.WriteLine("hatali kullanici adi");
            }

        }
    }
}
  


