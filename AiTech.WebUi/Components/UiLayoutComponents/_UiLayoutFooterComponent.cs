using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutFooterComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
