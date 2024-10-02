using ApplicationServices.Pets;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController: ControllerBase
    {
        private readonly IPetService _petService;
        public PetController(IPetService petService)
        {
            _petService = petService;
        }

        [HttpPost]
        public IActionResult CreatedPet(PetDto petDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdPet = _petService.CreatePet(petDto);
            return Ok(createdPet);
        }
    }
}
