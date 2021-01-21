using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };

            List<String> isimler2 = new List<string> { "Engin", "Kuti", "Melis", "Eda", "Mehmet" };
            isimler2.Add("Kutay");
            foreach (var isim in isimler2)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
