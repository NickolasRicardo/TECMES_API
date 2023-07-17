using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class ProducaoService : ServiceBase<ProducaoEntity>, IProducaoService
    {
        private readonly IProducaoRepository _repository;

        public ProducaoService(IProducaoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
