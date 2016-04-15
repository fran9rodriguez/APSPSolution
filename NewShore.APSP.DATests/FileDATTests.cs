using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewShore.APSP.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.Common;
using System.Diagnostics;

namespace NewShore.APSP.DA.Tests
{
    [TestClass()]
    public class FileDATTests
    {
        [TestMethod()]
        public void getAllPersonsFromFileTest()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                IDataAccess daClass = FactoryDA.Get(1);
                                  
                lp = daClass.getAllPersons();
                
                sw.Stop();
                Double totalMilSec = sw.Elapsed.TotalMilliseconds;
                Assert.AreEqual(lp.Count, 1118);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void saveVillanosTest()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                
                bool bSave = false;
                IDataAccess daClass = FactoryDA.Get(1);
                
                bSave = daClass.saveVillanos();
                

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
        public void saveSuperHeroesTest()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                bool bSave = false;
                IDataAccess daClass = FactoryDA.Get(1);

                bSave = daClass.saveSuperHeroes();

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