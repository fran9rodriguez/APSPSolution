using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewShore.APSP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NewShore.APSP.Common.Tests
{
    [TestClass()]
    public class LoggerTests
    {
        [TestMethod()]
        public void Info_Logger_Returns_Void()
        {
            try
            {
                using (Logger log = new Logger("LoggerTests", "InfoTest"))
                {
                    log.Info("Info Message Test Error Debug");
                }
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Warn_Logger_Returns_Void()
        {
            try
            {
                using (Logger log = new Logger("LoggerTests", "WarnTest"))
                {
                    log.Warn("Warn Message Test Error Debug");
                }
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Fatal_Logger_Returns_Void()
        {
            try
            {
                using (Logger log = new Logger("LoggerTests", "FatalTest"))
                {
                    log.Fatal("Fatal Message Test Error Debug", new IOException());
                }
            }
            catch
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void Error_Logger_Returns_Void()
        {
            try
            {
                using (Logger log = new Logger("LoggerTests", "ErrorTest"))
                {
                    log.Error("Error Message Test Error Debug", new IOException());
                }
            }
            catch
            {
                Assert.Fail();
            }
        }
    }
}