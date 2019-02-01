using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IService<T>
    {
        /// <summary>
        /// Reads entities from data provider.
        /// </summary>
        /// <returns>All entities.</returns>
        IEnumerable<T> ReadAll();

        /// <summary>
        /// Saves entity to data provider.
        /// </summary>
        /// <param name="entity">Entity to save.</param>
        void Save(T entity);
    }
}
