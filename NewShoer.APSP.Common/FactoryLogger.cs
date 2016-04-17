using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Static Class that implements the Factory Patter Design for the Logger system
    /// </summary>
    public static class FactoryLogger
    {
        /// <summary>
        /// Mathod that give back the <see cref="ILogger"/> object depending of the id
        /// </summary>
        /// <param name="id">Class Identifier. 1.Loggly, 2.XML </param>
        /// <returns>
        ///     Returns a <see cref="ILogger"/> object depending of the id
        /// </returns>
        public static ILogger Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new Loggly();
                default:
                    return new Loggly();
            }
        }
    }
}
