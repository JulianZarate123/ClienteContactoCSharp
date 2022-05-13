using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCC.Entity
{
    public class Contacto
    {

        public int IdContacto02 { get; set; }
        public string ClaveContacto { get; set; }
        public string NombreContacto { get; set; }
        public string Puesto { get; set; }
        public string TelefonoContacto { get; set; }
        public string EmailContacto { get; set; }
        public int IdClienteContacto { get; set; }

        #region Constructor

        public Contacto()
        {

        }

        #endregion Constructor
    }

}
