using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop.Model.Interfaces
{
    /// <inheritdoc cref="IRepository{T}"/>
    public interface IEntityRepository : IRepository<Entity>
    {
    }
}
