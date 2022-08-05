using System.ComponentModel.DataAnnotations;

namespace Data.DominiCode.Models
{
    public class ClientCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Requerimiento erroneo")]
        [StringLength(400, MinimumLength = 1, ErrorMessage = "Solo se acetan 400 caracteres")]
        public string CategoryName { get; set; }

        public bool Active { get; set; }
    }
}