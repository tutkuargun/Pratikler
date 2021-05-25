using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:"+ sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata"+ ex.Message.ToString());
            }
            // finally
            // {
            //     Console.WriteLine("işlem tamamlandı.");
            // }

            try
            {
               // int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz. ");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarıyla tamamlandı.");
            }
        }
    }
}
