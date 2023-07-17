namespace TECMESAPI.Application.DTO
{
    public class ProducaoDTO : DTOBase
    {
        public int? Quantidade { get; set; }

        public long? MaquinaId { get; set; }

        public long? OrdemProducaoId { get; set; }

        public virtual MaquinaDTO? Maquina { get; set; }

        public virtual OrdemProducaoDTO? OrdemProducao { get; set; }
    }
}
