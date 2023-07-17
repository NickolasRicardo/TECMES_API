using TECMESAPI.CrossCutting.Conditions;
using TECMESAPI.CrossCutting.Pagination;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;
using System.Linq.Expressions;

namespace TECMESAPI.Domain.Services.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        protected readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public async Task Add(T item)
        {
            await _repository.Add(item);
        }

        public async Task Delete(long id)
        {
            await _repository.Delete(id);
        }

        public async Task Delete(string id)
        {
            await _repository.Delete(id);
        }

        public async Task<T> Find(params object[] keys)
        {
            return await _repository.Find(keys);
        }

        public async Task<PagedModel<T>> Get(Expression<Func<T, bool>> predicate, QueryParam param)
        {
            return await _repository.Get(predicate, param);
        }

        public async Task<PagedModel<T>> GetAll(QueryParam param)
        {
            return await _repository.GetAll(param);
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return await (_repository.GetByFilter(predicate));
        }

        public async Task<T> GetById(long id)
        {
            return await _repository.GetById(id);
        }

        public async Task<T> GetById(string id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(T item)
        {
            await _repository.Update(item);
        }

        public async Task<T> GetByCPF(string cpf)
        {
            return await _repository.GetByCPF(cpf);
        }
    }
}
