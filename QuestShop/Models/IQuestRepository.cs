using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public interface IQuestRepository
    {
        IEnumerable<Quest> AllQuests();
        IEnumerable<Quest> QuestsOfTheWeek();
        Quest GetQuestById(int id);
    }
}
