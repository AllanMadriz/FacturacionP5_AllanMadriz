using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaTipo
    {
        //En una estructura estandar de clase, primero se escriben los atributos simples
        //Luegos los atributos compuestos, despues las operaciones (metodos y funciones)
        //Ademas de constructor si es necesario

        //1.Atributos
        private int iDFacturaTipo;

        public int IDFacturaTipo
        {
            get { return iDFacturaTipo; }
            set { iDFacturaTipo = value; }
        }

        //Opcion de forma simplificada
        public string Tipo { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            //TODO: Escribir codigo para llenar R con los datos necesarios

            return R;
        }

    }
}
