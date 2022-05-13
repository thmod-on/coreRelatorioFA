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

        [Display(Name = "E-mail"), RegularExpression(@"^[\w_\.]+@[\w\.-]+\.[\w]{2,3}$", ErrorMessage = "Email inválido")]
        public string Email { get; set; }
        
        [Column(TypeName = "decimal(11, 0)"), Range(0, 99999999999, ErrorMessage = "Máximo de 11 caracteres")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Favor fornecer apenas números'")]
        public decimal? CPF { get; set; }
        
        [Display(Name = "Telefone"), Column(TypeName = "decimal(15, 0)"), Range(0, 999999999999999, ErrorMessage = "Máximo de 15 caracteres")]
        public decimal? PhoneNumber { get; set; }
    }
}
