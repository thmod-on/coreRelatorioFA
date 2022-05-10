using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Pages.Invoices
{
    public class DeleteModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;

        public DeleteModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Invoicing Invoicing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoicing = await _context.Invoices
                .Include(i => i.Contract).FirstOrDefaultAsync(m => m.InvoicingID == id);

            if (Invoicing == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoicing = await _context.Invoices.FindAsync(id);

            if (Invoicing != null)
            {
                _context.Invoices.Remove(Invoicing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
