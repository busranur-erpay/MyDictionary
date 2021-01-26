using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
          MyDictionary<int, string> elemanlar = new MyDictionary<int, string>();
            elemanlar.Add(1,"Büşra");
            elemanlar.Add(2, "Esra");
            elemanlar.Add(3, "Mine");
            elemanlar.Add(4, "Yaren");
            elemanlar.Add(5, "Hilal");

            elemanlar.Listele();
            

        }
    }
}
