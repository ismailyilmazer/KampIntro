using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new  IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            BasvuruManager basvuruManager= new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager,new DataBaseLoggerService());
            //basvuruManager.BasvuruYap(konutKrediManager,new FileLoggerService());

            List<IKrediManager> krediManager = new List<IKrediManager> { tasitKrediManager,konutKrediManager };
            
            basvuruManager.KrediOnBilgilendirmesi(krediManager);
            IKrediManager esnafKrediManager = new EsnafKrediManager();
            esnafKrediManager.Hesapla();
            List<ILoggerService> loggerService = new List<ILoggerService> { new DataBaseLoggerService(),new FileLoggerService()};
            basvuruManager.BasvuruYap(esnafKrediManager,loggerService );            
            

        }
    }
}
