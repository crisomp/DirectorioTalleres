using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DirectorioTalleres.Shared
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [Display(Name = "Usuario")]
        [Column(TypeName = "Varchar(200)")]
        public string? CorreoElectronico { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [Display(Name = "Contraseña")]
        [Column(TypeName = "Varchar(50)")]
        public string? Contrasena { get; set; }

        [Required(ErrorMessage = "Requerido")]
        [Display(Name = "Nombre Completo")]
        [Column(TypeName = "Varchar(50)")]
        public string? NombreCompleto { get; set; }

        [Column(TypeName = "bit")]
        public bool Activo { get; set; }
    }
}