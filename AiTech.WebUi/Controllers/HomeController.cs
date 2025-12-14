using AiTech.WebUi.Models;
using AiTech.WebUi.Services.GeminiServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AiTech.WebUi.Controllers
{
    public class HomeController(IGeminiService _geminiService) : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string prompt)
        {
            var response = await _geminiService.GetGeminiDataAsync(prompt);
            if(response != null)
            {
                ViewBag.response = response;
            }

            return View();
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
