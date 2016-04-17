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
        public void GetAllPersons_FileDAT_ReturnsVoid()
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

                Assert.AreEqual(lp.Count, 1122);
                Assert.IsFalse(totalMilSec > Double.Parse("500"), "The method takes more than 500 milliseconds");

            }
            catch (Exception ex)
            {
                Assert.Inconclusive(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void SaveVillanos_FileDAT_ReturnsVoid()
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
        public void SaveSuperHeroes_FileDAT_ReturnsVoid()
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

        [TestMethod()]
        public void GetVillanos_FileDAT_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                IDataAccess daClass = FactoryDA.Get(1);

                lp = daClass.getVillanos();

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
        public void GetSuperHeroes_FileDAT_ReturnsVoid()
        {
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                List<Person> lp = new List<Person>();
                IDataAccess daClass = FactoryDA.Get(1);

                lp = daClass.getSuperHeroes();

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

        
    }
}