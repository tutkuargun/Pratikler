using System;

namespace DatetimeVeMathSiniflari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddMinutes(45));

            //DateTime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//27
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Per
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Perşembe 

            Console.WriteLine(DateTime.Now.ToString("MM"));//05
            Console.WriteLine(DateTime.Now.ToString("MMM"));//May
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Mayıs

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            Console.WriteLine("****MATH KÜTÜPHANESİ****");

            //math kütüphanesi
            Console.WriteLine(Math.Abs(-4)); // 4
            Console.WriteLine(Math.Sin(10)); // -0,544211110889
            Console.WriteLine(Math.Cos(25)); // 0,991202811863
            Console.WriteLine(Math.Tan(45)); // 1,6197751905438

            
            Console.WriteLine(Math.Ceiling(15.6)); //15.6'dan büyük en küçük tam sayı
            Console.WriteLine(Math.Round(15.6)); // hangisine daha yakınsa
            Console.WriteLine(Math.Floor(15.6)); // aşağıya yuvarlar
            
            Console.WriteLine(Math.Max(4,6));
            Console.WriteLine(Math.Min(4,6));

            Console.WriteLine(Math.Pow(3,4)); //3^4 üs alma
            Console.WriteLine(Math.Sqrt(16)); //karekök alır
            Console.WriteLine(Math.Log(10)); //e tabanında logaritma hesabı
            Console.WriteLine(Math.Exp(3)); // e üzeri 
            Console.WriteLine(Math.Log10(10)); // 10 tabanında logaritma hesabı






        }
    }
}
