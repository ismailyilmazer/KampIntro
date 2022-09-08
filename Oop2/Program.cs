using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gercek Müsteri-Tüzel Müsteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Adi = "ismail";
            musteri1.Soyadi = "yilmazer";
            musteri1.MusteriNo = "342525";
            musteri1.TcNo = "3333333";
            musteri1.Id = 2;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.SirketAdi = "Anka";
            musteri2.MusteriNo = "45343";
            musteri2.VergiNo = "354411";
            musteri2.Id = 3;

            Musteri musteri3 = new Musteri();
            Musteri musteri4 = new Musteri();

            MusteriYonetimi musteriYonetimi= new MusteriYonetimi();
            musteriYonetimi.Add(musteri3);
            musteriYonetimi.Add(musteri2);




           
        }
    }
}
