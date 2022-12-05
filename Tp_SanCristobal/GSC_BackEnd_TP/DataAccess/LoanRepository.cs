using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.DataAccess
{
    public class LoanRepository:GenericRepository<Loan>, ILoanRepository
    {
        public LoanRepository(ThingsContext context) : base(context) 
        {
            dbSet = context.Set<Loan>();
        }
    }
}
