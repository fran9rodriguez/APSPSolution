using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewShore.APSP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common.Tests
{
    [TestClass()]
    public class LoggerTests
    {
        [TestMethod()]
        public void InfoTest()
        {
            try
            {
                using (Logger log = new Logger("LoggerTests", "InfoTest"))
                {
                    log.Info("Message Test Error Debug");
                }
            }
            catch
            {

                Assert.Fail();

            }


        }
    }
}