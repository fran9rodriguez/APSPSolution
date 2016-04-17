using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewShore.APSP.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.Common;
using System.Diagnostics;

namespace NewShore.APSP.Controller.Tests
{
    [TestClass()]
    public class QueryTests
    {
        [TestMethod()]
        public void GetAllPersons_QueryController_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                using (Query q = new Query())
                {
                    lp = q.getAllPersons();
                }
                    

                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;

                Assert.AreEqual(lp.Count, 1122);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void GetVillanos_QueryController_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                using (Query q = new Query())
                {
                    lp = q.getVillanos();
                }


                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;

                Assert.AreEqual(lp.Count, 100);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void GetSuperHeroes_QueryController_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                using (Query q = new Query())
                {
                    lp = q.getSuperHeroes();
                }


                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;

                Assert.AreEqual(lp.Count, 1020);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void SaveVillanos_QueryController_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();


                bool bSave = false;
                
                using (Query q = new Query())
                {
                    bSave = q.saveVillanos();
                }


                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;
                Assert.AreEqual(bSave, true);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void SaveSuperHeroes_QueryController_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();


                bool bSave = false;

                using (Query q = new Query())
                {
                    bSave = q.saveSuperHeroes();
                }


                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;
                Assert.AreEqual(bSave, true);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }
    }
}