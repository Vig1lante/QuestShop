using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public class CrudRepository<T> : ICrudRepository<T> where T : class
    {
        private readonly QuestShopDbContext _questShopDbContext;

        public CrudRepository(QuestShopDbContext questShopDbContext)
        {
            _questShopDbContext = questShopDbContext;
        }
        public async Task Add(T entity)
        {
            await _questShopDbContext.Set<T>().AddAsync(entity);
            await _questShopDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _questShopDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _questShopDbContext.Set<T>().FindAsync(id);
        }


        public Task Remove(T entity)
        {
            _questShopDbContext.Set<T>().Remove(entity);
            return _questShopDbContext.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            _questShopDbContext.Entry(entity).State = EntityState.Modified;
            return _questShopDbContext.SaveChangesAsync();
        }
    }
}
