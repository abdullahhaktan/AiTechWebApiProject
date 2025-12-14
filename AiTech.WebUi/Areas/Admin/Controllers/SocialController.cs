using AiTech.WebUi.DTOs.SocialDtos;
using AiTech.WebUi.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialController(ISocialService _socialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _socialService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateSocial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocial(CreateSocialDto createSocialDto)
        {
            await _socialService.CreateAsync(createSocialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateSocial(int id)
        {
            var social = await _socialService.GetByIdAsync(id);
            return View(social);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSocial(UpdateSocialDto updateSocialDto)
        {
            await _socialService.UpdateAsync(updateSocialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSocial(int id)
        {
            await _socialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
