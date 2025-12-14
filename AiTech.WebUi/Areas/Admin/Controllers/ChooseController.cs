using AiTech.WebUi.DTOs.ChooseDtos;
using AiTech.WebUi.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChooseController(IChooseService _chooseService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _chooseService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateChoose()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateChoose(CreateChooseDto createChooseDto)
        {
            await _chooseService.CreateAsync(createChooseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateChoose(int id)
        {
            var choose = await _chooseService.GetByIdAsync(id);
            return View(choose);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateChoose(UpdateChooseDto updateChooseDto)
        {
            await _chooseService.UpdateAsync(updateChooseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteChoose(int id)
        {
            await _chooseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
