using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar tek sayıları yazdırma 
            Console.WriteLine("Bir sayı giriniz:");
            int sayac =int.Parse(Console.ReadLine());

            for(int i =0; i<=sayac; i ++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi aralarındaki toplamları ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i=0; i<1000; i++)
            {
                if (i%2 == 1)
                {
                  tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek toplam sonucu= "+tekToplam+ " Çift toplam sonucu= "+ciftToplam);

            //break ve continue
            for (int i=0; i<10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);    
            }

             for (int i=0; i<10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);    
            }
        }

        
    }
}
