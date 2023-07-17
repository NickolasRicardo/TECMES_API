namespace TECMESAPI.Domain.Entities
{
    public class MaquinaEntity : EntityBase
    {
        public string CodigoSerie { get; set; }

        public virtual ICollection<ProducaoEntity> Producaos { get; set; } =
            new List<ProducaoEntity>();
    }
}
