using TECMESAPI.Domain.Entities;
using TECMESAPI.Domain.Interfaces.Repository;
using TECMESAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace TECMESAPI.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<ProdutoEntity>, IProdutoRepository
    {
        public ProdutoRepository(DataBaseContext context)
            : base(context) { }
    }
}
