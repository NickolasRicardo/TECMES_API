namespace TECMESAPI.Application.DTO
{
    public class MaquinaDTO : DTOBase
    {
        public string CodigoSerie { get; set; }

        public virtual ICollection<ProducaoDTO> Producoes { get; set; } = new List<ProducaoDTO>();
    }
}
