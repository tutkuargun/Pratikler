using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sort
            int [] sayiDizisi = {24,12,4,5,17,80,45,32};

            Console.WriteLine("****SIRASIZ DİZİ****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("****SIRALI DİZİ****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //clear
            Console.WriteLine("****CLEAR METODU****");
            Array.Clear(sayiDizisi,2,2); //2.indexten başlayarak 2 elemanı sıfırlar.

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //reverse 
            Console.WriteLine("****REVERSE METODU****");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("****INDEXOF METODU****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,45));

            //Resize
            Console.WriteLine("****RESIZE METODU****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

    

        }
    }
}
