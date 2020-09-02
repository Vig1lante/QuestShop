using QuestShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.ViewModels
{
    public class QuestProductViewModel
    {
        public IEnumerable<Quest> Quests { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
