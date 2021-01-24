using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;// T yazma sebebi ne oldugunu kullanici belirlesin int mi string mi bool mu 
        public MyList() //Constructor //ctor ve tab tab
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //new T ile bir önceki deger gidiyor diye... 
                                   //tempArray yazilirki bir öncei deger silinmesin!!
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //temparraydeki degerleri yeni item tablosuna ekledin!!
            }

            items[items.Length - 1] = item;

           public int Length
        }
    }
}
