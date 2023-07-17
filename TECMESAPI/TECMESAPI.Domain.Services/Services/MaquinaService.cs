using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Domain.Interfaces.Services;

namespace TECMESAPI.Domain.Services.Services
{
    public class MaquinaService : ServiceBase<MaquinaEntity>, IMaquinaService
    {
        private readonly IMaquinaRepository _repository;

        public MaquinaService(IMaquinaRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
