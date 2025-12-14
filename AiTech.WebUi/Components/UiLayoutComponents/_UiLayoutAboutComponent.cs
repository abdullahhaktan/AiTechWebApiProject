using AiTech.WebUi.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutAboutComponent(IAboutService _aboutService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetByIdAsync(1);
            return View(values);
        }
    }
}
