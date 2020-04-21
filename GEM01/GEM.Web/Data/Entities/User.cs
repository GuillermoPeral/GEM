namespace GEM.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} nueve caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} nueve caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Fotografia")]
        public string ImageUrl { get; set; }

        [Display(Name = "Nombre")]
        public string FullName => $"{LastName} {FirstName}";
        public Gender Gender { get; set; }
    }
}
