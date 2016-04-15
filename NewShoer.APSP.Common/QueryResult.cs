using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    public class QueryResult
    {
        public int idError { get; set; }
        public string errorDescription { get; set; }
        public int nResults { get; set; }
        public List<Person> lPersons { get; set; }

        public QueryResult() { }

        public QueryResult(int pidError, string perrorDescription, List<Person> plPersons)
        {
            idError = pidError;
            errorDescription = perrorDescription;
            nResults = 0;
            lPersons = new List<Person>();
            if (lPersons != null)
            {
                nResults = plPersons.Count;
                lPersons = plPersons;
            }
        }

        public QueryResult(int pidError, string perrorDescription)
        {
            idError = pidError;
            errorDescription = perrorDescription;
            nResults = 0;
            lPersons = new List<Person>();
        }
    }
}
