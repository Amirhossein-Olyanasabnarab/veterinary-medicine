using ApplicationServices.Owners;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OwnerController: ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }
        [HttpPost(Name = "AddNewOwner")]
        public OwnerDto Add()
        {
            return View();
        }
    }
}
