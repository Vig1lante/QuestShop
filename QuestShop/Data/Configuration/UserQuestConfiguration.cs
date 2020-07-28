using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuestShop.Models;

namespace QuestShop.Entities.Configuration {
    public class UserQuestConfiguration : IEntityTypeConfiguration<UserQuest> {
        public void Configure(EntityTypeBuilder<UserQuest> builder) {
            builder.HasKey(uq => new { uq.UserId, uq.QuestId });

            builder.HasOne(u => u.User)
                .WithMany(q => q.Quests)
                .HasForeignKey(u => u.UserId);

            builder.HasOne(q => q.Quest)
                .WithMany(u => u.Users)
                .HasForeignKey(q => q.QuestId);
        }
    }
}
