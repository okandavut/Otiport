using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Otiport.Entities;
using Microsoft.EntityFrameworkCore;

namespace Otiport.Repository.Implementations
{
    public class Repository<T, TProperty> : IRepository<T, TProperty>
        where T : BaseEntity<TProperty>
        where TProperty : struct
    {
        private readonly OtiportDbContext _dbContext;
        public Repository(OtiportDbContext dbContext)
        {
            this._dbContext = dbContext;
            this.Table = _dbContext.Set<T>();
        }

        public DbSet<T> Table { get; set; }

        public async Task<bool> Add(T entity)
        {
            await Table.AddAsync(entity);
            return await Save();
        }

        public async Task<IQueryable<T>> All()
        {
            return await Task.Run(() => Table.AsQueryable());
        }

        public async Task<IQueryable<T>> AllByDefault()
        {
            return await Task.Run(() => Table.Where(x => x.IsActive && !x.IsDeleted));
        }

        public async Task<IQueryable<T>> AllNotDeleted()
        {
            return await Task.Run(() => Table.Where(x => !x.IsDeleted));
        }

        public async Task<bool> Delete(T entity, bool isSoftDelete = true)
        {
            if (isSoftDelete)
            {
                entity.IsDeleted = true;
                return await Update(entity);
            }
            else
            {
                Table.Remove(entity);
            }
            return await Save();
        }

        public async Task<bool> Delete(TProperty id, bool isSoftDelete = true)
        {
            var entity = await GetById(id);
            if (entity == null) return false;

            return await Delete(entity, isSoftDelete);
        }

        public async Task<bool> ExistsByDefault(Expression<Func<T, bool>> exists)
        {
            return await Table.Where(x => x.IsActive && !x.IsDeleted).CountAsync(exists) > 0;
        }

        public async Task<T> GetById(TProperty id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<IQueryable<T>> Paging(int pageIndex = 0, int pageItem = 10)
        {
            return (await All()).Skip(pageIndex * pageItem).Take(pageItem);
        }

        public async Task<IQueryable<T>> PagingByDefault(int pageIndex = 0, int pageItem = 10)
        {
            return (await AllByDefault()).Skip(pageIndex * pageItem).Take(pageItem);
        }

        public async Task<bool> Update(T entity)
        {
            Table.Update(entity);
            return await Save();
        }

        public async Task<IQueryable<T>> WhereByActive(Expression<Func<T, bool>> where)
        {
            return await Task.Run(() => Table.Where(x => x.IsActive && !x.IsDeleted).Where(where));
        }

        public Task<IQueryable<T>> WhereByDefault(Expression<Func<T, bool>> where)
        {
            return Task.Run(() => Table.Where(x => x.IsActive).Where(where));
        }

        #region Helpers

        private async Task<bool> Save()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Debug.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }
                return false;
            }
        }

        #endregion
    }
}
