using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewShore.APSP.Common;
using System.Threading.Tasks;

namespace APSPService
{
    /// <summary>
    /// Proxy to create a type runtime that implements the service contract <see cref="IQueryService"/>
    /// </summary>
    public class QueryProxy:IQueryService
    {
        private readonly IQueryService _target;

        /// <summary>
        /// Function to assing the target value
        /// </summary>
        public static Func<object> TargetFactory;

        /// <summary>
        /// QueryProxy COnstructor which defines the target value
        /// </summary>
        public QueryProxy()
        {
            _target = (IQueryService)TargetFactory();
        }

        #region Sync Methods

        /// <summary>
        /// This Method should provide a JSON object <see cref="QueryResult"/> with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type <see cref="QueryResult"/> that includes the list of Persons in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        public QueryResult getAllPersons()
        {
            return _target.getAllPersons();
        }


        /// <summary>
        /// This Method should provide a JSON object <see cref="QueryResult"/> with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type <see cref="QueryResult"/> that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        public QueryResult getSuperHeroes()
        {
            return _target.getSuperHeroes();
        }

        /// <summary>
        /// This Method should provide a XML object <see cref="QueryResult"/> with the list of Super Heroes
        /// </summary>
        /// <returns>
        ///     Returns a XML object the type <see cref="QueryResult"/> that includes the list of Super Heroes in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        public QueryResult getSuperHeroesXML()
        {
            return _target.getSuperHeroesXML();
        }

        /// <summary>
        /// This Method should provide a JSON object <see cref="QueryResult"/> with the list of Villanos
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type <see cref="QueryResult"/> that includes the list of Villanos in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        public QueryResult getVillanos()
        {
            return _target.getVillanos();
        }

        /// <summary>
        /// This Method should save a list of Villanos in a File called "VILLANOS.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a <see cref="QueryResult"/> JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
        public QueryResult saveVillanos()
        {
            return _target.saveVillanos();
        }

        /// <summary>
        /// This Method should save a list of Super Heroes in a File called "SUPERHEROES.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back a <see cref="QueryResult"/> JSON Object with tha attribute idError = 0 in case that the File was saved sucessfully
        ///     and idError = -1 in case of the file wasnt saved properly.
        /// </returns>
        public QueryResult saveSuperHeroes()
        {
            return _target.saveSuperHeroes();
        }

        #endregion

        #region Async Methods

        /// <summary>
        /// This Method should provide a JSON object <see cref="QueryResult"/> with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a JSON object the type <see cref="QueryResult"/> that includes the list of Persons in the attribute lPersons. 
        ///     In case of Error the attribute lPersons will be null and attribute errorDescription will contain the description of the error
        /// </returns>
        public Task<QueryResult> getAllPersonsAsync()
        {
            return _target.getAllPersonsAsync();
        }

        #endregion
    }
}