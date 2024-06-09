using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rol_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Rol_Descripcion { get; set; }

        [Required]
        [StringLength(255)]
        public string Rol_Status { get; set; }

        public ICollection<Personajes> Personajes { get; set; }
    }
}
