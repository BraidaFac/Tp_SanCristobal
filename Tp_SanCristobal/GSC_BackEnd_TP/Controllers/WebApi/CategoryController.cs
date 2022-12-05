using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto.CategoryDto;
using GSC_BackEnd_TP.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Data;


namespace GSC_BackEnd_TP.Controllers.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CategoryController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpPost]
        [EnableCors("AngularPolicy")]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CategoryDtoToCreate categoryDto)
        {
            //Validaciones de request
            if (categoryDto is null
               || string.IsNullOrWhiteSpace(categoryDto.Description))
                return BadRequest("Description es obligatoria");
            if (uow.CategoryRepository.getCategoriesByDescription(categoryDto.Description).Any())

            {
               return BadRequest("ya existe una categoria con esa descripcion");
           }
            Category category = mapper.Map<Category>(categoryDto);
            category = uow.CategoryRepository.Add(category);
            uow.Complete();
            return Created($"/categoria /{category.Id}", category);

        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [EnableCors("AngularPolicy")]
        public IActionResult GetCategories()
        {
            return Ok(uow.CategoryRepository.GetAll());
        }

        [EnableCors("AngularPolicy")]
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetCategory(int id)
        {
            if (id == 0) return BadRequest("No se envio el ID");
            var entityToDelete = uow.CategoryRepository.GetById(id);
            if (entityToDelete == null) return NotFound("No se encontro la categoria con ese ID");
            return Ok(uow.CategoryRepository.GetById(id));
        }
        [EnableCors("AngularPolicy")]
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            if (id == 0) return BadRequest("No se envio el ID");
            var entityToDelete = uow.CategoryRepository.GetById(id);
            if (entityToDelete == null) return BadRequest("No se encontro la categoria con ese ID");
            uow.CategoryRepository.Delete(entityToDelete);
            uow.Complete();
            return NoContent();



        }

    }
}
