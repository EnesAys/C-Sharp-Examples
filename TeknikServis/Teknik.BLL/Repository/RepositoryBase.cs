using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknik.DAL;

namespace Teknik.BLL.Repository
{
   public class RepositoryBase<T,ID> where T:class
    {
        protected internal static TeknikContext dbContext;

        public List<T> GetAll()
        {
            dbContext = new TeknikContext();
            return dbContext.Set<T>().ToList();
        }
        public T GetByID(ID id)
        {
            dbContext = new TeknikContext();
            return dbContext.Set<T>().Find(id);
        }
        public virtual int Insert(T entity)
        {
            try
            {
                dbContext = dbContext ?? new TeknikContext();
                dbContext.Set<T>().Add(entity);
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int Delete(T entity)
        {
            try
            {
                dbContext = dbContext ?? new TeknikContext();
                dbContext.Set<T>().Remove(entity);
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual int Update()
        {
            try
            {
                dbContext = dbContext ?? new TeknikContext();
                return dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
