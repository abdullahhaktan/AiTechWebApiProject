using AiTech.WebUi.DTOs.TestimonialDtos;
using AiTech.WebUi.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonialService _testimonialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _testimonialService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            await _testimonialService.CreateAsync(createTestimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var testimonial = await _testimonialService.GetByIdAsync(id);
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            await _testimonialService.UpdateAsync(updateTestimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
