using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuestShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Data
{
    public static class SeedMockData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuestShopDbContext(serviceProvider.GetRequiredService<DbContextOptions<QuestShopDbContext>>()))
            {
                if (context.Quests.Any())
                {
                    return;
                }
                context.Quests.AddRange(
                    new Quest
                    {
                        Name = "Codewar Fanatic",
                        Details = "Do 10 Katas in one day and send them to your mentor",
                        Points = 25,
                        CompletionDate = DateTime.Today,
                        Stock = true,
                        QuestOfTheWeek = true
                    },
                     new Quest
                     {
                         Name = "Code review madness",
                         Details = "Review code from five of your friend's repositories",
                         Points = 50,
                         CompletionDate = DateTime.Today,
                         Stock = true,
                         QuestOfTheWeek = false
                     },
                      new Quest
                      {
                          Name = "Listen to what i say",
                          Details = "Give a presentation on your current project",
                          Points = 75,
                          CompletionDate = DateTime.Today,
                          Stock = true,
                          QuestOfTheWeek = true
                      },
                       new Quest
                       {
                           Name = "To push is to commit",
                           Details = "Add 50 meaningful contributions to your repository in one week",
                           Points = 75,
                           CompletionDate = DateTime.Today,
                           Stock = true,
                           QuestOfTheWeek = false
                       },
                        new Quest
                        {
                            Name = "Here's my two cents, my two cents are free",
                            Details = "Contribute to an open-source project",
                            Points = 150,
                            CompletionDate = DateTime.Today,
                            Stock = false,
                            QuestOfTheWeek = false
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
