using CvProject.Models.Entities;
using System.Linq.Expressions;

namespace CvProject.Repositories
{
    public class GenericRepository<T>where T : class,new()
    {
        CvDbContext cvDbContext=new CvDbContext();
        public List<T> List()
        {
            return cvDbContext.Set<T>().ToList();

        }
        public void Add(T t)
        {
            cvDbContext.Set<T>().Add(t);
            cvDbContext.SaveChanges();
        }
        public void Delete(T t)
        {
            cvDbContext.Set<T>().Remove(t);
            cvDbContext.SaveChanges();
        }
        public T Get(int id)
        {
            return cvDbContext.Set<T>().Find(id);
        }
        public void Update(T t)
        {
            cvDbContext.Set<T>().Update(t);
            cvDbContext.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> filter)
        {
            return cvDbContext.Set<T>().FirstOrDefault(filter);
        }
    }
}
