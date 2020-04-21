namespace GEM.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Objective : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener más de {1} veinte caracteres")]
        [Display(Name = "Objetivo")]
        public string Name { get; set; }

    }
}
