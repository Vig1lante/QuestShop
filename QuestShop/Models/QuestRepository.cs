using QuestShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public class QuestRepository : IQuestRepository
    {
        private readonly QuestShopDbContext _questShopDbContext;

        public QuestRepository(QuestShopDbContext questShopDbContext)
        {
            _questShopDbContext = questShopDbContext;
        }

        public IEnumerable<Quest> AllQuests()
        {
            return _questShopDbContext.Quests.ToList();
        }

        public IEnumerable<Quest> QuestsOfTheWeek()
        {

            return _questShopDbContext.Quests.Where(q => q.QuestOfTheWeek).ToList();
        }

        public Quest GetQuestById(int id)
        {
            return _questShopDbContext.Quests.FirstOrDefault(s => s.Id == id);
        }
    }
}
