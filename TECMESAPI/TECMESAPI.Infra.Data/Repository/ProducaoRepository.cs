using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class ProducaoRepository : RepositoryBase<ProducaoEntity>, IProducaoRepository
    {
        public ProducaoRepository(DataBaseContext context)
            : base(context) { }
    }
}
