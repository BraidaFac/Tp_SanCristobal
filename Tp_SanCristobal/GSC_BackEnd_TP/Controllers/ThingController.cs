using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto.CategoryDto;
using GSC_BackEnd_TP.Dto.ThingDto;
using GSC_BackEnd_TP.Entities;
using GSC_BackEnd_TP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections;

namespace GSC_BackEnd_TP.Controllers.WebApi
{

    public class ThingController : Controller
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public ThingController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var things = uow.ThingRepository.GetAll();
            var viewModel = mapper.Map<ThingViewModel[]>(things);
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = uow.CategoryRepository.GetAll();
            var categoriesDto = mapper.Map<CategoryDto[]>(categories) ;


            ViewData["Categories"] = categoriesDto;
         
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ThingViewModelToCreate thingModel)
        {
            if(!ModelState.IsValid)
            {
                var categories = uow.CategoryRepository.GetAll();
                var categoriesDto = mapper.Map<CategoryDto[]>(categories);
                ViewData["Categories"] = categoriesDto;
                return View(thingModel);
            };

            if (thingModel.CategoryId==0)
            {
                var categories = uow.CategoryRepository.GetAll();
                var categoriesDto = mapper.Map<CategoryDto[]>(categories);
                ViewData["Categories"] = categoriesDto;
                return View(thingModel);
            }

            Thing thingToAdd = mapper.Map<Thing>(thingModel);
            uow.ThingRepository.Add(thingToAdd);
            uow.Complete();
           
            return Redirect(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id is null || id == 0)
                return NotFound();

            var thing = uow.ThingRepository.GetById(id.Value);
            if (thing is null)
                return NotFound();


            var categories = uow.CategoryRepository.GetAll();
            var categoriesDto = mapper.Map<CategoryDto[]>(categories);
            ViewData["Categories"] = categoriesDto;

            var thingViewModel = mapper.Map<ThingViewModel>(thing);

            return View(thingViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, ThingViewModel thingViewModel)
        {
            if (!ModelState.IsValid)
            {

                var categories = uow.CategoryRepository.GetAll();
                var categoriesDto = mapper.Map<CategoryDto[]>(categories);
                ViewData["Categories"] = categoriesDto;
                return View(thingViewModel);
            }
            if (id != thingViewModel.Id)
            {
                return NotFound();
            }
            if (id is null || id == 0)
                return NotFound();

            var thing = uow.ThingRepository.GetById(id.Value);
            if (thing is null)
                return NotFound();

            var category = uow.CategoryRepository.GetById(thingViewModel.CategoryId);
            if (category is null)
                return NotFound();

            thing.Description = thingViewModel.Description;
            thing.Category = category;

            uow.ThingRepository.Update(thing);
            uow.Complete();

            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id is null || id == 0)
                return NotFound();

            var thing = uow.ThingRepository.GetById(id.Value);
            if (thing is null)
                return NotFound();

            var thingModelView = mapper.Map<ThingViewModel>(thing);

            return View(thingModelView);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int? id)
        {
            if (id is null)
                return NotFound();
            var thing = uow.ThingRepository.GetById(id.Value);
            uow.ThingRepository.Delete(thing);
            uow.Complete();

            return RedirectToAction(nameof(Index));
        }

    }
}
