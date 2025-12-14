using AiTech.WebUi.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutProjectComponent(IProjectService _projectService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _projectService.GetAllAsync();
            return View(values);
        }
    }
}
