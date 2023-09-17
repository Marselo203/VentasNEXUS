using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentasNEXUS.Models
{
    public class Sales
    {
        public int ID { get; set; }
        public Client Client_s{get; set;}
        public List<Products> listaProductos_S { get; set; }
    }
}
