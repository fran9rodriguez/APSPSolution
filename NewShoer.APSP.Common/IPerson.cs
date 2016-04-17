using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Interface that defines the methods  to implement an object Person (Villano or Superheroe) 
    /// </summary>
    public interface IPerson: IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sName"></param>
        /// <returns></returns>
        string getPersonType(string sName);
    }
}
