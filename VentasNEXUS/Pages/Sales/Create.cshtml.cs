using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VentasNEXUS.Data;
using VentasNEXUS.Models;

namespace VentasNEXUS.Pages.Sales
{
    public class CreateModel : PageModel
    {
        private readonly VentasNEXUS.Data.VentasNEXUSContext _context;
        

        public CreateModel(VentasNEXUS.Data.VentasNEXUSContext context)
        {
            _context = context;
        }

        public List<Models.Products> listaProductos_S { get; set; }
        public List<Models.Client> clie { get; set; }
        public int spinnerRecuperado { get; set; }
        public string nameClie { get; set; }
        public List <Models.Products> carrito { get; set; }
        public float suma { get; set; }
        public IActionResult OnGet()
        {
            suma = 0;
            carrito = ViewData["Carrito"] as List<Models.Products> ;
            spinnerRecuperado = (int)TempData["gasheta"];

            clie = _context.Client.ToList();
            listaProductos_S = _context.Products.ToList();
            
            for (int i = 0; i < listaProductos_S.Count; i++)
            {
                suma += listaProductos_S[i].Price;
            }
            foreach (var ga in clie)
            { 
                if (ga.ID == spinnerRecuperado)
                {
                    nameClie = ga.Name + " " + ga.LastName + " NIT: " + ga.Nit;
                }

            }
          
            return Page();
        }
    

        [BindProperty]
        public Models.Sales Sales { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sales.Add(Sales);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
