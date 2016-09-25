using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ECJ.EntityFramework.Repositories
{
    public abstract class ECJRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ECJDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ECJRepositoryBase(IDbContextProvider<ECJDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ECJRepositoryBase<TEntity> : ECJRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ECJRepositoryBase(IDbContextProvider<ECJDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
