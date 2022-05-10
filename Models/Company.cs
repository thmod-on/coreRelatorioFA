using System.ComponentModel.DataAnnotations;

namespace CoreRelatorioFA.Models
{
    public class Company
    {
        [Required]
        public int CompanyId { get; set; }
        [Display(Name = "Nome")]
        [Required]
        public string CompanyName { get; set; }
        [Display(Name = "Logo")]
        public byte[] LogoBytes { get; set; }
    }
}
