using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<ClienteEntity>, IClienteRepository
    {
        public ClienteRepository(DataBaseContext context)
            : base(context) { }
    }
}
