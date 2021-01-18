using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri ozge = new Musteri() { Id = 1, Ad = "Özge", Soyad = "Kiracı", TCnumara = 111, Adres = "Istanbul", Bakiye = 1000 };
            Musteri mahmut = new Musteri() { Id = 2, Ad = "Mahmut", Soyad = "Tuncer", TCnumara = 112, Adres = "Ankara", Bakiye = 300 };
            musteriManager.MusteriEkle(ozge);
            musteriManager.MusteriEkle(mahmut);
            musteriManager.MusteriListele();
            musteriManager.MusteriSil(ozge);
            musteriManager.MusteriListele();
        }
    }
}