using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepository(ThingsContext context)
            : base(context)
        {
            dbSet=context.Set<Person>();
        }

        
        public override List<Person>? GetAll()
        {
            return dbSet.Include(p=> p.Address).ToList();
        }

        public override Person? GetById(int id)
        {
            return dbSet.Include(x => x.Address).SingleOrDefault(x => x.Id == id);
        }
    }
}
