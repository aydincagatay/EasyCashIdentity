using EasyCashIdentity.DataAccessLayer.Abstract;
using EasyCashIdentity.DataAccessLayer.Concrete;

namespace EasyCashIdentity.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public Task AddAsync(T entity)
        {
            using var context = new Context();
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return Task.CompletedTask; 
        }

        public Task DeleteAsync(T entity)
        {
            using var context = new Context();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
            return Task.CompletedTask;
        }

        public List<T> GetAllAsync()
        {
            using var context = new Context();
            return context.Set<T>().ToList(); 
        }

        public T GetByIdAsync(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public Task UpdateAsync(T entity)
        {
            var context = new Context();
            context.Set<T>().Update(entity);
            context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
