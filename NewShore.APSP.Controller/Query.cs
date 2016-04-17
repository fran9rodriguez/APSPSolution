using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.DA;
using NewShore.APSP.Common;
using System.Configuration;

namespace NewShore.APSP.Controller
{

    /// <summary>
    /// Class that implements all the methods defined in <see cref="IQuery"/>
    /// </summary>
    public class Query:IQuery
    {
        int idDataSource = Int32.Parse(ConfigurationManager.AppSettings["dataSource"].ToString());

        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        public List<Person> getAllPersons()
        {
            try
            {   
                return FactoryDA.Get(idDataSource).getAllPersons();                
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of Villanos
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        public List<Person> getVillanos()
        {
            try
            {
                return FactoryDA.Get(idDataSource).getVillanos();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of SuperHeroes
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        public List<Person> getSuperHeroes()
        {
            try
            {
                return FactoryDA.Get(idDataSource).getSuperHeroes();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// This Method should save a list of Villanos in a File called "VILLANOS.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back the value true if the file was saved successfully and fale in other case
        /// </returns>
        public bool saveVillanos()
        {
            try
            {
                return FactoryDA.Get(idDataSource).saveVillanos();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// This Method should save a list of SuperHeroes in a File called "SUPERHEROES.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back the value true if the file was saved successfully and fale in other case
        /// </returns>
        public bool saveSuperHeroes()
        {
            try
            {
                return FactoryDA.Get(idDataSource).saveSuperHeroes();
            }
            catch
            {
                throw;
            }
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
