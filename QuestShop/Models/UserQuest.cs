using System;
using System.Collections.Generic;

namespace QuestShop.Models {
    public class UserQuest {
        public int QuestId { get; set; }
        public Quest Quest { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public IList<TeamQuest> TeamQuest { get; set; }
        public DateTime CompletionDate { get; set; }
    }
}