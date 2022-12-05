using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class ThingRepository : GenericRepository<Thing>, IThingRepository
    { 
        public ThingRepository(ThingsContext context)
            : base(context)
        {
            dbSet = context.Set<Thing>();
        }

        public override List<Thing>? GetAll()
        {
            return dbSet.Include(x => x.Category).ToList();
        }
        public override Thing? GetById(int id)
        {
            return dbSet.Include(x => x.Category).SingleOrDefault(x => x.Id == id);
        }
    }
}
