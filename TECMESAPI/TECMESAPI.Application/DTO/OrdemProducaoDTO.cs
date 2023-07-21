using TECMESAPI.Domain.Entities;

namespace TECMESAPI.Application.DTO
{
    public class OrdemProducaoDTO : DTOBase
    {
        public string? NumeroOrdemProducao { get; set; }

        public int? Quantidade { get; set; }

        public sbyte? Status { get; set; } = 0;

        public long? ClienteId { get; set; }

        public long? ProdutoId { get; set; }

        public virtual ClienteDTO? Cliente { get; set; }
        public virtual ProdutoDTO? Produto { get; set; }
    }
}
