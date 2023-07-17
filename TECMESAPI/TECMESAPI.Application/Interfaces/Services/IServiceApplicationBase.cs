using TECMESAPI.CrossCutting.Conditions;
using TECMESAPI.CrossCutting.Pagination;
using System.Linq.Expressions;

namespace TECMESAPI.Application.Interfaces.Services
{
    public interface IApplicationServiceBase<TEntity, TDto> where TEntity : class
                                                            where TDto : class
    {
        Task Add(TDto item);
        Task Update(TDto item);
        Task Delete(long id);
        Task Delete(string id);
        Task<TDto> GetById(long id);
        Task<TDto> GetById(string id);
        Task<TDto> GetByFilter(Expression<Func<TEntity, bool>> predicate);
        Task<TDto> Find(params object[] keys);
        Task<PagedModel<TDto>> Get(Expression<Func<TEntity, bool>> predicate, QueryParam param);
        Task<PagedModel<TDto>> GetAll(QueryParam param);

    }
}
