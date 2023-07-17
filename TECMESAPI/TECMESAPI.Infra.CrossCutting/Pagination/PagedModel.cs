using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECMESAPI.CrossCutting.Pagination
{
    public class PagedModel<T> : IPagedModel<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public long TotalItems { get; set; }
        public bool HasPrevious { get => CurrentPage > 1; }
        public bool HasNext { get => CurrentPage < TotalPages; }

        public IList<T> Items { get; set; } = new List<T>();
    }
}
