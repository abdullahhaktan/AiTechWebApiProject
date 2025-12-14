using AiTech.WebUi.Services.FaqServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutFaqComponent(IFaqService _faqService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _faqService.GetAllAsync();
            return View(values);
        }
    }
}
