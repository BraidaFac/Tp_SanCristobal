using AutoMapper;
using GSC_BackEnd_TP.Dto;
using GSC_BackEnd_TP.Dto.CategoryDto;
using GSC_BackEnd_TP.Dto.LoanDto;
using GSC_BackEnd_TP.Dto.ThingDto;
using GSC_BackEnd_TP.Entities;
using GSC_BackEnd_TP.Models;
using GSC_BackEnd_TP.Protos;

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
            CreateMap<LoanDto, Loan>();
            CreateMap<Loan, LoanDto>();
            CreateMap<LoanDtoToCreate, Loan>();
            CreateMap<NewLoan, LoanDtoToCreate>()
                .ForMember(loanDto => loanDto.AgreeDate, n => n.MapFrom(l => l.AgreeDate.ToDateTime())); ;
            


        }
    }
}
