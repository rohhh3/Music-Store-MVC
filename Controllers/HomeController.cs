using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;
using MusicStore.ViewModels;
using System.Diagnostics;
using System.Text.Json;
using System.Web;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IItemRepository _itemRepository;
        private readonly AppDbContext _dbContext;
        private readonly ICurrencyService _currencyService;

        public HomeController(ILogger<HomeController> logger, IItemRepository itemRepository, AppDbContext dbContext, ICurrencyService currencyService)
        {
            _logger = logger;
            _itemRepository = itemRepository;
            _dbContext = dbContext;
            _currencyService = currencyService;
        }

        public IActionResult Index()
        {
            var visitCounter = _dbContext.VisitCounters.FirstOrDefault();

            (string selectedCurrency, decimal exchangeRate) = _currencyService.GetCurrencyInfo(HttpContext);

            ViewBag.SelectedCurrency = selectedCurrency;
            ViewBag.ExchangeRate = exchangeRate;

            if (visitCounter != null)
            {
                visitCounter.Count++;
                _dbContext.SaveChanges();
            }

            var itemsOfTheWeek = _itemRepository.ItemsOfTheWeek;
            var homeNewModel = new HomeViewModel(itemsOfTheWeek, visitCounter);
            return View(homeNewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}