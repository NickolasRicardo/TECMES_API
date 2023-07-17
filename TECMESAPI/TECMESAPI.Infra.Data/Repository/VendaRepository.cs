using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class VendaRepository : RepositoryBase<VendaEntity>, IVendaRepository
    {
        public VendaRepository(DataBaseContext context)
            : base(context) { }
    }
}
