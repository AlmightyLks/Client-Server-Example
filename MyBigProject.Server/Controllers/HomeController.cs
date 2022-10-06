using Microsoft.AspNetCore.Mvc;
using MyBigProject.Server.Services;
using System.Diagnostics;

namespace MyBigProject.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MessageService _messageService;

        public HomeController(ILogger<HomeController> logger, MessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View(_messageService.Messages);
        }
    }
}