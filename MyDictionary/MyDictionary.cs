using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] items;
        TValue[] items2;
        public MyDictionary()
        {
            items = new TKey[0];
            items2 = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            TKey[] tempArray = items; //referans ları tutacak. geçici dizinin referansı items ın referansi.
            //Artık elemanları kaybolmayacak, temparray e emanet ettik. Önceki değerleri koruduk.
            TValue[] tempArray2 = items2;
            //önce items dizisinin eleman sayısı 1 arttırılır.
            items = new TKey[items.Length + 1];
            items2 = new TValue[items2.Length + 1];
            //items.length dizi uzunluğunu verir. ve burda bir arttırdık.
            //new ledğimiz için referans numarası her seferinde uçuyor,gidiyor. Bunu birinin tutması lazım.

            //sonra da az önce emanet olarak verdiğimiz elemanları geri istiyoruz. temp array in tüm elemanlarını items a geri atayacağız
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //emanet olarak verdiğimiz değerleri sırasıyla kendi üzerine geri alıyor.
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i]; //emanet olarak verdiğimiz değerleri sırasıyla kendi üzerine geri alıyor.
            }

            items[items.Length - 1] = key; //son elemanının indexi uzunluk-1 ile yaptık.
            items2[items2.Length - 1] = value;
            //son elemanına da yukardan gelen item ı yerleştirdik.
        }

        public void Listele()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]+" "+items2[i]);
            }
        }
    }
}
