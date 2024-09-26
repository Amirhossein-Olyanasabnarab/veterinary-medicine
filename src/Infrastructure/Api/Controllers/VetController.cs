using ApplicationServices.Vets;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VetController : ControllerBase
    {
        private readonly IVetService _vetService;
        public VetController(IVetService vetService)
        {
            _vetService = vetService;
        }

        [HttpGet(Name = "GetVetById")]
        public VetDto GetVetById(Guid id)
        {
            return _vetService.GetVetById(id);
        }
    }
}
