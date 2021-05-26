using System;

namespace HataYonetimi_Debugging
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
            finally
            {
                Console.WriteLine("işlem tamamlandı.");
            }
        }
    }
}
