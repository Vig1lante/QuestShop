using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public interface IStudentRepository
    {
        AppUser LoggedInUser { get; }
        double UserPoints { get; set; }
        ModelEnums.UserRank UserRank { get; set; }

        public string UserRole { get;}

        public Task<IDictionary<AppUser, string>> GetUsersWithRoles();

    }
}