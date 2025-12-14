using AiTech.WebUi.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutFeatureComponent(IFeatureService _featureService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllAsync();
            return View(values);
        }
    }
}
