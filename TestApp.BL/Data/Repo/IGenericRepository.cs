using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestApp.BL.Data.Repo
{
    public interface IGenericRepository<T>
    {
        void Add(T model);
        T FindById(Guid id);
        T FindById(int id);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAsync();
        IEnumerable<T> Get();
        void Remove(T model);
        void Update(T item);
       
    }
}