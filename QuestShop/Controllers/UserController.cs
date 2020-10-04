using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using QuestShop.Models;
using QuestShop.ViewModels;

namespace QuestShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly QuestShopDbContext _questShopDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly IStudentRepository _userRepository;
        private readonly RoleManager<IdentityRole> roleManager;

        // GET: /<controller>/

        public UserController(QuestShopDbContext questShopDbContext, UserManager<AppUser> userManager, IStudentRepository userRepository, RoleManager<IdentityRole> roleManager )
        {
            _questShopDbContext = questShopDbContext;
            _userManager = userManager;
            _userRepository = userRepository;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(_userRepository.GetUsersWithRoles().Result);
        }




    }
}
