using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewShore.APSP.Common;

namespace NewShore.APSP.Controller
{
    /// <summary>
    /// Interface that define the methods that the APSP Controller should support.
    /// </summary>
    public interface IQuery:IDisposable
    {
        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of the whole set of Persons (Villanos + Super Heroes)
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        List<Person> getAllPersons();

        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of Villanos
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        List<Person> getVillanos();

        /// <summary>
        /// This Method should provide a List of <see cref="Person"/> with list of SuperHeroes
        /// </summary>
        /// <returns>
        ///     Returns a List of <see cref="Person"/> 
        /// </returns>
        List<Person> getSuperHeroes();

        /// <summary>
        /// This Method should save a list of Villanos in a File called "VILLANOS.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back the value true if the file was saved successfully and fale in other case
        /// </returns>
        bool saveVillanos();

        /// <summary>
        /// This Method should save a list of SuperHeroes in a File called "SUPERHEROES.DAT"
        /// </summary>
        /// <returns>
        ///     The Method give back the value true if the file was saved successfully and fale in other case
        /// </returns>
        bool saveSuperHeroes();
    }
}
