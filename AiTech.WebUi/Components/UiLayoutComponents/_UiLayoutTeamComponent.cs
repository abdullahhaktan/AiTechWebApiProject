using AiTech.WebUi.Services.TeamServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Components.UiLayoutComponents
{
    public class _UiLayoutTeamComponent(ITeamService _teamService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _teamService.GetAllAsync();
            return View(values);
        }
    }
}
