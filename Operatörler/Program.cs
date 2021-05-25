using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama 
             Console.WriteLine("*******ATAMA VE İŞLEMLİ ATAMA OPERATÖRLERİ*******");
            int x =3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            y*=2;
            Console.WriteLine(y);

            // Mantıksal Operatörler 
            // || , && ve ! 
             Console.WriteLine("*******MANTIKSAL OPERATÖRLERİ*******");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            // İlişkisel operatörler 
            // ==, !=, <, >, >=, <=
            Console.WriteLine("*******İLİŞKİSEL OPERATÖRLER*******");
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
 
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //Aritmetik operatörler
            // /, *, +, - 
            Console.WriteLine("*******ARİTMETİK OPERATÖRLER*******");
            int sayi1 = 10 ;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);
           

            // % : mod alır
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

        }
    }
}
