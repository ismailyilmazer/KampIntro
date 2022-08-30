using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            dortIslem.Toplama(2, 4);
            dortIslem.Carp(4, 6);
            dortIslem.Bol(4, 8);
            dortIslem.Cikar(123, 65);

        }
    }
}
