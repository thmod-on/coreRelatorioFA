using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRelatorioFA.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        
        [Column(TypeName = "decimal(11, 0)")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Favor fornecer apenas números'")]
        [Range(0, 11, ErrorMessage = "Máximo de 11 caracteres")]
        public decimal? CPF { get; set; }
        
        [Display(Name = "Telefone"), Column(TypeName = "decimal(15, 0)"), Range(0, 15, ErrorMessage = "Máximo de 15 caracteres")]
        public decimal? PhoneNumber { get; set; }
    }
}
