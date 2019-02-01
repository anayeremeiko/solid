using System;
using System.Collections.Generic;
using SolidWorkshop.BLL;
using SolidWorkshop.Model.Interfaces;

namespace SolidWorkshop
{
    public class EntityService : IService<Entity>
    {
        private readonly IEntityRepository repository;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityService"/> class.
        /// </summary>
        /// <param name="repo">The data provider.</param>
        /// <param name="logger">The logger.</param>
        public EntityService(IEntityRepository repo, ILogger logger)
        {
            repository = repo ?? throw new ArgumentNullException($"{nameof(repo)} need to be not null.");
            this.logger = logger ?? throw new ArgumentNullException($"{nameof(logger)} need to be not null.");
        }

        /// <inheritdoc cref="IService{T}"/>
        public void Save(Entity entity)
        {
            try
            {
                repository.Create(entity);
            }
            catch (Exception e)
            {
                logger.Log($"Exception {e} occur during the execution of Save method: {e.Message}");
                throw e;
            }
        }

        /// <inheritdoc cref="IService{T}"/>
        public IEnumerable<Entity> ReadAll()
        {
            IEnumerable<Entity> entities;
            try
            {
                entities = repository.Read();
            }
            catch (Exception e)
            {
                logger.Log($"Exception {e} occur during the execution of ReadAll method: {e.Message}");
                throw e;
            }

            return entities;
        }

    }
}
