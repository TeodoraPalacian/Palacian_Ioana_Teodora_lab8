using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Palacian_Ioana_Teodora_lab8.Data;
using Palacian_Ioana_Teodora_lab8.Models;

namespace Palacian_Ioana_Teodora_lab8.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Palacian_Ioana_Teodora_lab8.Data.Palacian_Ioana_Teodora_lab8Context _context;

        public DeleteModel(Palacian_Ioana_Teodora_lab8.Data.Palacian_Ioana_Teodora_lab8Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
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

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
