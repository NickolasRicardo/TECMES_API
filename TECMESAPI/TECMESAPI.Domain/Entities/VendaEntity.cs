using System.ComponentModel.DataAnnotations;

namespace TECMESAPI.Domain.Entities
{
    public class VendaEntity : EntityBase
    {
        public int? Quantidade { get; set; }

        public sbyte? Status { get; set; }

        public long? OrdemProducaoId { get; set; }

        public long? ProdutoId { get; set; }

        public long? ClienteId { get; set; }

        public virtual ClienteEntity? Cliente { get; set; }

        public virtual OrdemProducaoEntity? OrdemProducao { get; set; }

        public virtual ProdutoEntity? Produto { get; set; }
    }
}
