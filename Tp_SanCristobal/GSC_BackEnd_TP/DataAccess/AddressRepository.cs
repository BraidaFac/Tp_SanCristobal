using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
 
        public AddressRepository(ThingsContext context)
            :base(context)
        {
            dbSet = context.Set<Address>();
        }
    }
}
