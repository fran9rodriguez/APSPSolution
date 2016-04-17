using Microsoft.VisualStudio.TestTools.UnitTesting;
using APSPService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NewShore.APSP.Common;

namespace APSPService.Tests
{
    [TestClass()]
    public class ServiceProxyFactoryTests
    {
        private static QueryService CreateSampleService()
        {
            return new QueryService();
        }

        [TestMethod]
        public void GetProxyType_QueryService_ReturnsProxyImplementingInterface()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            Type proxyType = serviceProxyFactory.GetProxyType(typeof(IQueryService), CreateSampleService);
            Assert.IsTrue(typeof(IQueryService).IsAssignableFrom(proxyType));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetProxyType_ConcreteType_ThrowsException()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            serviceProxyFactory.GetProxyType(typeof(QueryService), CreateSampleService);
        }


       [TestMethod]
        public void GetProxyType_QueryService_ReturnCreateableProxy()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            Type proxyType = serviceProxyFactory.GetProxyType(typeof(IQueryService), CreateSampleService);
            var instance = Activator.CreateInstance(proxyType);
            Assert.IsInstanceOfType(instance, typeof(IQueryService));
        }

        [TestMethod]
        public void GetAllPersons_QueryService_ReturnsQueryResult()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            Type proxyType = serviceProxyFactory.GetProxyType(typeof(IQueryService), CreateSampleService);
            var instance = (IQueryService)Activator.CreateInstance(proxyType);
            QueryResult result = instance.getAllPersons();
            Assert.AreEqual(result.lPersons.Count, 1122);            
        }

        [TestMethod]
        public void GetVillanos_QueryService_ReturnsQueryResult()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            Type proxyType = serviceProxyFactory.GetProxyType(typeof(IQueryService), CreateSampleService);
            var instance = (IQueryService)Activator.CreateInstance(proxyType);
            QueryResult result = instance.getVillanos();
            Assert.AreEqual(result.lPersons.Count, 100);
        }

        [TestMethod]
        public void GetSuperHeroes_QueryService_ReturnsQueryResult()
        {
            var serviceProxyFactory = new ServiceProxyFactory();
            Type proxyType = serviceProxyFactory.GetProxyType(typeof(IQueryService), CreateSampleService);
            var instance = (IQueryService)Activator.CreateInstance(proxyType);
            QueryResult result = instance.getSuperHeroes();
            Assert.AreEqual(result.lPersons.Count, 1020);
        }
    }
}