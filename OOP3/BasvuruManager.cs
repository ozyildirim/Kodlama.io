using System.Collections.Generic;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //burada IKrediManager olarak girmemizin sebebi, başvuracak kredi türümüzün birden farklı şeyler olabilecek olması.
            //Örneğin konut kredisi de olabilir, taşıt kredisi de.
            //O yüzden başlangıçta hangi tür kredi olduğunu belirtmeliyiz ve bütün tipleri referans olarak alabilecek bir yapıya ihtiyacımız var.
            //O da Interface oluyor.
            //Aşağıdaki gibi bir şekilde yazarsak, her başvuru ypaıldığında yalnızca "Konut Kredisi" bşavurusu yapılır.


            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log();
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                //BasvuruYap(item);
            }
        }

    }
}
