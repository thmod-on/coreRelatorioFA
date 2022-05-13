using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRelatorioFA.Models
{
    public class Level
    {
        [Required]
        public int LevelId { get; set; }
        [Display(Name = "Cargo")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Display(Name = "Fator de ajuste")]
        [Required]
        public decimal Factor { get; set; }
        [Display(Name = "Contrato")]
        [Required]
        public int ContractID { get; set; }

        public Contract Contract { get; set; }
    }
}
