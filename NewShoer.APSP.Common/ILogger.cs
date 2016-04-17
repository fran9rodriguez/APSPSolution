using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Interface that implements the neccesary methos to implent in a Logging Class
    /// </summary>
    public interface ILogger:IDisposable
    {
        /// <summary>
        /// Method that store a message of Type Info
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        void Info(string pMessage);

        /// <summary>
        /// Method that store a message of Type Warning
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        void Warn(string pMessage);

        /// <summary>
        /// Method that store a message when a Fatal Error happens. That means high priority
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        void Fatal(string pMessage, Exception e);

        /// <summary>
        /// Method that store a message when a Normal Error happens. That means medium priotity
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        void Error(string pMessage, Exception e);
        
    }
}
