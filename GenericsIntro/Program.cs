using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Melih");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);

        }
    }
}
