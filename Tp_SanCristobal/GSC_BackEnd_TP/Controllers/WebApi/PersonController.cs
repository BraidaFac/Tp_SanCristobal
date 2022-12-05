using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace GSC_BackEnd_TP.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public PersonController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        [HttpPost]
        [EnableCors("AngularPolicy")]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(PersonDto personDto) 
        {
            //Validaciones de request
            if (personDto is null
               || string.IsNullOrWhiteSpace(personDto.Name) 
               || string.IsNullOrWhiteSpace(personDto.PhoneNumber)
               || string.IsNullOrWhiteSpace(personDto.Email))
                return BadRequest("Description is mandatory");
            Person person = mapper.Map<Person>(personDto);
            person=uow.PersonRepository.Add(person);
            uow.Complete();
            return Created($"/person /{person.Id}",person);
    
        }
        [EnableCors("AngularPolicy")]
        [HttpPut("{id}")]
        public IActionResult FullUpdate(int id, PersonDto personDto)
        {
            //Validaciones de request
            if (personDto is null
               || string.IsNullOrWhiteSpace(personDto.Name)
               || string.IsNullOrWhiteSpace(personDto.PhoneNumber)
               || string.IsNullOrWhiteSpace(personDto.Email))
                return BadRequest("Nombre, telefono o email es obligatorio");
            if (personDto.Id != 0 && personDto.Id != id)
                return BadRequest("No se encontro la persona");
            Person person = mapper.Map<Person>(personDto);
            person = uow.PersonRepository.Update(person);
            uow.Complete();

            return Created($"/person /{person.Id}", person);
            //Ver en POSTMAN que el response tiene un header "Location"
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        [EnableCors("AngularPolicy")]
        public IActionResult GetPersons()
        {
            return Ok(uow.PersonRepository.GetAll());
        }
        [EnableCors("AngularPolicy")]
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetPerson(int id)
        {
            if (id == 0) return BadRequest("No se envio el ID");
            var entityToDelete = uow.PersonRepository.GetById(id);
            if (entityToDelete == null) return BadRequest("No se encontro la persona con ese ID");
            return Ok(uow.PersonRepository.GetById(id));
        }

        [EnableCors("AngularPolicy")]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest("No se envio el ID");
            var entityToDelete= uow.PersonRepository.GetById(id);
            if (entityToDelete == null) return NotFound("No se encontro la persona con ese ID");
            uow.PersonRepository.Delete(entityToDelete);
            uow.Complete();
            return NoContent();



        }



    }
}
