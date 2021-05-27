using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> sayıListesi = new List<int>();

            sayıListesi.Add(23);
            sayıListesi.Add(14);
            sayıListesi.Add(9);
            sayıListesi.Add(3);
            sayıListesi.Add(41);
            sayıListesi.Add(43);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("yeşil");
            renkListesi.Add("beyaz");
            renkListesi.Add("turuncu");

            //count 
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayıListesi.Count);

            //foreach ve Liste.ForEach ile elemanlara erişim
            foreach (var sayi in sayıListesi)
                Console.WriteLine(sayi);
            
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayıListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayıListesi.Remove(9);
            renkListesi.Remove("yeşil");
            sayıListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayıListesi.RemoveAt(2);
            renkListesi.RemoveAt(3);
            sayıListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if(sayıListesi.Contains(43))
                Console.WriteLine("listede 43 var");

            if (renkListesi.Contains("mor"))
                Console.WriteLine("Listede kırmızı var");
            else
                Console.WriteLine("aranan değer bulunamadı"); 

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            List <string> hayvanlarListesi= new List<string>(hayvanlar);
            hayvanlarListesi.ForEach(hayvan => Console.WriteLine(hayvan));

            //Listeyi temizleme
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();

            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 25;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim ="Zehra";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim ="Deniz",
                Soyisim ="Görgülü",
                Yas=32
            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı adı:"+kullanici.Isim);
                Console.WriteLine("Kullanıcı soyisim:"+kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı:"+kullanici.Yas);
            }
            yeniListe.Clear();


               
            
        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;

        public int Yas { get => yas; set => yas = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Isim { get => isim; set => isim = value; }
    }
}
