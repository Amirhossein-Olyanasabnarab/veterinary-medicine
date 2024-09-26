using ApplicationServices.Owners;
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
        public async Task<ActionResult<OwnerDto>> AddOwner([FromBody] OwnerDto ownerDto)
        {
            if(!ModelState.IsValid) 
                return BadRequest(ModelState);
            var owner = await _ownerService.AddNewOwner(ownerDto.FirstName, ownerDto.LastName, ownerDto.PhoneNumber);
            return Ok(owner);
        }
    }
}
