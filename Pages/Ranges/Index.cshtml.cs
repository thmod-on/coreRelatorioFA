#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRelatorioFA.Data;
using CoreRelatorioFA.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreRelatorioFA.Pages.Ranges
{
    public class IndexModel : PageModel
    {
        private readonly CoreRelatorioFA.Data.CoreRelatorioFAContext _context;

        public IndexModel(CoreRelatorioFA.Data.CoreRelatorioFAContext context)
        {
            _context = context;
        }

        public IList<Models.Sprint> RangeList { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList RangeNamesList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string RangeName { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> rangeListQuery = from r in _context.Sprint
                                                orderby r.Name
                                                select r.Name;

            var sprintRange = from r in _context.Sprint
                              select r;

            if (!string.IsNullOrEmpty(SearchString))
            {
                sprintRange = sprintRange.Where(r => r.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(RangeName))
            {
                sprintRange = sprintRange.Where(x => x.Name == RangeName);
            }

            RangeNamesList = new SelectList(await rangeListQuery.Distinct().ToListAsync());
            RangeList = await sprintRange.ToListAsync();
        }
    }
}
