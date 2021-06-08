using System;
using System.Collections.Generic;

namespace TelephoneDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Starting();
            List<Enrollee> enrollees = new List<Enrollee>
            {
               
            };


        }

        static void Starting()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Varolan Numarayı Sil");
            Console.WriteLine("(3) Varolan Numarayı Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yap");

            int Choosen = int.Parse(Console.ReadLine());
            

            
            switch (Choosen)
            {
               case 1:
                    AddNewPhoneNumber(); 
                    break;
               case 2:
                   DeletePhoneNumber();
                   break;
               case 3:
                   ChangePhoneNumber();
                   break;
               case 4:
                    ShowPhoneBook();
                    break;
               case 5:
                   SearchPerson();
                   break;
               default:
                   Console.WriteLine("Geçersiz giriş yaptınız!");
                   break;
            }

        }
        

        private static void AddNewPhoneNumber()
        {
           var enrollee = new Enrollee();
           Console.WriteLine("Lütfen isim giriniz:");
           enrollee.Name = Console.ReadLine();
           Console.WriteLine("Lütfen soyisim giriniz:");
           enrollee.Surname = Console.ReadLine();
           Console.WriteLine("Lütfen telefon numarası giriniz:");
           enrollee.PhoneNumber = int.Parse(Console.ReadLine());

           PersonBusiness personBusiness = new PersonBusiness();
           var result = personBusiness.AddPhoneNumber(enrollee);
           
           if(result)
                Console.WriteLine("Numara Eklendi.");
            else
                Console.WriteLine("Numara Eklenemedi.");
            Starting();
           
        }

        static void DeletePhoneNumber()
        {
            Console.WriteLine("Lütfen Silmek İstediğiniz Kişinin Adını veya Soyadını Giriniz.");
            string input = Console.ReadLine().ToLower();

            PersonBusiness personBusiness = new PersonBusiness();
            var findPerson = personBusiness.GetEnrollee(x => x.Name.ToLower()== input || x.Surname.ToLower() == input);
            if (findPerson == null)
            {
                Console.WriteLine("Kullanıcı Bulunamadı. Bir Seçim Yapınız.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");

                int input2 = int.Parse(Console.ReadLine());
                if(input2 == 1)
                {
                    Starting();
                }
                else if(input2 == 2)
                {
                    DeletePhoneNumber();
                }
            }
            else
            {
                Console.WriteLine($"{findPerson.Name} {findPerson.Surname} İsimli, {findPerson.PhoneNumber} Numaralı Kullanıcı Siliniyor. Onaylıyor Musunuz ? (y/n)");
                string input3 = Console.ReadLine().ToLower();
                if (input3 == "y")
                {
                    var result = personBusiness.RemovePerson(findPerson);

                    if(result)
                        Console.WriteLine("Kullanıcı Silindi.");
                    else 
                        Console.WriteLine("Kullanıcı Silinemedi.");

                }
                Starting();
            }



        }
        static void ChangePhoneNumber()
        {
            Console.WriteLine("Lütfen Güncellemek İstediğiniz Kişinin Adını veya Soyadını Giriniz.");
            string input = Console.ReadLine().ToLower();

            PersonBusiness personBusiness = new PersonBusiness();
            var findPerson = personBusiness.GetEnrollee(x => x.Name.ToLower()== input || x.Surname.ToLower() == input);
            if (findPerson == null)
            {
                Console.WriteLine("Kullanıcı Bulunamadı. Bir Seçim Yapınız.");
                Console.WriteLine("Ana Menüye Dön (1)");
                Console.WriteLine("Tekrar Dene (2)");
                int input2 = int.Parse(Console.ReadLine());
                if(input2 == 1)
                {
                    Starting();
                }
                else if(input2 == 2)
                {
                    ChangePhoneNumber();
                }

            }  
            else
            {
               Console.WriteLine($"{findPerson.Name} {findPerson.Surname} İsimli Kullanıcının Mevcut Numarası : {findPerson.PhoneNumber}");
               Console.WriteLine("Yeni Telefon Numarasını Giriniz.");
               int phoneNumber = int.Parse(Console.ReadLine());
               findPerson.PhoneNumber = phoneNumber;
               var result = personBusiness.UpdatePerson(findPerson);

               if(result)
                   Console.WriteLine("Kullanıcı Güncellendi.");
               else
                   Console.WriteLine("Kullanıcı Güncellenemedi.");  
                Starting();
            }



        }
        static void ShowPhoneBook()
        {
            PersonBusiness personBusiness = new PersonBusiness();
            personBusiness.GetAll().ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.Surname} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
            Starting();
            
        }
        static void SearchPerson()
        {
            Console.WriteLine("Arama Yapmak İstediğiniz Tipi Seçiniz.");
            Console.WriteLine("*************************************************");

            Console.WriteLine("İsim veya Soyisime göre arama yap (1)");
            Console.WriteLine("Telefon Numarasına göre arama yap (2)");

            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("İsim veya Soyisim Giriniz.");
                string name = Console.ReadLine().ToLower();

                PersonBusiness personBusiness = new PersonBusiness();
                Console.WriteLine("Bulunan Sonuçlar");
                personBusiness.GetAll(x=>x.Name.ToLower() == name || x.Surname.ToLower() == name)
                    .ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.Surname} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
                Starting();
            }
            else if (input == 2)
            {
                Console.WriteLine("Numara Giriniz.");
                int phoneNumber = int.Parse(Console.ReadLine());

                PersonBusiness personBusiness = new PersonBusiness();
                Console.WriteLine("Bulunan Sonuçlar");
                personBusiness.GetAll(x => x.PhoneNumber == phoneNumber)
                    .ForEach(x => Console.WriteLine($" İsim : {x.Name} \n Soyisim : {x.Surname} \n Numara : {x.PhoneNumber} \n --------------------------------------"));
                Starting();

            }
        }
        
    }
}
