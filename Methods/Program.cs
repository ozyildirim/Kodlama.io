using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Id = 0;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 1;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine($"--- Urun {urun.Id} ---\n");
                Console.WriteLine($"Urun Adı: {urun.Adi}\n");
                Console.WriteLine($"Urun Fiyatı: {urun.Fiyati}\n");
                Console.WriteLine($"Urun Aciklamasi: {urun.Aciklama}\n");
            }


            Console.WriteLine("-------------Metotlar------------------");
            //encapsulation
            SepetManager sepetManager = new SepetManager();

            sepetManager.UrunEkle(urun1);
            sepetManager.UrunEkle(urun2);
            
        }
    }
}


//Don't repeat yourself! - Clean Code - Best Practice

