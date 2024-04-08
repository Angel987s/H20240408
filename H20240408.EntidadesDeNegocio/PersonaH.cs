using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PersonaH
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [Display(Name = "Nombre")]
    public string NombreH { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio")]
    [Display(Name = "Apellido")]
    public string ApellidoH { get; set; }

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [Display(Name = "Fecha De Nacimiento")]
    public DateTime FechaNacimientoH { get; set; }

    [Required(ErrorMessage = "El sueldo es obligatorio")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    [Display(Name = "Sueldo")]
    public decimal SueldoH { get; set; }

    [Required(ErrorMessage = "El estatus es obligatorio")]
    [Display(Name = "Estatus")]
    public byte EstatusH { get; set; }

    [Display(Name = "Comentario")]
    public string ComentarioH { get; set; }

    [NotMapped]
    public int Take { get; set; }

}
