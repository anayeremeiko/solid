using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    /// <inheritdoc cref="IEntity"/>
    public class Entity : IEntity
    {
        /// <inheritdoc cref="IEntity"/>
        public int Id { get; set; }

        /// <summary>
        /// The date of creation.
        /// </summary>
        public DateTime CreatedDate { get; set; }
    }
}
