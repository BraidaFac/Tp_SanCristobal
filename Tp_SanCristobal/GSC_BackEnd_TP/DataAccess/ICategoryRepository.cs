using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;

namespace GSC_BackEnd_TP.DataAccess
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
      

        public List<Category> getCategoriesByDescription(string description);


        public List<Category>? getOneByDescription(string description);


    }
}
