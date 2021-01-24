using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiKrediManager = new IhtiyacKrediManager();
            
            //IKrediManager ihtiKrediManager = new IhtiyacKrediManager(); olarak tanımlasaydık da aynı şekilde bir çıktı alırdık.
            //interface, onu implemente eden sınıfın referansını tutabilir.
            //IKrediManager, IhtiyacKrediManager sınıfının referansını tutabilir.

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            
            //interfaceleri, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

            KonutKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            basvuruManager.BasvuruYap(konutKrediManager,fileLoggerService);  //basvuruManager.BasvuruYap(konutKrediManager, new FileLoggerService()); -> alternatif
            basvuruManager.BasvuruYap(tasitKrediManager, smsLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager> { ihtiKrediManager, konutKrediManager,tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}