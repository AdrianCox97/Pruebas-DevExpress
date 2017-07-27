using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model.Mensajes
{
    public abstract class MensajeProductos : Mensaje
    {
        public MensajeProductos(int personal) : base(personal)
        {
            TextoMensaje = BuscarPersonal(personal);
        }
    }

    public class MIngresoProductos : MensajeProductos
    {
        public MIngresoProductos(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje += " ha ingresado un nuevo producto al catálogo.";
        }
    }

    public class MSalidaProductos : MensajeProductos
    {
        public MSalidaProductos(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje += " ha eliminado un producto activo en el catálogo.";
        }
    }

    public class MCambioProductos : MensajeProductos
    {
        public MCambioProductos(int personal) : base(personal)
        {
        }

        public override void IngresarAccion(int personal)
        {
            TextoMensaje += " ha cambiado la información de un producto del catálogo.";
        }
    }

}
