﻿using ApplicationServices.Owners;
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

        [HttpGet("{id}")]
        public OwnerDto GetOwnerById(Guid id) 
        {
            return _ownerService.GetOwnerDtoById(id);
        }

        [HttpGet("/lastname")]
        public OwnerDto GetOwnerByLastName(string lastName) 
        {
            return _ownerService.GetOwnerDtoByOwneerByLastName(lastName);
        }

        [HttpGet("/name",Name = "GetOwnerByName")]
        public OwnerDto GetOwnerByName(string name)
        {
            return _ownerService.GetOwnerDtoByName(name);
        }
    }
}
