using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VentasNEXUS.Data;
using VentasNEXUS.Models;

namespace VentasNEXUS.Pages.Sales
{
    public class IndexModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;

        public IndexModel(VentasNEXUSContext context)
        {
            _context = context;
        }
        public int spinnerValue { get; set; }
        public List<Models.Client> clientes { get; set; } = new List<Models.Client>();
        public List<Models.Products> listaProductos { get; set; } = new List<Models.Products>(); // Lista para mostrar productos
        public List<Models.Products> Carrito { get; set; } = new List<Models.Products>(); // Lista para almacenar productos en el carrito
        
        
        public IActionResult OnGet()
        {

           
            
            clientes = _context.Client.ToList();
            listaProductos = _context.Products.ToList();
            if (Request.Query.ContainsKey("miSpinner"))
            {
                spinnerValue = int.Parse(Request.Query["miSpinner"]);
                TempData["gasheta"] = spinnerValue;

            }
            else
            {
                spinnerValue = 3; 
                TempData["gasheta"] = spinnerValue;
            }

            
            return Page();
            
        }
       
        public IActionResult OnPostAgregarAlCarrito(int id)
        {
            var producto = _context.Products.FirstOrDefault(p=> p.ID== id);
            if (producto != null)
            {
                Carrito.Add(producto);
            }
            return Page();
        }
    }
}
