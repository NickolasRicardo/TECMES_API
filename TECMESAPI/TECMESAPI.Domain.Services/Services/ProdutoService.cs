using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class ProdutoService : ServiceBase<ProdutoEntity>, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
