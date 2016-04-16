using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    public class Person: IPerson
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Person() { }

        public Person(string pName)
        {
            Name = pName;
            Type = getPersonType(pName);

        }

        private string getPersonType(string sName)
        {
            
            string sType = PersonType.SuperHeroe;
            try
            {
                if(sName == "" || sName == "NULL") sType = PersonType.Other;
                else if (sName.Contains("D")) sType = PersonType.Villano;
            }
            catch
            {
                sType = PersonType.Other;
            }

            return sType;
        }

        #region IDisposable

        void IDisposable.Dispose()
        {
            Close();
        }
        public void Close()
        {
            System.GC.SuppressFinalize(this);
        }

        #endregion

    }
}
