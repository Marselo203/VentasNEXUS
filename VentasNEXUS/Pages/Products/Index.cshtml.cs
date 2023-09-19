using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VentasNEXUS.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using VentasNEXUS.Models;

namespace VentasNEXUS.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public IndexModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        public IList<Models.Products> Products { get;set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? producGenre { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
            var pro = from a in _context.Products
                         select a;
            if (!string.IsNullOrEmpty(SearchString))
            {
                pro = pro.Where(s => s.Name.Contains(SearchString));
            }

            Products = await pro.ToListAsync();
        }
    }
}
