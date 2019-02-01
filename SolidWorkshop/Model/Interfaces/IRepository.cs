using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    /// <summary>
    /// Describes the repository.
    /// </summary>
    /// <typeparam name="T">Type of stored data.</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Reads data from storage.
        /// </summary>
        /// <returns>All data.</returns>
        IEnumerable<T> Read();

        /// <summary>
        /// Creates new data in storage.
        /// </summary>
        /// <param name="entity">Data to save.</param>
        void Create(T entity);

    }
}
