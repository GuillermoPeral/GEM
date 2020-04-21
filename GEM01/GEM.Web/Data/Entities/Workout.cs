namespace GEM.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Workout : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Cardio")]
        public string Cardio { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Brazo")]
        public string Arm { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Pecho")]
        public string Chest { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Espalda")]
        public string Back { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Abdomen")]
        public string Ab { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Pierna")]
        public string Leg { get; set; }
    }
}
