namespace TECMESAPI.Application.DTO
{
    public class MaquinaDTO : DTOBase
    {
        public string CodigoSerie { get; set; }

        public virtual ICollection<ProducaoDTO> Producaos { get; set; } = new List<ProducaoDTO>();
    }
}
