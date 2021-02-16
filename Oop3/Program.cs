using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKredimanager();         
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();
            IloggerService smsLoggerService = new SmsLoggerService();
            List<IloggerService> loggers = new List<IloggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
