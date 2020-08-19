using System.Collections.Generic;

namespace QuestShop.Models {
    public class TeamQuest {
        public int Id { get; set; }
        public IList<UserQuest> UserQuests { get; set; }
        public bool CompletionState { get; set; }
        public double PointsShare { get; set; }
    }
}