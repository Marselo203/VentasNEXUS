using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VentasNEXUS.Data;
using VentasNEXUS.Models;

namespace VentasNEXUS.Pages.Client
{
    public class DeleteModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public DeleteModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.ID == id);

            if (Client == null)
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

            Client = await _context.Client.FindAsync(id);

            if (Client != null)
            {
                _context.Client.Remove(Client);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
