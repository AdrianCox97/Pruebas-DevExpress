using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicaCarrillo.Model.Mensajes
{
    public abstract class Mensaje
    {
        BDCarrilloEntities datos;
        String textoMensaje = string.Empty;
        Acciones accion;

        public Mensaje(int personal)
        {
            datos = new BDCarrilloEntities();
            IngresarAccion(personal);
            GuardarRegistro(personal);
        }

        public string TextoMensaje { get { return textoMensaje; } set { textoMensaje = value; } }

        public abstract void IngresarAccion(int personal);

        public String BuscarPersonal(int empleado)
        {
            var personal = (from e in datos.Personal
                            where empleado == e.IdPersonal
                            select new
                            {
                                e.Nombre,
                                e.Apellido
                            }).FirstOrDefault();
            return personal.Nombre + " " + personal.Apellido;
        }

        void GuardarRegistro(int idPersonal)
        {
            accion = new Acciones()
            {
                Descripcion = TextoMensaje,
                Fecha = DateTime.Now,
                IdPersonal = idPersonal
            };
            datos.Acciones.Add(accion);
            datos.SaveChanges();
        }
        
    }
}
