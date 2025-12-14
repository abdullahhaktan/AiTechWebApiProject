using AiTech.WebUi.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutNavbarComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
