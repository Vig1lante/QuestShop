using QuestShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.ViewModels
{
    public class StudentViewModel
    {
        public AppUser LoggedInUser { get; set; }
        public double UserPoints { get; set; }
        public ModelEnums.UserRank UserRank { get; set; }
        public ModelEnums.UserType UserType { get; set; }
    }
}
