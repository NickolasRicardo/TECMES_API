using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class VendaService : ServiceBase<VendaEntity>, IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
