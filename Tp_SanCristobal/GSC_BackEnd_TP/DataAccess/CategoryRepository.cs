using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {

        public CategoryRepository(ThingsContext context)
            : base(context)
        {
            dbSet = context.Set<Category>();
        }

        public List<Category> getCategoriesByDescription(string description)
        {
            return dbSet.Where(x => x.Description.Contains(description)).ToList();
        }

        public List<Category>? getOneByDescription(string description)
        {
            return dbSet.Where(x => x.Description == description).ToList();
        }

        public override List<Category>? GetAll()
        {
            return dbSet.ToList();
        }

    }
}
