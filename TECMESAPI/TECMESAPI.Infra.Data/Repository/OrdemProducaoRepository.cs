using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class OrdemProducaoRepository
        : RepositoryBase<OrdemProducaoEntity>,
            IOrdemProducaoRepository
    {
        public OrdemProducaoRepository(DataBaseContext context)
            : base(context) { }
    }
}
