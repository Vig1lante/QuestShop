using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestShop.Data;
using QuestShop.Models;

namespace QuestShop.Controllers
{
    public class UserController : Controller
    {
        private readonly QuestShopDbContext _questShopDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICrudRepository<AppUser> _crudRepository;

        // GET: /<controller>/

        public UserController(QuestShopDbContext questShopDbContext, UserManager<AppUser> userManager, ICrudRepository<AppUser> crudRepository )
        {
            _questShopDbContext = questShopDbContext;
            _userManager = userManager;
            _crudRepository = crudRepository;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
