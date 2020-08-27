using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestShop.Data;
using QuestShop.Models;
using QuestShop.ViewModels;

namespace QuestShop.Controllers
{
    public class UserController : Controller
    {
        private readonly QuestShopDbContext _questShopDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICrudRepository<AppUser> _userRepository;

        // GET: /<controller>/

        public UserController(QuestShopDbContext questShopDbContext, UserManager<AppUser> userManager, ICrudRepository<AppUser> userRepository )
        {
            _questShopDbContext = questShopDbContext;
            _userManager = userManager;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {

            return View(_userRepository.GetAll().Result);
        }






    }
}
