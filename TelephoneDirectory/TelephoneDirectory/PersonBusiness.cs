using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace TelephoneDirectory
{
    public class PersonBusiness
    {   
        public bool AddPhoneNumber(Enrollee enrollee)
        {
             try
            {
                PersonData.enrollees.Add(enrollee);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
         public List<Enrollee> GetAll(Func<Enrollee,bool> predicate = null)
        {
            return predicate == null
                ? PersonData.enrollees.ToList()
                : PersonData.enrollees.Where(predicate).ToList();
        }
        public Enrollee GetEnrollee(Func<Enrollee, bool> predicate)
        {
            return PersonData.enrollees.FirstOrDefault(predicate);
        }
         public bool RemovePerson(Enrollee enrollee)
        {
            try
            {
                PersonData.enrollees.Remove(enrollee);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool UpdatePerson(Enrollee enrollee)
        {
            try
            {
                var findPerson = PersonData.enrollees.FirstOrDefault(x => x.Name == enrollee.Name && x.Surname == enrollee.Surname);

                if (findPerson == null)
                {
                    return false;
                }
                PersonData.enrollees.FirstOrDefault(x => x.Name == enrollee.Name && x.Surname == enrollee.Surname).PhoneNumber = enrollee.PhoneNumber;

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
