using AiTech.WebUi.DTOs.ContactDtos;
using AiTech.WebUi.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Controllers
{
    public class ContactController(IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto contactDto)
        {
            await _contactService.CreateAsync(contactDto);
            return RedirectToAction("Index");
        }
    }
}
