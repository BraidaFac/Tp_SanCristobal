using AutoMapper;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Dto.CategoryDto;
using GSC_BackEnd_TP.Dto.ThingDto;
using GSC_BackEnd_TP.Entities;
using GSC_BackEnd_TP.Models;

namespace GSC_BackEnd_TP.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<PersonDto, Person>();
            CreateMap<ThingDto, Thing>();
            CreateMap<ThingDto, Thing>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryDtoToCreate, Category>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Thing, ThingViewModel>();
            CreateMap<ThingViewModel, Thing>();
            CreateMap<ThingViewModelToCreate, Thing>();


        }
    }
}
