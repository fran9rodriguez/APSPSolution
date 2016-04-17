using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Class that implements the attributes of the method service answer
    /// </summary>
    public class QueryResult
    {
        /// <summary>
        /// Error identifier
        /// </summary>
        public int idError { get; set; }

        /// <summary>
        /// Error Description
        /// </summary>
        public string errorDescription { get; set; }

        /// <summary>
        /// Number of Results
        /// </summary>
        public int nResults { get; set; }

        /// <summary>
        /// List of Persons
        /// </summary>
        public List<Person> lPersons { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public QueryResult() { }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pidError">Error Identifier</param>
        /// <param name="perrorDescription">Error Description</param>
        /// <param name="plPersons">Person List</param>
        public QueryResult(int pidError, string perrorDescription, List<Person> plPersons)
        {
            idError = pidError;
            errorDescription = perrorDescription;
            nResults = 0;
            lPersons = new List<Person>();
            if (plPersons != null)
            {
                nResults = plPersons.Count;
                lPersons = plPersons;
            }
        }

        /// <summary>
        /// Constructor with paramenters
        /// </summary>
        /// <param name="pidError">Error Identifier</param>
        /// <param name="perrorDescription">Error Description</param>
        public QueryResult(int pidError, string perrorDescription)
        {
            idError = pidError;
            errorDescription = perrorDescription;
            nResults = 0;
            lPersons = new List<Person>();

            
        }
    }
}
