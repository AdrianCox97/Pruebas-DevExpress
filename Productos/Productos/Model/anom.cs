using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model
{
    class anom
    {
        public int IdAnomalias { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdPersonal { get; set; }
        public int IdProductos { get; set; }
        public string Respuesta { get; set; }
    }
}