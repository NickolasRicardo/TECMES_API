using System.ComponentModel.DataAnnotations;

namespace TECMESAPI.Domain.Entities
{
    public class OrdemProducaoEntity : EntityBase
    {
        public string? NumeroOrdemProducao { get; set; }

        public int? Quantidade { get; set; }

        public sbyte? Status { get; set; }

        public long? ClienteId { get; set; }

        public long? ProdutoId { get; set; }

        public virtual ClienteEntity? Cliente { get; set; }

        public virtual ICollection<ProducaoEntity> Producao { get; set; } =
            new List<ProducaoEntity>();

        public virtual ProdutoEntity? Produto { get; set; }

        public virtual ICollection<VendaEntity> Venda { get; set; } = new List<VendaEntity>();
    }
}
