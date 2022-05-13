using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CoreRelatorioFA.Models
{
    public class Sprint
    {
        public int SprintId { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z0-9 ]*$", ErrorMessage = "O nome da Spint deve atender ao padrão '^[A-Z0-9 ]*$'")]
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Display(Name = "Data inicial"), DataType(DataType.Date)]
        [Required]
        public DateTime StaDate { get; set; }
        
        [Display(Name = "Data final"), DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }

    }
}
