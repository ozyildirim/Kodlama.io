using System;

namespace Hafta4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> plakalar = new MyDictionary<string, int>();

            plakalar.Add("Bursa", 16);
            plakalar.Add("İstanbul", 34);
            plakalar.Add("Eskişehir", 26);
        }
    }
}
