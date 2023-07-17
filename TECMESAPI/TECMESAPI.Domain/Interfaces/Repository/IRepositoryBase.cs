using TECMESAPI.CrossCutting.Conditions;
using TECMESAPI.CrossCutting.Pagination;
using System.Linq.Expressions;

namespace TECMESAPI.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task Add(T item);
        Task Update(T item);
        Task Delete(long id);
        Task Delete(string id);
        Task<T> GetById(long id);
        Task<T> GetById(string id);
        Task<T> GetByFilter(Expression<Func<T, bool>> predicate);
        Task<T> Find(params object[] keys);
        Task<PagedModel<T>> Get(Expression<Func<T, bool>> predicate, QueryParam param);
        Task<PagedModel<T>> GetAll(QueryParam param);
        Task<T> GetByCPF(string cpf);
    }
}
