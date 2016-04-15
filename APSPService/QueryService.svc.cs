using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NewShore.APSP.Controller;
using NewShore.APSP.Common;

namespace APSPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QueryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select QueryService.svc or QueryService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class QueryService : IQueryService
    {
        //Object to control the Multiple Concurrence
        readonly object ThisLock = new object();

        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "getAllPersons")]
        public QueryResult getAllPersons()
        {
            try
            {
                using (Query q = new Query())
                {
                    QueryResult result = new QueryResult(0,"OK",q.getAllPersons());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "getVillanos")]
        public QueryResult getVillanos()
        {
            try
            {
                using (Query q = new Query())
                {
                    QueryResult result = new QueryResult(0, "OK", q.getVillanos());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "getSuperHeroes")]
        public QueryResult getSuperHeroes()
        {
            try
            {
                using (Query q = new Query())
                {
                    QueryResult result = new QueryResult(0, "OK", q.getSuperHeroes());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Xml,
                    UriTemplate = "getSuperHeroesXML")]
        public QueryResult getSuperHeroesXML()
        {
            try
            {
                using (Query q = new Query())
                {
                    QueryResult result = new QueryResult(0, "OK", q.getSuperHeroes());
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "saveVillanos")]
        public QueryResult saveVillanos()
        {
            try
            {
                using (Query q = new Query())
                {
                    bool bSave = q.saveVillanos();
                    QueryResult result = new QueryResult();
                    if (bSave) result = new QueryResult(0, "The File was saved sucessfully", q.getVillanos());
                    else result = new QueryResult(-1, "Error. The File was not saved sucessfully");
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        [WebInvoke(Method = "POST",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "saveSuperHeroes")]
        public QueryResult saveSuperHeroes()
        {
            try
            {
                using (Query q = new Query())
                {
                    bool bSave = q.saveSuperHeroes();
                    QueryResult result = new QueryResult();
                    if (bSave) result = new QueryResult(0, "The File was saved sucessfully", q.getSuperHeroes());
                    else result = new QueryResult(-1, "Error. The File was not saved sucessfully");
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

    }
}
