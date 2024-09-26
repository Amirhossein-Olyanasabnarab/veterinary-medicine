using ApplicationServices.Owners;
using ApplicationServices.Vets;
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
        public ActionResult<OwnerDto> AddOwner(OwnerDto ownerDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            var newOwner = _ownerService.AddOwner(ownerDto.FirstName, ownerDto.LastName, ownerDto.PhoneNumber);
            return ownerDto;

        }
    }
}
