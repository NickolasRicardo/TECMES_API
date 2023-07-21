using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Domain.Interfaces.Services
{
    public interface IVendaService : IServiceBase<VendaEntity> { 
        Task Autorizar(long id);
    }
}
