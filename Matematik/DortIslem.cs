using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Toplama (int a,int b)
        {
            int toplam = a + b;
            Console.WriteLine(toplam);
            
        }

        public void Cikar (int a,int b)
        {
            int y = a - b;
            Console.WriteLine(y);
        }

        public void Carp(int x,int y)
        {
            int carp = x * y;
            Console.WriteLine(carp);
        }
        public void Bol(double a,double b)
        {
            double bol = a / b;
            Console.WriteLine(bol);
        }
    }
}
