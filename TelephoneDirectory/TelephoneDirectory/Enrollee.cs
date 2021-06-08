using System;
using System.Collections.Generic;
using System.Text;

namespace TelephoneDirectory
{
    public class Enrollee
    {
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }

         public Enrollee(string name, string surname, int phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;

        }
        public Enrollee()
        {
            
        }
    }
    
}
