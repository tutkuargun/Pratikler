using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //dizi tanımlama 
            string[] renkler = new string [5];

            string [] hayvanlar = {"Kedi","Köpek","Maymun", "Kuş"};

            int[] dizi;
            dizi = new int [5];

            //Dizilere değer atama ve Erişim
            renkler[0]="mavi";
            dizi[3] =10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            //döngülerle dizi kullanımı
            //klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz :");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            
            for(int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0} sayısını giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            
            int toplam=0;
            foreach(var sayi in sayiDizisi)
            {
                toplam += sayi;

            }
            Console.WriteLine("ortalama= "+ toplam/diziUzunlugu);



        }
    }
}
