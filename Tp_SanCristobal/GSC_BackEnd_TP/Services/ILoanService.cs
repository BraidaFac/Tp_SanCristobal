using GSC_BackEnd_TP.Dto.LoanDto;
using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Services
{
    public interface ILoanService
    {

         string Create(LoanDtoToCreate LoanDto);

         string Close(int LoanId);

         Task<List<Loan>> GetPendingLoans();
    }
}
