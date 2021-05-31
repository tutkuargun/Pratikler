using System;

namespace kurucu_metotlar
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

            Calisan calisan = new Calisan("Tutku", "ARGUN","İnsan Kaynakları",12354);
            
            calisan.CalisanBilgileri();
            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ayşe";
            calisan2.Soyad="Mecnun";
            calisan2.Department="Satın Alma";
            calisan2.No=124584;
            calisan2.CalisanBilgileri(); 
            Console.WriteLine("***************");

            Calisan calisan3 = new Calisan("Cansu","Yumru");
            calisan3.CalisanBilgileri();
        }
    }
    public class Calisan
    {
        public string Ad;
        public string Soyad;
        public string Department;
        public int No;

        public Calisan(string ad, string soyad, string department, int no)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Department = department;
            this.No = no;
        }
        public Calisan(){}
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın adı:"+Ad);
            Console.WriteLine("Çalışanın soyadı:"+Soyad);
            Console.WriteLine("Çalışanın Departmanı:"+Department);
            Console.WriteLine("Çalışanın Numarası:"+No);

        }
    }
}
    

