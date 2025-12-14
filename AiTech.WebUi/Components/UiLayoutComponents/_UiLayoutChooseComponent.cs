using AiTech.WebUi.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutChooseComponent(IChooseService _chooseService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _chooseService.GetByIdAsync(1);
            return View(value);
        }
    }
}
