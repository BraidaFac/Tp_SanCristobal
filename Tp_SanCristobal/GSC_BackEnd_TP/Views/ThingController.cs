using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
namespace GSC_BackEnd_TP.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThingController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;
    
    public ThingController(IUnitOfWork uow, IMapper mapper)
    {
        this.uow = uow;
        this.mapper = mapper;
    }
        [HttpPost]
        public IActionResult Create([FromBody] ThingDto thingDto)
        {
            //Validaciones de request
            if (thingDto is null
               || string.IsNullOrWhiteSpace(thingDto.Description))
                return BadRequest("Description is mandatory");
            Thing thing = mapper.Map<Thing>(thingDto);
            thing = uow.ThingRepository.Add(thing);
            uow.Complete();



            return Created($"/person /{thing.Id}", thing);
            //Ver en POSTMAN que el response tiene un header "Location"
        }
    }
}
