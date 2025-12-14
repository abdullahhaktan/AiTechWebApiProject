using AiTech.Businness.Services.ContactServices;
using AiTech.DTO.ContactDtos;
using Microsoft.AspNetCore.Mvc;

namespace AiTech.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IContactService _contactService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactService.TGetAllAsync();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var contact = await _contactService.TGetByIdAsync(id);
            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactDto contactDto)
        {
            await _contactService.TCreateAsync(contactDto);
            return Ok("Kategori oluşturuldu");
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateContactDto contactDto)
        {
            await _contactService.TUpdateAsync(contactDto);
            return Ok("Hakkımda güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _contactService.TDeleteAsync(id);
            return Ok("Hakkımda silindi");
        }
    }
}
