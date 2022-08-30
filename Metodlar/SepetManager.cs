using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        public void sepeteEkle(Product product)
        {
            Console.WriteLine(product.urunAdi + " eklendi");
        }

        public void Ekle2( string urunAdi,double fiyat,int id) 
        {
            Console.WriteLine("tebrikler sepete " + urunAdi + " eklendi");
            
        }
    }
}
