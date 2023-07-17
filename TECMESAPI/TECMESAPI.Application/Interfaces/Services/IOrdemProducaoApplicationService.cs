using TECMESAPI.Application.DTO;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Application.Interfaces.Services
{
    public interface IOrdemProducaoApplicationService
        : IApplicationServiceBase<OrdemProducaoEntity, OrdemProducaoDTO> { }
}
