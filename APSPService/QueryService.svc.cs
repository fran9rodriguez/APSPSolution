using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using NewShore.APSP.Controller;
using NewShore.APSP.Common;

/// <summary>
/// APSPService is part of the Solution implemented to carry out the APSP Project. 
/// This service will be mainly consumed bu the GUI APSPUI
/// </summary>
namespace APSPService
{
    /// <summary>
    /// WCF Service that provides a set of methods to get and save Villanos and SuperHeroes data
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class QueryService : IQueryService
    {
        //Object to control the Multiple Concurrence
        readonly object ThisLock = new object();

        /// <summary>
        /// GET Method that provides a JSON object (QueryResult) with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Persons in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "getAllPersons")]
        public QueryResult getAllPersons()
        {
            try
            {
                using (Query q = new Query())
                {
                    return new QueryResult(0,"OK",q.getAllPersons());                    
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        /// <summary>
        /// GET Method that provides a JSON object (QueryResult) with the list of Villanos
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Villanos in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
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

        /// <summary>
        /// GET Method that provides a JSON object (QueryResult) with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
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

        /// <summary>
        /// GET Method that provides a XML object (QueryResult) with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a XML object the type QueryResult that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
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

        /// <summary>
        /// POST Method to save the list of Villanos in a File called "VILLANOS.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a QueryResult JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
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
                    if (bSave) result = new QueryResult(0, "The File was saved sucessfully.", q.getVillanos());
                    else result = new QueryResult(-1, "Error. The File was not saved sucessfully.");
                    return result;
                }
            }
            catch (Exception ex)
            {
                return new QueryResult(-1, ex.Message.ToString());
            }
        }

        /// <summary>
        /// POST Method to save the list of Super Heroes in a File called "SUPERHEROES.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a QueryResult JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
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
                    if (bSave) result = new QueryResult(0, "The File was saved sucessfully.", q.getSuperHeroes());
                    else result = new QueryResult(-1, "Error. The File was not saved sucessfully.");
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
