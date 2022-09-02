using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 13;
            product1.UnitPrice = 1876.32;

            Product product2 = new Product { Id=2, ProductName = "telefon",UnitPrice =3000,UnitsInStock=11,CategoryId=3};
            //pascalCase   //camelCase

            ProductManager productManager=new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);

            //int,double,string deger tipi
            //dizi,class,abstract,interface referans tiplerdir.


        }
    }
}
