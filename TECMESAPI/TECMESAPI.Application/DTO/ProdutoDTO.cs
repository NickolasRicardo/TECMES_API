namespace TECMESAPI.Application.DTO
{
    public class ProdutoDTO : DTOBase
    {
        public string Nome { get; set; }
        public virtual List<OrdemProducaoDTO>? OrdensProducao { get; set; }
    }
}
