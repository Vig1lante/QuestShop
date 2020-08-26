using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuestShop.Models;

namespace QuestShop.Data
{
    public class QuestShopDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<UserQuest> UsersQuests { get; set; }
        public QuestShopDbContext(DbContextOptions<QuestShopDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new UserQuestConfiguration());
        }
    }
}
