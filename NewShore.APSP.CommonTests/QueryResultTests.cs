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
    public class QueryResultTests
    {
        [TestMethod()]
        public void NullValue_QueryResults_ReturnsVoid()
        {
            try
            {
                QueryResult q = new QueryResult(0, "OK", null);
                Assert.IsTrue(q.nResults == 0, "The method result should be 0");
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void New_QueryResults_ReturnsVoid()
        {
            try
            {
                List<Person> lPerson = new List<Person>();
                Person p = new Person("A");
                lPerson.Add(p);

                p = new Person("B");
                lPerson.Add(p);

                p = new Person("C");
                lPerson.Add(p);

                p = new Person("D");
                lPerson.Add(p);


                QueryResult q = new QueryResult(0, "OK", lPerson);
                Assert.IsTrue(q.nResults == 4, "The method result should be 4");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message.ToString());
            }
        }

        [TestMethod()]
        public void NewError_QueryResults_ReturnsVoid()
        {
            try
            {
                QueryResult q = new QueryResult(0, "Error Description");
                Assert.IsTrue(q.errorDescription == "Error Description", "The description is not equal");
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message.ToString());
            }
        }
    }
}