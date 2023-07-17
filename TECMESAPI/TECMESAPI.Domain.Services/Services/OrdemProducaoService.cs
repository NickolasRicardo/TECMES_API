using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class OrdemProducaoService : ServiceBase<OrdemProducaoEntity>, IOrdemProducaoService
    {
        private readonly IOrdemProducaoRepository _repository;

        public OrdemProducaoService(IOrdemProducaoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
