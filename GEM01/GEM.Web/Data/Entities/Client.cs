namespace GEM.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Client : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} veinticinco caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(25, ErrorMessage = "El campo {0} no puede tener más de {1} veinticinco caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Altura")]
        public double Height { get; set; }

        [Display(Name = "Peso")]
        public double Width { get; set; }

        [Display(Name = "Nombre")]
        public string FullName => $"{LastName} {FirstName}";
        [Display(Name = "Género")]
        public Gender Gender { get; set; }
        public BodyType BodyType { get; set; }
    }
}
