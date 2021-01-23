using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediManager tasitKrediManager = new TasitKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager,ihtiyacKrediManager,new EsnafKrediManager() };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
