using System;

namespace metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int OutSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(OutSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc.ToString());
           

            // metot aşırı yükleme - overloading
            int ifade = 125;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir(6,7);

        }
        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a+b;
            }
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri , int veri2)
            {
                Console.WriteLine(veri + veri2);
            }
        }
    }
}
