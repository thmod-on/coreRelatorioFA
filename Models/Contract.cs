using System.ComponentModel.DataAnnotations;

namespace CoreRelatorioFA.Models
{
    public class Contract
    {
        [Required]
        public int ContractId { get; set; }
        [Display(Name = "SAP")]
        [Required]
        public string Sap { get; set; }
        [Display(Name = "Ativo")]
        public bool Active { get; set; }

        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
