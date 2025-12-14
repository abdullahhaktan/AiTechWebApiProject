using AiTech.WebUi.DTOs.FaqDtos;
using AiTech.WebUi.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FaqController(IFaqService _faqService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _faqService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFaq(CreateFaqDto createFaqDto)
        {
            await _faqService.CreateAsync(createFaqDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateFaq(int id)
        {
            var faq = await _faqService.GetByIdAsync(id);
            return View(faq);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFaq(UpdateFaqDto updateFaqDto)
        {
            await _faqService.UpdateAsync(updateFaqDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            await _faqService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
