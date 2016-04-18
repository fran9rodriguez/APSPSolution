using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NewShore.APSP.Common;
using System.Threading.Tasks;

namespace APSPService
{
    /// <summary>
    /// Interface that define the methods that the APSP WCF Service should provide.
    /// </summary>
    [ServiceContract]
    public interface IQueryService
    {

        #region Sync Methods

        /// <summary>
        /// This Method should provide a JSON object (QueryResult) with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Persons in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        [OperationContract]
        QueryResult getAllPersons();

        /// <summary>
        /// This Method should provide a JSON object (QueryResult) with the list of Villanos
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Villanos in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        [OperationContract]
        QueryResult getVillanos();

        /// <summary>
        /// This Method should provide a JSON object (QueryResult) with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type QueryResult that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        [OperationContract]
        QueryResult getSuperHeroes();

        /// <summary>
        /// This Method should provide a XML object (QueryResult) with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a XML object the type QueryResult that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        [OperationContract]
        QueryResult getSuperHeroesXML();

        /// <summary>
        /// This Method should save a list of Villanos in a File called "VILLANOS.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a QueryResult JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
        [OperationContract]
        QueryResult saveVillanos();

        /// <summary>
        /// This Method should save a list of Super Heroes in a File called "SUPERHEROES.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a QueryResult JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
        [OperationContract]
        QueryResult saveSuperHeroes();

        #endregion

        #region Async Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        Task<QueryResult> getAllPersonsAsync();

        #endregion


    }
}
