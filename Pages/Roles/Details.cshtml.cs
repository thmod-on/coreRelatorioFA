﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Pages.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;

        public DetailsModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

      public Role Role { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Role == null)
            {
                return NotFound();
            }

            var role = await _context.Role.FirstOrDefaultAsync(m => m.RoleId == id);
            if (role == null)
            {
                return NotFound();
            }
            else 
            {
                Role = role;
            }
            return Page();
        }
    }
}
