using AiTech.WebUi.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutSocialComponent(ISocialService _socialService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _socialService.GetAllAsync();
            return View(values);
        }
    }
}
