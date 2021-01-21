using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0]; //yeni bir T yapısında array oluşturuyor ve bunun ilk noktasının(T[0]) referansını gidip items a veriyoruz. Bu sayede yeni bir array,
                              // items değişkenine tanımlanıyor.
        }
        public void Add(T item)
        {
            //burada yeni bir eleman artırmaya çalışıyoruz. Array yapısında bu mümkün olmadığı için, eleman sayısının 1 fazla olduğu yeni bir array oluşturmak zorundayız.
            //daha önceden tanımlanan arraydaki elemanların kaybolmaması için tempArray isminde yeni bir T yapılı array oluşuturuyoruz. items in referansını
            //tempArray a veriyoruz.
            T[] tempArray = items;  
            items = new T[items.Length + 1];

            //tempArray e attığımız değerleri, items içerisine geri ekliyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
           
            items[items.Length - 1] = item;

        }
    }
}