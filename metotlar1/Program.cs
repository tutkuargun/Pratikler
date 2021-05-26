using System;

namespace metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            
            int toplam = Topla(a,b);
            // Console.WriteLine(toplam);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(toplam.ToString());

            int sonuc = ornek.ArttirVeTopla(ref a, ref b);
            Console.WriteLine(sonuc.ToString());
            Console.WriteLine(a+b);
        }
        static int Topla(int deger1, int deger2)
        {
          return (deger1 + deger2); 
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int deger1, ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return (deger1+deger2);
        }
    }
}
