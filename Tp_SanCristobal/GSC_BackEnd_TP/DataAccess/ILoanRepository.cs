using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.DataAccess
{
    public interface ILoanRepository: IGenericRepository<Loan>
    {
        public List<Loan> GetPendingLoans();
    }
}
