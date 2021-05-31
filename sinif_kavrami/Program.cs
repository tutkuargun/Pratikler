using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirleyiciler
            // * Public => her yerden erişilebilir
            // * Private => sadece tanımlandığı classtan erişilebilir
            // * Internal => Sadece bulunduğu proje içerisinden erişilebilir
            // * Protected => Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir

            Calisan calisan = new Calisan();
            calisan.Ad="Tutku";
            calisan.Soyad="Argun";
            calisan.Department="Bilgi İşlem";
            calisan.No=123654;
            calisan.CalisanBilgileri();
            Console.WriteLine("**************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ayşe";
            calisan2.Soyad="Mecnun";
            calisan2.Department="Satın Alma";
            calisan2.No=124584;
            calisan2.CalisanBilgileri();


          
        }
    }
    public class Calisan
    {
        public string Ad;
        public string Soyad;
        public string Department;
        public int No;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı:"+Ad);
            Console.WriteLine("Çalışanın soyadı:"+Soyad);
            Console.WriteLine("Çalışanın Departmanı:"+Department);
            Console.WriteLine("Çalışanın Numarası:"+No);

        }
    }
}
