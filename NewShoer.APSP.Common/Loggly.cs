using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Class that implements the <see cref="ILogger"/> methods in order to store the informaion in the Loggly System
    /// </summary>
    public class Loggly:ILogger
    {
        /// <summary>
        /// Logger
        /// </summary>
        ILog logger = LogManager.GetLogger("APSPService");

        #region Public

        /// <summary>
        /// Method that store a message of Type Info
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        public void Info(string pMessage)
        {
            try
            {
                logger.Info(pMessage);
            }
            catch { }
        }

        /// <summary>
        /// Method that store a message of Type Warning
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        public void Warn(string pMessage)
        {
            try
            {
                logger.Warn(pMessage);
            }
            catch { }
        }

        /// <summary>
        /// Method that store a message when a Fatal Error happens. That means high priority
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        public void Fatal(string pMessage, Exception e)
        {
            try
            {
                logger.Fatal(pMessage, e);
            }
            catch { }
        }

        /// <summary>
        /// Method that store a message when a Normal Error happens. That means medium priotity
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        public void Error(string pMessage, Exception e)
        {
            logger.Error(pMessage, e);
        }

        #endregion

        #region IDisposable

        void IDisposable.Dispose()
        {
            Close();
        }
        public void Close()
        {
            // Do what's necessary to close the file
            System.GC.SuppressFinalize(this);
        }

        #endregion
    }
}

