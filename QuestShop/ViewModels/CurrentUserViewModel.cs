using Microsoft.AspNetCore.Identity;
using QuestShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.ViewModels
{
    public class CurrentUserViewModel
    {
        public IEnumerable<AppUser> AllUsers { get; set; }
        public AppUser LoggedInUser { get; set; }
        public double UserPoints { get; set; }
        public ModelEnums.UserRank UserRank { get; set; }
        public string UserRole { get; set; }
    }
}