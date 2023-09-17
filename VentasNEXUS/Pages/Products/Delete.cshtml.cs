using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VentasNEXUS.Data;
using VentasNEXUS.Models;

namespace VentasNEXUS.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public DeleteModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Products Products { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Products = await _context.Products.FirstOrDefaultAsync(m => m.ID == id);

            if (Products == null)
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

            Products = await _context.Products.FindAsync(id);

            if (Products != null)
            {
                _context.Products.Remove(Products);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
