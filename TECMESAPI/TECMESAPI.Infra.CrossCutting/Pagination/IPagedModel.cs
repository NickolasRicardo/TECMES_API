
namespace TECMESAPI.CrossCutting.Pagination
{
    public interface IPagedModel<T>
    {
        int CurrentPage { get; set; }
        bool HasNext { get; }
        bool HasPrevious { get; }
        IList<T> Items { get; set; }
        int PageSize { get; set; }
        long TotalItems { get; set; }
        int TotalPages { get; set; }
    }
}