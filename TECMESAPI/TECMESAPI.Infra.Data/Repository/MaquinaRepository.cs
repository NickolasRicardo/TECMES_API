using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class MaquinaRepository : RepositoryBase<MaquinaEntity>, IMaquinaRepository
    {
        public MaquinaRepository(DataBaseContext context)
            : base(context) { }
    }
}
