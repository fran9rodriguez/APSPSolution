using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.Common;
using System.IO;
using System.Configuration;

namespace NewShore.APSP.DA
{
    public class FileDAT:IDataAccess
    {
        /// <summary>
        /// variables with the source data path. see web.config for updating
        /// </summary>
        string registradosPath = ConfigurationManager.AppSettings["registradosPath"].ToString();
        string villanosPath = ConfigurationManager.AppSettings["villanosPath"].ToString();
        string superHeroesPath = ConfigurationManager.AppSettings["superHeroesPath"].ToString();

        #region Public       

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
                return fileQuery(registradosPath);
            }
            catch (Exception ex)
            {
                throw ex;
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
                return fileQuery(villanosPath);
            }
            catch (Exception ex)
            {
                throw ex;
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
                return fileQuery(superHeroesPath);
            }
            catch (Exception ex)
            {
                throw ex;
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
                List<Person> lVillanos = getAllPersons().Where(p => p.Type == PersonType.Villano).ToList();
                return saveListOfPerson(lVillanos, villanosPath);
            }
            catch (Exception ex)
            {
                throw ex;
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
                List<Person> lSuperHeroes = getAllPersons().Where(p => p.Type == PersonType.SuperHeroe).ToList();
                return saveListOfPerson(lSuperHeroes, superHeroesPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Private

        /// <summary>
        /// Method that extract the List of Persons from a file
        /// </summary>
        /// <param name="filePath">path of the file with the list of Person</param>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        private List<Person> fileQuery(string filePath)
        {
            try
            {
                var qPerson = from person in File.ReadAllLines(filePath)
                              select new Person(person);

                return qPerson.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This Method should save a list of Persons in a File determinated in fileName attribute
        /// </summary>
        /// <param name="lperson"> List of Persons</param>
        /// <param name="fileName"> file where the data should be stored </param>
        /// <returns></returns>
        private bool saveListOfPerson(List<Person> lperson, string fileName)
        {
            bool bSave = false;

            try
            {
                var buffer = new StringBuilder();                
                lperson.ForEach(item => buffer.AppendLine(String.Format("{0}", item.Name)));
                File.WriteAllText(fileName, buffer.ToString());
                bSave = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bSave;
        }

        #endregion

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
