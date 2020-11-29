namespace BookLand.Server.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class EfRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public EfRepository(BookLandDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
            this.DbSet = this.Context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        protected BookLandDbContext Context { get; set; }

        public virtual IQueryable<TEntity> All()
        {
            return this.DbSet;
        }

        public virtual IQueryable<TEntity> AllAsNoTracking()
        {
            return this.DbSet.AsNoTracking();
        }

        public virtual Task AddAsync(TEntity entity)
        {
            return this.DbSet.AddAsync(entity).AsTask();
        }

        public void Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

        public virtual void Delete(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
