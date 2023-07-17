namespace TECMESAPI.Application.DTO
{
    public class ClienteDTO : DTOBase
    {
        public string Nome { get; set; }
        public virtual List<OrdemProducaoDTO>? OrdensProducao { get; set; }
    }
}
