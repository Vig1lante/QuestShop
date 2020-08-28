using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using static QuestShop.Models.ModelEnums;

namespace QuestShop.Models {
    public class AppUser: IdentityUser {
        public UserRank Rank { get; set; }
        public string Surname { get; set; }
        public string UserGroup { get; set; }
        public double UserPoints { get; set; }
        public IList<UserQuest> Quests { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
