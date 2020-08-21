﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestShop.Data;
using QuestShop.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace QuestShop.Controllers
{
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly ICrudRepository<Quest> _questRepository;
        private readonly ICrudRepository<Product> _productRepository;
        private readonly QuestShopDbContext _questShopDbContext;

        public HomeController(ILogger<HomeController> logger,
                            ICrudRepository<Quest> questRepository,
                            ICrudRepository<Product> productRepository,
                            QuestShopDbContext questShopDbContext) {
            _logger = logger;
            _questRepository = questRepository;
            _productRepository = productRepository;
            _questShopDbContext = questShopDbContext;
        }

        public async Task<IActionResult> Index() {

            var quests = await _questRepository.GetAll();            
            return View(quests);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}