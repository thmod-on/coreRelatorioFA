using System.ComponentModel.DataAnnotations;

namespace CoreRelatorioFA.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        [Display(Name = "Nome do time")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Nome do responsável"), StringLength(100, MinimumLength = 10)]
        [Required]
        public string HeadName { get; set; }

        [Display(Name = "Cargo do responsável"), StringLength(50, MinimumLength = 10)]
        [Required]
        public string HeadRole { get; set; }

        [Display(Name = "Área que o time pertence"), StringLength(50, MinimumLength = 5)]
        [Required]
        public string AreaName { get; set; }
    }
}
