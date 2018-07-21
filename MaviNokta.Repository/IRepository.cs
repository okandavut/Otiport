using MaviNokta.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MaviNokta.Repository
{
    public interface IRepository<T, TProperty>
        where T : BaseEntity<TProperty>
        where TProperty : struct
    {
        //Add async prefix to method name
        DbSet<T> Table { get; set; }
        Task<IQueryable<T>> All();
        Task<IQueryable<T>> AllByDefault();
        Task<IQueryable<T>> AllNotDeleted();

        Task<IQueryable<T>> Paging(int pageIndex = 0, int pageItem = 10);
        Task<IQueryable<T>> PagingByDefault(int pageIndex = 0, int pageItem = 10);
        Task<T> GetById(TProperty id);

        Task<IQueryable<T>> WhereByDefault(Expression<Func<T, bool>> where);
        Task<IQueryable<T>> WhereByActive(Expression<Func<T, bool>> where);

        Task<bool> ExistsByDefault(Expression<Func<T, bool>> exists);

        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity, bool isSoftDelete = true);
        Task<bool> Delete(TProperty id, bool isSoftDelete = true);

    }
}
