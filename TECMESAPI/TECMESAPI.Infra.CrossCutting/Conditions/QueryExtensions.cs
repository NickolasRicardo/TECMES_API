using System.Linq;
using System.Linq.Dynamic.Core;

namespace TECMESAPI.CrossCutting.Conditions
{
    public static class QueryExtensions
    {
        /// <summary>
        /// Filtra os valores baseado nas condicionais em string 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="conditions">Filtro em padrão SQL</param>
        /// <returns></returns>
        public static IQueryable<T> FilterByConditions<T>(this IQueryable<T> query, string conditions) where T : class
        {
            if (!string.IsNullOrEmpty(conditions))
            {
                var qry = query.Where(conditions);
                return qry;
            }
            return query;
        }

        /// <summary>
        /// Ordena os valores baseado nos campos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="sort">Campos para odernar (Ex: Id,-Descricao)</param>
        /// <returns></returns>
        public static IQueryable<T> Sorting<T>(this IQueryable<T> query, string sort) where T : class
        {
            if (!QueryHandle.SortingValidate(sort))
                return query;

            var sorting = QueryHandle.SortingHandling(sort);

            return query.OrderBy(sorting);
        }


    }
}
