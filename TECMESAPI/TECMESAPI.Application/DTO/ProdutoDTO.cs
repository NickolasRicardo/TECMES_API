namespace TECMESAPI.Application.DTO
{
    public class ProdutoDTO : DTOBase
    {
        public string Nome { get; set; }

        public virtual ICollection<OrdemProducaoDTO> OrdemProducaos { get; set; } =
            new List<OrdemProducaoDTO>();

        public virtual ICollection<VendaDTO> Venda { get; set; } = new List<VendaDTO>();
    }
}
