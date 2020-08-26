using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using System;
using System.Linq;
using System.Security.Claims;
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
                return GetUserRoleId().Result;
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

        private async Task<string> GetUserRoleId()
        {
            try
            {
                var roleId = _questShopDbContext.UserRoles.FirstOrDefault(p => p.UserId == LoggedInUser.Id);
                return _questShopDbContext.Roles.FirstOrDefault(p => p.Id == roleId.RoleId).Name;

            }
            catch (InvalidOperationException ex)
            {
                await userManager.AddToRoleAsync(LoggedInUser, "Admin");
                await _questShopDbContext.SaveChangesAsync();
            }

            return _questShopDbContext.Roles.FirstOrDefault(p => p.Id == _questShopDbContext.UserRoles.FirstOrDefault(p => p.UserId == LoggedInUser.Id).RoleId).Name;
        }
    }
}