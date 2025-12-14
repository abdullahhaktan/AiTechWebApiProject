using AiTech.WebUi.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutTestimonialComponent(ITestimonialService _testimonialService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllAsync();
            return View(values);
        }
    }
}
