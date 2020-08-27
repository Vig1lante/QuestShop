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


        public StudentRepository(QuestShopDbContext questShopDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _questShopDbContext = questShopDbContext;
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

    }
}