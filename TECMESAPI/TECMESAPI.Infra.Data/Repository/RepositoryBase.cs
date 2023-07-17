using TECMESAPI.CrossCutting.Conditions;
using TECMESAPI.CrossCutting.Pagination;
using TECMESAPI.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace TECMESAPI.Infra.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dataSet;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task Add(T item)
        {
            await _dataSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var item = await GetById(id);
            _dataSet.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var item = await GetById(id);

            if(item == null)
            {
                throw new KeyNotFoundException("Identificador inválido ou não encontrado.");
            }
            _dataSet.Remove(item);
            await _context.SaveChangesAsync();
        }


        public async Task<T> Find(params object[] keys)
        {
            return await _dataSet.FindAsync(keys);
        }

        public async Task<PagedModel<T>> Get(Expression<Func<T, bool>> predicate, QueryParam param)
        {
            return await _dataSet.AsNoTracking().Where(predicate).PaginateAsync(param);
        }

        public async Task<PagedModel<T>> GetAll(QueryParam param)
        {
            return await _dataSet.AsNoTracking().PaginateAsync(param);
        }

        public async Task<T> GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return await _dataSet.FirstOrDefaultAsync(predicate, default);
        }

        public async Task<T> GetById(long id)
        {
            return await _dataSet.FindAsync(id);
        }

        public async Task<T> GetById(string id)
        {
            return await _dataSet.FindAsync(id);
        }
        public async Task Update(T item)
        {
            _dataSet.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByCPF(string cpf)
        {
            return await _dataSet.FindAsync(cpf);
        }
    }
}

