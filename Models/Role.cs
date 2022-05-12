using System.ComponentModel.DataAnnotations;

namespace CoreRelatorioFA.Models
{
    public class Role
    {
        [Required]
        public int RoleId { get; set; }
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Papel")]
        [Required]
        public string Name { get; set; }
    }
}