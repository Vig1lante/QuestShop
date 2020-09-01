using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace QuestShop.Models
{
    public class Quest : IItemThumbnail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Points { get; set; }
        public DateTime CompletionDate { get; set; }
        public bool Stock { get; set; }

        public bool QuestOfTheWeek { get; set; }
        public IList<UserQuest> Users { get; set; }
    }
}