using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_AllanMadriz
{
    public static class ObjetosGlobales
    {
        //Esta clase se "auto instancia" al momento de inicializar la aplicacion
        //los atributos y funciones que sean publicas seran visibles en la 
        //globalidad de la app

        public static Form MiFormularioPrincipal = new Formularios.FrmMDIPrincipal();

        public static Formularios.FrmUsuariosGestion MiFormDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();

    }
}
