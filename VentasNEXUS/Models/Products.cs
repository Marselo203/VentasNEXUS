using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VentasNEXUS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Products
    {
        public int ID { get; set; }

        private string _name;

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "El nombre debe estar en mayúsculas.")]
        public string Name
        {
            get { return _name; }
            set { _name = value?.ToUpper(); }
        }

        private float _price;

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, float.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _description;

        [Required(ErrorMessage = "La descripción es obligatoria.")]
        [RegularExpression("^[A-Z]+$", ErrorMessage = "La descripción debe estar en mayúsculas.")]
        public string Description
        {
            get { return _description; }
            set { _description = value?.ToUpper(); }
        }

        private int _stock;

        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El stock debe ser mayor o igual a cero.")]
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }

}
