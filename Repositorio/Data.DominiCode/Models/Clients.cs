using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DominiCode.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Requerimiento erroneo")]
        [StringLength(400, MinimumLength = 1, ErrorMessage = "Solo se aceptan 400 caracteres")]
        public string ClientName { get; set; }

        [Required(ErrorMessage = "Requerimiento erroneo")]
        [EmailAddress(ErrorMessage = "It is not a valid mail")]
        [StringLength(500, MinimumLength = 1 , ErrorMessage = "Solo se aceptan 500 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerimiento erroneo")]
        [StringLength(25, MinimumLength = 5, ErrorMessage ="Solo se aceptan 25 caracteres")]
        [Phone(ErrorMessage = "Errror de numero")]
        public string PhoneNumber { get; set; }

        public DateTime RegisteredDate { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ClientCategory ClientCategory { get; set; }
    }
}