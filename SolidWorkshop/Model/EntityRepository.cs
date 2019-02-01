using System;
using System.Collections.Generic;
using System.Data;
using SolidWorkshop.Model.Interfaces;

namespace SolidWorkshop
{
    /// <inheritdoc cref="IEntityRepository"/>
    public class EntityRepository : IEntityRepository
    {
        private readonly IDbConnection connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityRepository"/> class.
        /// </summary>
        /// <param name="uow">Database connection.</param>
        public EntityRepository(IDbConnection uow)
        {
            connection = uow ?? throw new ArgumentNullException($"{nameof(uow)} need to be not null.");
        }

        /// <inheritdoc cref="IEntityRepository"/>
        public IEnumerable<Entity> Read()
        {
            connection.Open();
            //perform Read
            connection.Close();
            return new List<Entity>();
        }

        /// <inheritdoc cref="IEntityRepository"/>
        public void Create(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} need to be not null.");
            }

            connection.Open();
            //perform Save
            connection.Close();
        }
    }
}
