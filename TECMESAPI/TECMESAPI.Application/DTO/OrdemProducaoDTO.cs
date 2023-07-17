namespace TECMESAPI.Application.DTO
{
    public class OrdemProducaoDTO : DTOBase
    {
        public string NumeroOrdemProducao { get; set; }
        public int Quantidade { get; set; }
        public int Status { get; set; }
        public virtual ClienteDTO Cliente { get; set; }
        public virtual ProdutoDTO Produto { get; set; }
    }
}
