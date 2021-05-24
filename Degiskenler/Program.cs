using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger = 2; 
            string degisken = null ; 
            string Degisken = null; // case sensitive 
            string white_space = " "; 

            byte b = 5;     //0-255 arası değer , 1 byte
            sbyte c = 5;    //-128 ile 127 arası değer alır , 1 byte

            short s = 5;    // 2 byte 
            ushort us = 5; 

            Int16 i16 = 2 ; // 2 byte
            int i = 2;      // 4 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 2;     // 8 byte
            ulong ul = 2;   // 8 byte

            //reel sayılar 
            float f = 5;    // 4 byte
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';        // 2 byte
            string str = "tutku"; //sınırsız 

            bool bl = true;
            bool bl2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "kelime";
            object o2 = 'a';
            object o3 = 4; 
            object o4 = 4.2; 

            //string ifadeler 
            string str1 = string.Empty;
            str1 = "Tutku Argun";
            string ad = "Tutku" ;
            string soyad = "Argun";
            string tamAd = ad + " " +soyad ;

            //integer tanımlama şekilleri 
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;
            
            //boolean 
            bool bool1 = 10<2;

            //DEĞİŞKEN DÖNÜŞÜMLERİ 
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);  //çıktısı 2020 

            int yeni = int20 + Convert.ToInt32(str20);
            Console.WriteLine(yeni);      // çıktısı 40 

            int int21 = int20 + int.Parse(str20);
            Console.WriteLine(int21);    //Çıktısı 40 

            //datetime
            string datetime = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);






            




        }
    }
}
