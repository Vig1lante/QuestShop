using System.Collections.Generic;

namespace QuestShop.Models {
    public class TeamQuest {
        public int Id { get; set; }
        public int UserQuestId { get; set; }
        public IList<AppUser> Users { get; set; }
        public bool CompletionState { get; set; }
        public double PointsShare { get; set; }
    }
}