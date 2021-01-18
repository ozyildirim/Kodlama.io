using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public List<Musteri> musteriler = new List<Musteri> {}; //dizi oluşumu

        public void MusteriListele()
        {
            Console.WriteLine("\n------------Müşteri Listesi------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\nMüşteri ID: " + musteri.Id);
                Console.WriteLine("Müşteri Adı: " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşteri TC Kimlik Numarası: " + musteri.TCnumara);
                Console.WriteLine("Müşteri Adresi: " + musteri.Adres);
                Console.WriteLine("Müşteri Bakiyesi: " + musteri.Bakiye);
            }
        }

        public void MusteriEkle(Musteri eklenecekMusteri)
        {
            musteriler.Add(eklenecekMusteri);
            Console.WriteLine("\nMüşteri Başarıyla Eklendi\n");
        }

        public void MusteriEkle(int id, string ad, string soyad, int tcNumara, string adres, int bakiye)
        {
            Musteri eklenecekMusteri = new Musteri() { Id = id, Ad = ad, Soyad = soyad, TCnumara = tcNumara, Adres = adres, Bakiye = bakiye };
            musteriler.Add(eklenecekMusteri);
            Console.WriteLine("\nMüşteri Başarıyla Eklendi\n");
        }

        public void MusteriSil(int id)
        {
            musteriler.Remove(musteriler.Find(x => x.Id == id));
            Console.WriteLine("\nMüşteri Başarıyla Silindi.");
        }

        public void MusteriSil(Musteri musteri)
        {
            musteriler.Remove(musteriler.Find(x => x.Id == musteri.Id));
            Console.WriteLine("\nMüşteri Başarıyla Silindi.");
        }





    }
}
