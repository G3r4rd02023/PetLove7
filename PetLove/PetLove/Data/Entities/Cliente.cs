using System.ComponentModel.DataAnnotations;

namespace PetLove.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "DNI")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string LastName { get; set; }

        [Display(Name = "Teléfono")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        public string PhoneNumber { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres.")]
        [Display(Name = "Dirección")]
        public string Address { get; set; }

        [Display(Name = "Cliente")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Cliente")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
