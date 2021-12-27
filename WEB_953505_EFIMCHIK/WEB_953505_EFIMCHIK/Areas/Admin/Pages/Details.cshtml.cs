using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_953505_EFIMCHIK.Data;
using WEB_953505_EFIMCHIK.Entities;

namespace WEB_953505_EFIMCHIK.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly WEB_953505_EFIMCHIK.Data.ApplicationDbContext _context;

        public DetailsModel(WEB_953505_EFIMCHIK.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Auto Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auto = await _context.Cars
                .Include(a => a.Group).FirstOrDefaultAsync(m => m.AutoId == id);

            if (Auto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
