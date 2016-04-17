using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.DA
{
    /// <summary>
    /// Static Class that implements the Factory Patter Design for the DA Layer
    /// </summary>
    public static class FactoryDA
    {
        /// <summary>
        /// Mathod that give back the <see cref="IDataAccess"/> object depending of the id
        /// </summary>
        /// <param name="id">Class Identifier. 1.FileDAT, 2.SQL </param>
        /// <returns>
        ///     Returns a <see cref="IDataAccess"/> object depending of the id
        /// </returns>
        public static IDataAccess Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new FileDAT();
                default:
                    return new FileDAT();
            }
        }
    }
}
