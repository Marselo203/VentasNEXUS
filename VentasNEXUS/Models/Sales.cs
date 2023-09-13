using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentasNEXUS.Models
{
    public class Sales
    {
        public int id_s { get; set; }
        public Client Client_s{get; set;}
        public Products product_s { get; set; }
    }
}
