using ApplicationServices.Owners;
using ApplicationServices.Vets;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController: ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpPost]
        public IActionResult CreatedOwner(OwnerDto ownerDto) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdOwner = _ownerService.CreateNewOwner(ownerDto);
            return Ok(createdOwner);
        }
    }
}
