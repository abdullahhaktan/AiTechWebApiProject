using AiTech.WebUi.DTOs.FeatureDtos;
using AiTech.WebUi.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController(IFeatureService _featureService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _featureService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            await _featureService.CreateAsync(createFeatureDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateFeature(int id)
        {
            var feature = await _featureService.GetByIdAsync(id);
            return View(feature);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            await _featureService.UpdateAsync(updateFeatureDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
