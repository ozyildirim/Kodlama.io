using System;
using System.Collections.Generic;
using System.Text;

namespace Hafta4Odev5
{
    class MyDictionary<T,U>
    {
        T[] _keys;
        U[] _values;

        public MyDictionary()
        {
            _keys = new T[0];
            _values = new U[0];
        }

        public void Add(T key,U value)
        {
            //Kendi oluşturduğumuz List yapısındaki gibi, kullandığımız referans tipi Arrayler,
            //Bu yüzden eleman ekleme sırasında eski değerleri geçici bir arrayda tutup,
            //Yeni bir genişletilmiş yapıya aktarmalıyız.
            T[] tempKeys = _keys;
            U[] tempValues = _values;

            _keys = new T[_keys.Length + 1];
            _values = new U[_values.Length + 1];


            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }


    }
}
