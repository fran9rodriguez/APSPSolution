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
    public class Query:IQuery
    {
        static int idSource = Int32.Parse(ConfigurationManager.AppSettings["dataSource"].ToString());

        public List<Person> getAllPersons()
        {
            try
            {   
                return FactoryDA.Get(idSource).getAllPersons();                
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
                return FactoryDA.Get(idSource).getVillanos();
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
                return FactoryDA.Get(idSource).getSuperHeroes();
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
                return FactoryDA.Get(idSource).saveVillanos();
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
                return FactoryDA.Get(idSource).saveSuperHeroes();
            }
            catch (Exception ex)
            {
                throw ex;
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
