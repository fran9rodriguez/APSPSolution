using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.Common;

namespace NewShore.APSP.Controller
{
    public interface IQuery:IDisposable
    {
        List<Person> getAllPersons();
        List<Person> getVillanos();
        List<Person> getSuperHeroes();


        bool saveVillanos();
        bool saveSuperHeroes();
    }
}
