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
        public List<Models.Client> clientes { get; set; } = new List<Models.Client>();
        public List<Models.Products> listaProductos { get; set; } = new List<Models.Products>(); // Lista para mostrar productos
        public List<Models.Products> Carrito { get; set; } = new List<Models.Products>(); // Lista para almacenar productos en el carrito
        
        public void OnGet()
        {
            clientes = _context.Client.ToList();
            listaProductos = _context.Products.ToList();
            
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

        public IActionResult OnPostFinalizarCompra()
        {
            // Agregar la lógica para finalizar la compra
            // Puedes acceder a los productos en el carrito en la lista Carrito
            // Realiza la lógica de finalización de la compra aquí

            // Por ejemplo, puedes limpiar el carrito después de finalizar la compra
            Carrito.Clear();

            // Redirigir a una página de confirmación de compra u otra página relevante
            return RedirectToPage("CompraExitosa"); // Cambia a la página de confirmación de compra
        }

    }
}
