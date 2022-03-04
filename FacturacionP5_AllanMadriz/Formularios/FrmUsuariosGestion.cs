using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionP5_AllanMadriz.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();
        }

        private void ListarUsuariosActivos()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            DataTable dt = MiUsuario.ListarActivos();

            dgvListaUsuarios.DataSource = dt;
        }
    }
}
