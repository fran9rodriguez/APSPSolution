using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NewShore.APSP.Common;

namespace APSPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQueryService" in both code and config file together.
    [ServiceContract]
    public interface IQueryService
    {
        [OperationContract]
        QueryResult getAllPersons();

        [OperationContract]
        QueryResult getVillanos();

        [OperationContract]
        QueryResult getSuperHeroes();

        [OperationContract]
        QueryResult getSuperHeroesXML();

        [OperationContract]
        QueryResult saveVillanos();

        [OperationContract]
        QueryResult saveSuperHeroes();
    }
}
