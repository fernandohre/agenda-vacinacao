using Vacinacao.Core.Domain;

namespace Vacinacao.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        void Insert(TEntity e);
        void Update(TEntity updated, int key);
        IEnumerable<TEntity> GetAll();
        void Delete(int key);
    }
}
