using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public int IDUsuario { get; set; }

        public string Nombre { get; set; }

        public string NombreUsuario { get; set; }

        public string Telefono { get; set; }

        public string CorreoDeRespaldo { get; set; }

        public string Contrasennia { get; set; }

        public string Cedula { get; set; }

        public bool Activo { get; set; }
    
        public UsuarioTipo MiTipo { get; set; }

        public Usuario()
        {
            MiTipo = new UsuarioTipo();
        }

        public bool Agregar()
        {
            bool R = false;

            //paso 1.6.1 y 1.6.2
            Conexion MiCnn3 = new Conexion();

            //TODO: Aplicar mecanismo de encriptacion para la constrasena

            //Lista de parametros que se enviaran al SP
            MiCnn3.ListaParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Email", this.NombreUsuario));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn3.ListaParametros.Add(new SqlParameter("@CorreoRespaldo", this.CorreoDeRespaldo));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn3.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn3.ListaParametros.Add(new SqlParameter("@IdRolUsuario", this.MiTipo.IDUsuarioRol));

            //Paso 1.6.3 y 1.6.4
            int Resultado = MiCnn3.EjecutarUpdateDeleteInsert("SpUsuariosAgregar");

            if (Resultado > 0)
            {
                R = true;
            }

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

            //Paso 1.3.1 y 1.3.2
            Conexion MiCnn = new Conexion();

            //Se deben agregar los params si el SP los requiere
            MiCnn.ListaParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            //Paso 1.3.4
            DataTable Consulta = MiCnn.EjecutarSelect("SpUsuarioConsultarPorCedula");

            //Paso 1.3.5
            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            //Paso 1.4.1 y 1.4.2
            Conexion MiCnn2 = new Conexion();

            //Se deben agregar los params si el SP los requiere
            MiCnn2.ListaParametros.Add(new SqlParameter("@Email", this.NombreUsuario));

            //Paso 1.4.4
            DataTable Consulta = MiCnn2.EjecutarSelect("SpUsuarioConsultarPorEmail");

            //Paso 1.4.5
            if (Consulta.Rows.Count > 0)
            {
                R = true;
            }

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

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SpUsuariosListarActivos");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }

    }
}
