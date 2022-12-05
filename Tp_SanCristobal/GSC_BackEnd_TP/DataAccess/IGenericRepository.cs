using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.DataAccess
{
    public interface IGenericRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        TEntity Add(TEntity entity);

        void Delete(TEntity entity);

        TEntity Update(TEntity entity);



        TEntity? GetById(int id);

        List<TEntity>? GetAll();
    }
}
