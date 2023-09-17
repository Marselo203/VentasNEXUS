using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VentasNEXUS.Models
{
    public class NitInvalidoException : Exception
    {
        public NitInvalidoException() : base("El valor de Nit no puede ser cero.") { }
    }
    public class Client
    {
        public int ID { get; set; }

        private string _name;

        [RegularExpression("^[A-Z]+$", ErrorMessage = "El nombre debe estar en mayúsculas.")]
        public string Name
        {
            get { return _name; }
            set { _name = value?.ToUpper(); }
        }

        private string _lastName;

        [RegularExpression("^[A-Z]+$", ErrorMessage = "El apellido debe estar en mayúsculas.")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value?.ToUpper(); }
        }

        private int _nit;

        public int Nit
        {
            get { return _nit; }
            set
            {
                if (value == 0)
                {
                    throw new NitInvalidoException();
                }
                _nit = value;
            }
        }


    }
}
