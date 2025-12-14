using AiTech.WebUi.DTOs.ContactDtos;
using AiTech.WebUi.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebUi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var categories = await _contactService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            await _contactService.CreateAsync(createContactDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateContact(int id)
        {
            var contact = await _contactService.GetByIdAsync(id);
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            await _contactService.UpdateAsync(updateContactDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
