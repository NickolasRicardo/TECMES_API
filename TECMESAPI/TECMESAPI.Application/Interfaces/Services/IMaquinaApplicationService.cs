using TECMESAPI.Application.DTO;
using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Application.Interfaces.Services
{
    public interface IMaquinaApplicationService
        : IApplicationServiceBase<MaquinaEntity, MaquinaDTO> { }
}
