using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCC.Entity
{
    public class ClienteContacto
    {
        #region Variables

        //cliente
        public int nIdCliente01 { get; set; }
        public string sClave { get; set; }
        public string sNombre { get; set; }
        public string sApellidoPat { get; set; }
        public string sApellidoMat { get; set; }
        public string sRazonSocial { get; set; }
        public int bTipoPersona { get; set; }
        public string sNombreComercial { get; set; }
        public string sCalle { get; set; }
        public string nCodigoPostal { get; set; }
        public string nExterior { get; set; }
        public string sColonia { get; set; }
        public string sMunicipio { get; set; }
        public string sEstado { get; set; }
        public string sPais { get; set; }
        public string sRFC { get; set; }
        public string sCURP { get; set; }
        public string nNumeroTelefono { get; set; }
        public string sEmail { get; set; }
        public int bEstatus { get; set; }

        #endregion Variables

        #region Constructor

        public ClienteContacto()
        {

        }

        #endregion Constructor

    }
}
