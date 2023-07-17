using System.ComponentModel.DataAnnotations;

namespace TECMESAPI.Domain.Entities
{
    public class ClienteEntity : EntityBase
    {
        public string Nome { get; set; }

        public virtual ICollection<OrdemProducaoEntity> OrdemProducaos { get; set; } =
            new List<OrdemProducaoEntity>();

        public virtual ICollection<VendaEntity> Venda { get; set; } = new List<VendaEntity>();
    }
}
