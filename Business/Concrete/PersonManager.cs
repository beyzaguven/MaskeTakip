using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person) //person parametresinin Person isimli bir class ile gönderilmesi: Encapsulation kullanımı.
        {

        }

        public List<Person> GetList()  //List yapısı <> içerisinde verilen tipte bir listeyi temsil eder.
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
