using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den başlayarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp ekrana yazdıran program
            Console.WriteLine("bir sayı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi1)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi1);

            //a'dan z'ye kadar tüm harfleri console'a yazdıran program
            char character ='a';
            while(character<'z')
            {
                Console.WriteLine(character);
                character++;
            }

            Console.WriteLine("****FOREACH****");
            string [] arabalar = {"BMW" , "Ford", "Toyota", "Nissan"};
            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}
