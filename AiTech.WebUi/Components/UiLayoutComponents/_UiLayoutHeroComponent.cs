using AiTech.WebUi.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutHeroComponent(IBannerService _bannerService) :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.GetByIdAsync(1);
            return View(values);
        }
    }
}
