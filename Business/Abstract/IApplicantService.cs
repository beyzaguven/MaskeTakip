using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //interface, belli bir methodun imzalarını barındırır.
        //birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlar.
        //kullanıldığı sınıflar için referans tutucudur.
        //new'lenemezler.
        //interface içerisinde methodların imzalarının oluşturulması:

        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
    }
}
