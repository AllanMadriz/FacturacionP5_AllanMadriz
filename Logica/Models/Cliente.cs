using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Cliente
    {
        public int IDCliente { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public bool Activo { get; set; }
    
        //Atributos compuestos
        ClienteTipo MiTipo { get; set; }

        //Constructor de la clase para instanciar el atributo compuesto
        public Cliente()
        {
            MiTipo = new ClienteTipo();
        }

        //Esta funcion agregar() se usa con fines didacticos, ya que pasamos los valores
        //por medio de parametros. 

        public bool Agregar(string pNombre, string pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;

            //Cuando se usa esta forma el paso de valores se realiza por aca.
            Nombre = pNombre;
            Cedula = pCedula;
            Telefono = pTelefono;
            Email = pEmail;

            return R;
        }

        public bool Editar(int pIDCliente, string pNombre, string pCedula, string pTelefono = "", string pEmail = "")
        {
            bool R = false;

            return R;
        }

        public bool Eliminar(int pIDCliente)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID(string pIDcliente)
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
