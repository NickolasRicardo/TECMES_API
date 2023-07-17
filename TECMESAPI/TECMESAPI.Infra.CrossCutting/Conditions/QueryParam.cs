using TECMESAPI.CrossCutting.Pagination;

namespace TECMESAPI.CrossCutting.Conditions
{
    public class QueryParam: PagedParam
    {
        public string? Filters { get; set; }
        public string? Sort { get; set; }

    }
}
