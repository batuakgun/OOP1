using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediBaseManager ihtiyacKrediManager = new IhtiyacKrediManager();
            

            IKrediBaseManager tasitKrediManager = new TasitKrediManager();
            

            IKrediBaseManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, databaseLoggerService);

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ihtiyacKrediManager, tasitKrediManager };

           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
