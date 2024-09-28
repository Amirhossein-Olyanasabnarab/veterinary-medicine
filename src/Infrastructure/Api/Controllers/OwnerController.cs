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
        public async Task<ActionResult<Owner>> CreateOwner([FromBody] Owner owner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdOwner = await _ownerService.CreateOwnerAsync(owner);
            return createdOwner;
        }
    }
}
