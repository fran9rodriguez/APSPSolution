using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.APSP.Common
{
    /// <summary>
    /// Class to implement the object Type Person
    /// </summary>
    public class Person: IPerson
    {
        /// <summary>
        /// Name of the Person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the Person <see cref="PersonType"/>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Person() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pName">Name of the Person</param>
        public Person(string pName)
        {
            Name = pName;
            Type = getPersonType(pName);

        }

        /// <summary>
        /// Method to determinate the type of the person
        /// </summary>
        /// <param name="sName">Name of the person</param>
        /// <returns></returns>
        public string getPersonType(string sName)
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
