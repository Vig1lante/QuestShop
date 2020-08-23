﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using System.Security.Claims;

namespace QuestShop.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly QuestShopDbContext _questShopDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _currentUserId;
        public AppUser LoggedInUser
        {
            get { return LoggedInUser; }
            set
            {
                GetAppUser();
            }
        }

        public double UserPoints
        {
            get { return UserPoints; }
            set
            {
                UserPoints = LoggedInUser.UserPoints;
            }
        }

        public ModelEnums.UserRank UserRank
        {
            get { return UserRank; }
            set { UserRank = LoggedInUser.Rank; }
        }
        public ModelEnums.UserType UserType
        {
            get { return UserType; }
            set { UserType = LoggedInUser.Type; }
        }

        public StudentRepository(QuestShopDbContext questShopDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _questShopDbContext = questShopDbContext;
            _httpContextAccessor = httpContextAccessor;
            _currentUserId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier); //Set current user guid to field
        }

        private async void GetAppUser()
        {
            LoggedInUser = await _questShopDbContext.Users.FirstOrDefaultAsync(s => s.Id == _currentUserId);
        }
    }
}
