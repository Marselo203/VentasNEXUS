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

namespace VentasNEXUS.Pages.Client
{
    public class IndexModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public IndexModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        public IList<Models.Client> Client { get;set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
            var clientee = from m in _context.Client
                           select m;
            var cli = from m in _context.Client
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                cli = cli.Where(s => s.Name.Contains(SearchString));
            }

            Client = await cli.ToListAsync();
        }
    }
}
