using Microsoft.EntityFrameworkCore;
using Vacinacao.Core.Domain;
using Vacinacao.Infraestrutura.Data;

namespace Vacinacao.Infraestrutura.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected AgendaVacinacaoContext _context { get; set; }
        protected abstract DbSet<TEntity> _dbSet { get; }
        protected BaseRepository(AgendaVacinacaoContext context)
        {
            _context = context;
        }
        public void Insert(TEntity e) 
        { 
            _dbSet.Add(e);
            _context.SaveChanges();
        }

        public void Update(TEntity updated, int key)
        {
            if (updated == null)
                return;

            TEntity? existing = _dbSet.Find(key);

            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
            }

        }

        public IEnumerable<TEntity> GetAll() 
        {
            return _dbSet.AsNoTracking().AsEnumerable();
        }

        public void Delete(int key) 
        {
            var entity = _dbSet.Find(key);
            if (entity != null) 
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
