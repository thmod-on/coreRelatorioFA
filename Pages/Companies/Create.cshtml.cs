using System;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;

namespace CoreRelatorioFA.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;
        
        public CreateModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }
        [BindProperty]
        public FileViewModel FileUpload { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Save images to database
            using (var memoryStream = new MemoryStream())
            {
                await FileUpload.FormFile.CopyToAsync(memoryStream);

                //Upload file if less than 2 MB
                if (memoryStream.Length < 2097152)
                {
                    Company.LogoBytes = memoryStream.ToArray();
                }
                else
                {
                    ModelState.AddModelError("File", "Arquivo maior que 2 MB");
                }
            }

            _context.Companies.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
