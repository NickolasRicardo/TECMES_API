namespace TECMESAPI.Application.DTO
{
    public class VendaDTO : DTOBase
    {
        public int? Quantidade { get; set; }

        public sbyte? Status { get; set; }

        public long? OrdemProducaoId { get; set; }

        public long? ProdutoId { get; set; }

        public long? ClienteId { get; set; }

        public virtual ClienteDTO? Cliente { get; set; }

        public virtual OrdemProducaoDTO? OrdemProducao { get; set; }

        public virtual ProdutoDTO? Produto { get; set; }
    }
}
