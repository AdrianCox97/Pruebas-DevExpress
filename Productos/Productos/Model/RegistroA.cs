using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model
{
    public class RegistroA
    {
        BDCarrilloEntities datos;
        Acciones accion;
        String mensaje = string.Empty;

        public RegistroA()
        {
            datos = new BDCarrilloEntities();
        }
        
    }
}
