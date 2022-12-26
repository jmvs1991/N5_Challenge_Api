using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace N5Challenge.Domain.Entities
{
    [Table("TipoPermisos", Schema = "dbo")]
    public partial class TypeEntity : BaseEntity
    {
        [Required]
        [Column("Descripcion")]
        [StringLength(150)]
        public string Description { get; set; }
    }
}
