using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class LoanRepository:GenericRepository<Loan>, ILoanRepository
    {
        public LoanRepository(ThingsContext context) : base(context) 
        {
            dbSet = context.Set<Loan>();
        }
        public override Loan? GetById(int id)
        {
            return dbSet
                .Include(l => l.Person)
                .Include(l => l.Thing)
                .SingleOrDefault(l => l.Id == id);
        }


        public List<Loan> GetPendingLoans()
        {
            return dbSet
                .Where(l => l.DateReturnedLoan == null)
                .Include(l => l.Person)
                .Include(l => l.Thing)
                .Include(l => l.Thing.Category)
                .ToList();
        }
    }
}
