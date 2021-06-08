using System.Collections.Generic;
namespace TelephoneDirectory
{
    public static class PersonData
    {
         public static List<Enrollee> enrollees;

         static PersonData()
         {
             enrollees = InitializePersons();
         }

         static List<Enrollee> InitializePersons()
        {
            return new List<Enrollee>()
            {
               new Enrollee {Name = "Tutku", Surname ="Argun", PhoneNumber = 126547454},
               new Enrollee {Name = "Sedef", Surname ="Sev", PhoneNumber = 316549454},
               new Enrollee {Name = "Furkan", Surname ="Osman", PhoneNumber = 427417454},
               new Enrollee {Name = "Özge", Surname ="Argun", PhoneNumber = 413574543},
               new Enrollee {Name = "Gürcan", Surname ="Akın", PhoneNumber = 452367454},
            };

        }
    }
}