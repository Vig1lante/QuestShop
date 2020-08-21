using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public class UserRepository : ICrudRepository<AppUser>
    {
        private readonly QuestShopDbContext _questShopDbContext;
        public UserRepository(QuestShopDbContext questShopDbContext)
        {
            _questShopDbContext = questShopDbContext;
        }
        public Task Add(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AppUser>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(AppUser entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(AppUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
