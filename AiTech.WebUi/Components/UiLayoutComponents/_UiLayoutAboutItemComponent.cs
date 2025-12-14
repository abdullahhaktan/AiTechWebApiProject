using AiTech.WebUi.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutAboutItemComponent(IAboutItemService _aboutItemService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutItemService.GetAllAsync();
            return View(values);
        }
    }
}
