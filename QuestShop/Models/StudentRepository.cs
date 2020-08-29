using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly QuestShopDbContext _questShopDbContext;
        private readonly UserManager<AppUser> userManager;
        private readonly string _currentUserName;

        public AppUser LoggedInUser
        {
            get
            {
                return GetAppUser();
            }

        }

        public double UserPoints
        {
            get { return LoggedInUser.UserPoints; }
            set
            {
                UserPoints = value;
            }
        }

        public ModelEnums.UserRank UserRank
        {
            get { return LoggedInUser.Rank; }
            set { UserRank = value; }
        }

        public string UserRole
        {
            get
            {
                return GetUserRoleId();
            }
        }


        public StudentRepository(QuestShopDbContext questShopDbContext, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _questShopDbContext = questShopDbContext;
            this.userManager = userManager;
            _currentUserName = httpContextAccessor.HttpContext.User.Identity.Name; //Set current user guid to field
        }

        private AppUser GetAppUser()
        {
            return _questShopDbContext.Users.FirstOrDefault(s => s.Email == _currentUserName);
        }

        private string GetUserRoleId()
        {
            var roleTemp = _questShopDbContext.UserRoles.AsEnumerable();
            var result = _questShopDbContext.UserRoles.Where(s => s.UserId == LoggedInUser.Id).FirstOrDefault();
            if (result == null)
            {
                return null;
            }
            else
            {
                return _questShopDbContext.Roles.FirstOrDefault(p => p.Id == result.RoleId).Name;
            }
        }

        public async Task<IDictionary<AppUser, string>> GetUsersWithRoles()
        {
            var dict = new Dictionary<AppUser, string>();
            var appUsers = await userManager.Users.ToListAsync();


            foreach (AppUser user in appUsers)
            {
                var roleKey = userManager.GetRolesAsync(user).Result.First();
                dict.Add(user, roleKey);
            }

            return dict;
        }
    }
}