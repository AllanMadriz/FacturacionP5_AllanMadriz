using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    class Usuario
    {
        public int IDUsuario { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public string CorreoDeRespaldo { get; set; }

        public string Contrasennia { get; set; }

        public string Cedula { get; set; }

        public bool Activo { get; set; }
    
        UsuarioTipo MiTipo { get; set; }

        public Usuario()
        {
            MiTipo = new UsuarioTipo();
        }

        public bool Agregar()
        {
            bool R = false;


            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }


        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
