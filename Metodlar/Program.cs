using System;

namespace Metodlar
{
    class Program
    {
    static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 131;
            product1.fiyat = 12;
            product1.urunAdi = "domates";
            product1.stokAdedi = 3;

            Product product2 = new Product();
            product2.id = 145;
            product2.fiyat = 15;
            product2.urunAdi = "elma";
            product2.stokAdedi = 11;

            Product product3 = new Product();
            product3.id = 314;
            product3.urunAdi = "armut";
            product3.fiyat = 3457;
            product3.stokAdedi = 13;


            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.id + "  seri nolu " + product.fiyat + " tl  " + product.urunAdi);
            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();

            //encapsulation!!

            sepetManager.sepeteEkle(product1);
            sepetManager.sepeteEkle(product2);

            sepetManager.Ekle2("elma", 23.21, 12431);
            sepetManager.Ekle2("armut", 12.44, 12471);

        }
    }
}
