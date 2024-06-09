using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class Libros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Lib_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Lib_Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Lib_Autor { get; set; }

        [Required]
        [StringLength(255)]
        public string Lib_Genero { get; set; }

        [Required]
        [StringLength(255)]
        public string Lib_TipoProyecto { get; set; }

        [Required]
        [StringLength(255)]
        public string Lib_Status { get; set; }

        [InverseProperty]
        public ICollection<Personajes> Personajes { get; set; }
    }
}