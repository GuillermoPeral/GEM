﻿namespace GEM.Web.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BodyType : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(9, ErrorMessage = "El campo {0} no puede tener más de {1} nueve caracteres")]
        [Display(Name = "Tipo Cuerpo")]

        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
