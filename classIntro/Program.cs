using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kurs kurs1 =new Kurs();
            kurs1.kursAdi = "c# kursu";
            kurs1.izlenmeOrani = 24;
            kurs1.Egitmen = "ismail yilmazer";


            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "java kursu";
            kurs2.izlenmeOrani = 67;
            kurs2.Egitmen = "christian ozera";


            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python kursu";
            kurs3.izlenmeOrani = 43;
            kurs3.Egitmen = "maradona";

            Console.WriteLine(kurs1.kursAdi + " " + kurs1.Egitmen + " " + kurs1.izlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (Kurs kurs in kurslar)
            {

                Console.WriteLine(kurs.kursAdi +" "+kurs.Egitmen+" "+kurs.izlenmeOrani);
                
            }


        }    

        class Kurs 
        {
            public string kursAdi { get; set; }
            public string Egitmen{ get; set; }

            public int izlenmeOrani { get; set; }
        }
    }
}
