
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestApp.BL.Model;
using TestApp.BL.Data.Repo;

namespace TestApp.BL.Data.Repo
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
         where TEntity : class
         where TContext : CompanyDBContext


    {
    
        protected readonly TContext Context;

       
        protected GenericRepository(TContext context)
        {
            this.Context = context;
        }

        public  IEnumerable<TEntity> Get()
        {
            return Context.Set<TEntity>().ToList();
        }
        public  async Task<TEntity> GetByIdAsync(int id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public TEntity FindById(Guid id)
        {
            return Context.Set<TEntity>().Find(id);

        }
        public TEntity FindById(int id)
        {
            return Context.Set<TEntity>().Find(id);

        }

        public void Add(TEntity model)
        {
            Context.Set<TEntity>().Add(model);
            Context.SaveChanges();
        }
      

        public void Update(TEntity item)
        {
            Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }


        public void Remove(TEntity model)
        {
            Context.Set<TEntity>().Remove(model);
            Context.SaveChanges();
        }

      
    }
}
