using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Configuration;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Proxy Class that implements the method to store the logs of the Aplication.
    /// This class uses <see cref="FactoryLogger"/> to obtain the class of the current Loggin system defined in 
    /// the Web.cofing in the attribute idLogger. Currently this project is using Loggly System (idLogger = 1)
    /// </summary>
    public class Logger: ILogger
    {
        int idLogger = Int32.Parse(ConfigurationManager.AppSettings["idLogger"].ToString());

        /// <summary>
        /// Class where the event to log is happening
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        /// Method where the event to log is happening
        /// </summary>
        public string Method { get; set; }

        #region Methods

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pClass">Class where the event to log is happening</param>
        /// <param name="pMethod">MEthod where the event to log is happening</param>
        public Logger(string pClass, string pMethod)
        {
            Class = pClass;
            Method = pMethod;
        }

        /// <summary>
        /// Method that store a message of Type Info
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        public void Info(string pMessage)
        {
            FactoryLogger.Get(idLogger).Info(pMessage);
        }

        /// <summary>
        /// Method that store a message of Type Warning
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        public void Warn(string pMessage)
        {
            FactoryLogger.Get(idLogger).Warn(pMessage);
        }

        /// <summary>
        /// Method that store a message when a Fatal Error happens. That means high priority
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        public void Fatal(string pMessage, Exception e)
        {
            FactoryLogger.Get(idLogger).Fatal(pMessage,e);
        }

        /// <summary>
        /// Method that store a message when a Normal Error happens. That means medium priotity
        /// </summary>
        /// <param name="pMessage">Message to store in the Logging system</param>
        /// <param name="e">Exception</param>
        public void Error(string pMessage, Exception e)
        {
            FactoryLogger.Get(idLogger).Error(pMessage, e);
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

