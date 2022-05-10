using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;

        public DetailsModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Companies.FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
