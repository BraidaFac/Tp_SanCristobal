using AutoMapper;
using GSC_BackEnd_TP.DataAccess;
using GSC_BackEnd_TP.Dto.LoanDto;
using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Services
{
    public class LoanService : ILoanService
    {

        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public LoanService(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }

        public Task<List<Loan>> GetPendingLoans()
        {
            var loans = uow.LoanRepository.GetPendingLoans();
            return Task<List<Loan>>.FromResult(loans);
        }

        public string Create(LoanDtoToCreate loanDto)
        {

            if (loanDto.AgreeDate < DateTime.Now)
                return "fecha incorrecta";

            var thing = uow.ThingRepository.GetById(loanDto.ThingId);
            if (thing is null)
                return "no se encontro el objeto";

            var person = uow.PersonRepository.GetById(loanDto.PersonId);
            if (person is null)
                return "no se encontro la persona";

            var pendingLoans = uow.LoanRepository.GetPendingLoans();
            if (pendingLoans.Select(l => l.Thing).Any(t => t.Id == loanDto.ThingId))
                return "el objeto esta en prestamo";

            var newLoan = mapper.Map<Loan>(loanDto);
            newLoan.Thing= thing;
            newLoan.Person= person;

            uow.LoanRepository.Add(newLoan);
            uow.Complete();

            return "Created";
        }




        public string Close(int id)
        {
            var loan = uow.LoanRepository.GetById(id);
            if (loan is null)
                return "No se encontro el prestamo";

            if (loan.estaDevuelto())
                return "Prestamo ya devuelto";

            loan.cerrarPrestamo();
            uow.LoanRepository.Update(loan);
            uow.Complete();

            return "Cerrado";
        }

        
    }
}
