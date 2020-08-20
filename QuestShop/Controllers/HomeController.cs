using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QuestShop.Data;
using QuestShop.Models;
using QuestShop.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuestShop.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly ICrudRepository<Quest> _questRepository;
        private readonly QuestShopDbContext _questShopDbContext;

        public HomeController(ILogger<HomeController> logger,
                            ICrudRepository<Quest> questRepository,
                            QuestShopDbContext questShopDbContext) {
            _logger = logger;
            _questRepository = questRepository;
            _questShopDbContext = questShopDbContext;
        }

        public async Task<IActionResult> Index() {
            var homeViewModel = new HomeViewModel()
            {
                Quests = await _questRepository.GetAll()
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}