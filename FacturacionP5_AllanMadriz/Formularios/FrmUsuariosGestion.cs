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

        //Al igual que con cualquier otra clase se pueden escribir atributos para la misma
        //en este caso vamos a tener un obj de tipo usuario de fondo
        //el cual me permite manipular los cambios que el usuario haga en todo momento

        public Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            //Paso 1.1 y 1.2
            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            ListarUsuariosActivos();
            CargarRolesDeUsuarioEnCombo();
        }

        private void CargarRolesDeUsuarioEnCombo()
        {
            //Crear un obj de tipo UsuarioRol
            Logica.Models.UsuarioTipo ObjRolDeUsuario = new Logica.Models.UsuarioTipo();

            DataTable ListaRoles = new DataTable();

            ListaRoles = ObjRolDeUsuario.Listar();

            cboxTipoUsuario.ValueMember = "id";
            cboxTipoUsuario.DisplayMember = "d";

            cboxTipoUsuario.DataSource = ListaRoles;

            cboxTipoUsuario.SelectedIndex = -1;
        }

        private void ListarUsuariosActivos()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            DataTable dt = MiUsuario.ListarActivos();

            dgvListaUsuarios.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //En la secuencia no se explica, pero se debe realizar una serie de validaciones de
            //datos minimos y ed tipos y extensiones correctas para cada campo

            //TODO: Agregar funcionalidad de validacion

            //TEMPORAL: Se agregan los valores de los atributos del objeto local
            MiUsuarioLocal.Nombre = txtNombre.Text.Trim();
            MiUsuarioLocal.NombreUsuario = txtEmail.Text.Trim();
            MiUsuarioLocal.Cedula = txtCedula.Text.Trim();
            MiUsuarioLocal.Telefono = txtTelefono.Text.Trim();
            MiUsuarioLocal.Contrasennia = txtPassword.Text.Trim();
            MiUsuarioLocal.CorreoDeRespaldo = txtEmailRespaldo.Text.Trim();
            MiUsuarioLocal.MiTipo.IDUsuarioRol = Convert.ToInt32(cboxTipoUsuario.SelectedValue);

            //Solo en este caso vamos a seguir la numeracion de las secuencia "SeqUsuarioAgregar"

            //Paso 1.1 y 1.2 esta en el constructor

            //Paso 1.3 y 1.6
            bool A = MiUsuarioLocal.ConsultarPorCedula();

            //paso 1.4 y 1.4.6
            bool B = MiUsuarioLocal.ConsultarPorEmail();

            //paso 1.5 
            if (!A && !B)
            {
                //Paso 1.6
                if (MiUsuarioLocal.Agregar())
                {
                    //Paso 1.8
                    MessageBox.Show("Usuario agregado correctamente!", "", MessageBoxButtons.OK);
                }
                else
                {
                    //Paso 1.8
                    MessageBox.Show("Ha ocurrido un error y el usuario no se guardo", "", MessageBoxButtons.OK);
                }
                ListarUsuariosActivos();
            }
            else
            {
                //En este caso tenemos que indicar 
                if (A)
                {
                    MessageBox.Show("Ya existe un usuario con la cedula digitada", "Error de Validacion", MessageBoxButtons.OK);
                    txtCedula.Focus();
                    txtCedula.SelectAll();
                }
                if (B)
                {
                    MessageBox.Show("Ya existe un usuario con el Email digitado", "Error de Validacion", MessageBoxButtons.OK);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
        }

        private void dgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListaUsuarios.ClearSelection();
        }
    }
}
