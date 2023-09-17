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
    public class IndexModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public IndexModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        public IList<Models.Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}
