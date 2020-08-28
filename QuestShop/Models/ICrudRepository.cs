using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public interface ICrudRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Remove(T entity);
        Task Update(T entity);   
        Task<T> GetById(int id);

    }
}
