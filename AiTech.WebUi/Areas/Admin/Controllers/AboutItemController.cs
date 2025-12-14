using AiTech.WebUi.DTOs.AboutItemDtos;
using AiTech.WebUi.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutItemController(IAboutItemService _aboutItemService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _aboutItemService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateAboutItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemDto createAboutItemDto)
        {
            await _aboutItemService.CreateAsync(createAboutItemDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var aboutItem = await _aboutItemService.GetByIdAsync(id);
            return View(aboutItem);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemDto updateAboutItemDto)
        {
            await _aboutItemService.UpdateAsync(updateAboutItemDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
