using System.ComponentModel.DataAnnotations.Schema;

namespace TECMESAPI.Domain.Entities
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
