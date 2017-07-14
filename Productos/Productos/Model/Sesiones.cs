using System;

namespace CeramicaCarrillo.Model
{
    public class Sesiones
    {
        Boolean _Admin;
        String _Usuario;
        Int32 _Id;

        public bool Admin { get => _Admin; set => _Admin = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public int Id { get => _Id; set => _Id = value; }

        public Sesiones()
        {
            Admin = false;
            Usuario = String.Empty;
            Id = 0;
        }
    }
}
