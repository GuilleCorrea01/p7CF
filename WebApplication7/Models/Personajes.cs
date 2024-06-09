using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Personajes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Per_Id { get; set; }

        [Required]
        public int Per_LibId { get; set; }

        [Required]
        public Libros Libros { get; set; }

        [Required]
        public int Per_RolId { get; set; }

        [Required]
        public Roles Per_Rol { get; set; }

        [Required]
        [StringLength(255)]
        public string Per_Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Per_Apellido { get; set; }

        [Required]
        [StringLength(101)]
        public string Per_Descripcion { get; set; }

        [Required]
        [StringLength(255)]
        public DateTime Per_FechaNacimiento { get; set; }

        [Required]
        [StringLength(255)]
        public string Per_LugarNacimiento { get; set; }

        [Required]
        [StringLength(255)]
        public string Per_Status { get; set; }
    }
}
