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

        string registradosPath = ConfigurationManager.AppSettings["registradosPath"].ToString();
        string villanosPath = ConfigurationManager.AppSettings["villanosPath"].ToString();
        string superHeroesPath = ConfigurationManager.AppSettings["superHeroesPath"].ToString();

        #region Public       

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

        private List<Person> fileQuery(string filename)
        {
            try
            {
                var qPerson = from person in File.ReadAllLines(filename)
                                 select new Person(person);

                return qPerson.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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
