﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRelatorioFA.Models
{
    public class Invoicing
    {
        [Required]
        public int InvoicingID { get; set; }
        [Display(Name = "Valor da UST (R$)"), Column(TypeName = "decimal(9, 2)")]
        [Required]
        public decimal UstValue { get; set; }
        [Display(Name = "Data inicial do valor"), DataType(DataType.Date)]
        public DateTime UstValueIniDate { get; set; }
        [Display(Name = "Data final do valor"), DataType(DataType.Date)]
        public DateTime UstValueEndDate { get; set; }
        public int ContractID { get; set; }

        public Contract Contract { get; set; }
    }
}
