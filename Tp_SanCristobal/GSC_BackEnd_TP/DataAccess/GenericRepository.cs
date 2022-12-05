using GSC_BackEnd_TP.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GSC_BackEnd_TP.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        protected ThingsContext context;
        internal DbSet<TEntity> dbSet;
    
    public GenericRepository(ThingsContext context)
    {
        this.context = context;
        dbSet = context.Set<TEntity>();
    }
    public TEntity Add(TEntity entity)
    {
          return dbSet.Add(entity).Entity;
        
    }

    public void Delete(TEntity entity)
    {
            dbSet.Remove(entity);
    }

    public virtual List<TEntity>? GetAll()
    {
        return dbSet.ToList();
    }

    public virtual TEntity? GetById(int id)
    {
        return dbSet.SingleOrDefault(t => t.Id == id);
    }


    public TEntity Update(TEntity entity)
    {
        var changedEntity = dbSet.Update(entity);
        return changedEntity.Entity;
    }
       
    }
}
