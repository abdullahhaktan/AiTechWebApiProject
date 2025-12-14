using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutSubscribeComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
