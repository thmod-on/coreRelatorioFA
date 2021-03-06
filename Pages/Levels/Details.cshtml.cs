using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Pages.Levels
{
    public class DetailsModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;

        public DetailsModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

      public Level Level { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Level == null)
            {
                return NotFound();
            }

            var level = await _context.Level.FirstOrDefaultAsync(m => m.LevelId == id);
            if (level == null)
            {
                return NotFound();
            }
            else 
            {
                Level = level;
            }
            return Page();
        }
    }
}
