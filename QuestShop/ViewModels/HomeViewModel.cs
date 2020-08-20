using QuestShop.Models;
using System.Collections.Generic;

namespace QuestShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Quest> Quests { get; set; }
    }
}
