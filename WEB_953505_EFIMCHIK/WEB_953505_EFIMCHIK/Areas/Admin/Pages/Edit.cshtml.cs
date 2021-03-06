using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_953505_EFIMCHIK.Data;
using WEB_953505_EFIMCHIK.Entities;

namespace WEB_953505_EFIMCHIK.Areas.Admin.Pages
{
    public class EditModel : PageModel
    {
        private readonly WEB_953505_EFIMCHIK.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public EditModel(WEB_953505_EFIMCHIK.Data.ApplicationDbContext context,
            IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }
        [BindProperty]
        public IFormFile Image { get; set; }
        [BindProperty]
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
            ViewData["AutoGroupId"] = new SelectList(_context.AutoGroups, "AutoGroupId", "GroupName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Image != null)
            {
                var fileName = $"{Auto.AutoId}" +
                Path.GetExtension(Image.FileName);
                Auto.Image = fileName;
                var path = Path.Combine(_environment.WebRootPath, "Images", fileName);
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fStream);
                }
                await _context.SaveChangesAsync();
            }

            _context.Attach(Auto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(Auto.AutoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AutoExists(int id)
        {
            return _context.Cars.Any(e => e.AutoId == id);
        }
    }
}
