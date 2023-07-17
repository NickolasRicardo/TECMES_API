using TECMESAPI.CrossCutting.Conditions;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.CrossCutting.Pagination
{
    public static class PagedExtensions
    {
        public static async Task<PagedModel<T>> PaginateAsync<T>(this IQueryable<T> query,QueryParam param) where T: class
        {
            var paged = new PagedModel<T>();

            paged.CurrentPage = param.PageNumber;
            paged.PageSize = param.PageSize;

            paged.TotalItems = await query.CountAsync();


            paged.Items = await query.FilterByConditions(param.Filters)
                                     .Sorting(param.Sort)
                                     .Skip((param.PageNumber - 1) * param.PageSize)
                                     .Take(param.PageSize)                              
                                     .ToListAsync();

            paged.TotalPages = (int)Math.Ceiling(paged.TotalItems / (double)param.PageSize);

            return paged;
        }

        public static PagedModel<T> Paginate<T>(this IEnumerable<T> query, QueryParam param, long totalItems) where T : class
        {
            var paged = new PagedModel<T>();

            paged.CurrentPage = param.PageNumber;
            paged.PageSize = param.PageSize;

            paged.TotalItems = totalItems;

            paged.Items = query.ToList();

            paged.TotalPages = (int)Math.Ceiling(totalItems / (double)param.PageSize);

            return paged;
        }

        
    }
}
