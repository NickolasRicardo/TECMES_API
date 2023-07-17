using System.ComponentModel.DataAnnotations;

namespace TECMESAPI.Domain.Entities
{
    public class ProducaoEntity : EntityBase
    {
        public int? Quantidade { get; set; }

        public long? MaquinaId { get; set; }

        public long? OrdemProducaoId { get; set; }

        public virtual MaquinaEntity? Maquina { get; set; }

        public virtual OrdemProducaoEntity? OrdemProducao { get; set; }
    }
}
