using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('T');

            // //içerisindeki verilere erişim 
            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            //     Console.WriteLine(item);

            //AddRange 
            Console.WriteLine("****ADD RANGE****");
            //string[] renkler = {"kırmızı", "mavi" ,"sarı","yeşil"};
            List<int> sayilar = new List<int>(){1,7,8,10,3,45,9};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            Console.WriteLine("****SORT****");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search 
            Console.WriteLine("****Binary Search****");
            Console.WriteLine(liste.BinarySearch(9));  

            //REVERSE
            Console.WriteLine("****REVERSE****"); 
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("****CLEAR****");   
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);






                
        }
    }
}
