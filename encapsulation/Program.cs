using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim="Yılmaz";
            ogrenci.OgrenciNo= 110;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtla();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.Isim = "Ali";
            ogrenci2.Soyisim="Yılmaz";
            ogrenci2.OgrenciNo= 112;
            ogrenci2.Sinif = 1;
            ogrenci2.OgrenciBilgileriniGetir();

            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim {  get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set 
            {
                if(value <=1)
                {
                    Console.WriteLine("Sınıf en düşük 1 olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
                
            } 
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*****Öğrenci Bilgileri*****");
            Console.WriteLine("Öğrenci adı       :{0}", this.Isim);
            Console.WriteLine("Öğrenci soyadı    :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No        :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıfı    :{0}", this.Sinif);
        }

        public void SinifAtla()
        {
            this.Sinif = this.Sinif +1;
        }
         public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }
    }
}
