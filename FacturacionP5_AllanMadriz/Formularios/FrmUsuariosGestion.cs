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
            MdiParent = ObjetosGlobales.MiFormularioPrincipal;

            ListarUsuariosActivos();

            CargarRolesDeUsuarioEnCombo();

            LimpiarForm();

            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void ActivarEditarYEliminar()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void LimpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtEmailRespaldo.Clear();
            txtPassword.Clear();
            cboxTipoUsuario.SelectedIndex = -1;
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

        private void ListarUsuariosDesactivados()
        {
            Logica.Models.Usuario MiUsuario = new Logica.Models.Usuario();

            DataTable dt = MiUsuario.ListarInactivos();

            dgvListaUsuarios.DataSource = dt;

            dgvListaUsuarios.ClearSelection();
        }

        private bool ValidarDatosRequeridos()
        {
            bool R = false;

            if (
                !string.IsNullOrEmpty(txtNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(txtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(txtCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(txtTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(txtEmailRespaldo.Text.Trim()) &&
                !string.IsNullOrEmpty(txtPassword.Text.Trim()) &&
                cboxTipoUsuario.SelectedIndex > -1
                )
            {
                //TODO: Validar la contrasena solo en agregar
                if (btnEditar.Enabled)
                {
                    R = true;
                }
                else
                {
                    //Si el boton de editar esta "apagado" la unica otra opcion
                    //es que estemos en modo de Agregacion y aca si debomos validar
                    //el password
                    if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        R = true;
                    }
                }
            }
            else
            {
                //Retroalimentar el usuario en que se esta fallando
                //debemos de evaluar cada cuadro ed texto para ver si no lo digito
                //y dar el aviso correspondiente
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    MessageBox.Show("El nombre del usuaro es requerido", "Error de validacion", MessageBoxButtons.OK);
                    txtNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("El email es requerido", "Error de validacion", MessageBoxButtons.OK);
                    txtEmail.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtCedula.Text.Trim()))
                {
                    MessageBox.Show("La cedula es requerida", "Error de validacion", MessageBoxButtons.OK);
                    txtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
                {
                    MessageBox.Show("El telefono es requerido", "Error de validacion", MessageBoxButtons.OK);
                    txtTelefono.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtEmailRespaldo.Text.Trim()))
                {
                    MessageBox.Show("El correo de respaldo es requerido", "Error de validacion", MessageBoxButtons.OK);
                    txtEmailRespaldo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("La contrasennia es requerido", "Error de validacion", MessageBoxButtons.OK);
                    txtPassword.Focus();
                    return false;
                }

                if (cboxTipoUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("El tipo de usuario es requerido", "Error de validacion", MessageBoxButtons.OK);
                    cboxTipoUsuario.Focus();
                    return false;
                }
            }

            return R;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //En la secuencia no se explica, pero se debe realizar una serie de validaciones de
            //datos minimos y ed tipos y extensiones correctas para cada campo

            if (ValidarDatosRequeridos())
            {
                string Pregunta = string.Format("Esta seguro de agregar el usuario {0}?", txtNombre.Text.Trim());

                DialogResult RespuestaDelUsuario = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (RespuestaDelUsuario == DialogResult.Yes)
                {

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
                        LimpiarForm();
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
            }
        }

        private void dgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListaUsuarios.ClearSelection();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresNumeros(e);

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, true);

        }

        private void txtEmailRespaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e, false, true);

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validacion.CaracteresTexto(e);
             
        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarAgregar();
        }

        private void dgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //El siguiente codigo permite que al hacer clic sobre una linea del dgv
            //los datos de ese usuario se muestren en el formulario y ademas el obj
            //de usuario local tambien se carga con dicha info
            if(dgvListaUsuarios.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = dgvListaUsuarios.SelectedRows[0];

                int IdUsuarioSeleccionado = Convert.ToInt32(Fila.Cells["cIDUsuario"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IdUsuarioSeleccionado);

                if(MiUsuarioLocal.IDUsuario > 0)
                {
                    //Se representa la infor en los controles respectivos usando el obj como fuente de datos
                    LimpiarForm();

                    txtCodigo.Text = MiUsuarioLocal.IDUsuario.ToString();
                    txtNombre.Text = MiUsuarioLocal.Nombre;
                    txtEmail.Text = MiUsuarioLocal.NombreUsuario;
                    txtCedula.Text = MiUsuarioLocal.Cedula;
                    txtTelefono.Text = MiUsuarioLocal.Telefono;
                    txtEmailRespaldo.Text = MiUsuarioLocal.CorreoDeRespaldo;

                    cboxTipoUsuario.SelectedValue = MiUsuarioLocal.MiTipo.IDUsuarioRol;

                    ActivarEditarYEliminar();

                    //Debemos considerar si la lista que se esta visualizando es la de usuario
                    //activos o incativos, en caso de que sean los inactivos, se debe desactivar
                    //la edicion de los campos y la utilizacion del boton editar

                    if (cbVerActivos.Checked)
                    {
                        gbDetalles.Enabled = true;
                        btnEditar.Enabled = true;
                    }
                    else
                    {
                        gbDetalles.Enabled = false;
                        btnEditar.Enabled = false;
                    }
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //El codigo es muy similar al de agregar. Primero se validan los datos requeridos
            if (ValidarDatosRequeridos())
            {
                string Mensaje = string.Format("Desea continuar con la modificacion del usuario {0}?", txtNombre.Text.Trim());
                DialogResult respuesta = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    MiUsuarioLocal.Nombre = txtNombre.Text.Trim();
                    MiUsuarioLocal.NombreUsuario = txtEmail.Text.Trim();
                    MiUsuarioLocal.Cedula = txtCedula.Text.Trim();
                    MiUsuarioLocal.Telefono = txtTelefono.Text.Trim();
                    MiUsuarioLocal.CorreoDeRespaldo = txtEmailRespaldo.Text.Trim();
                    MiUsuarioLocal.Contrasennia = txtPassword.Text.Trim();
                    MiUsuarioLocal.MiTipo.IDUsuarioRol = Convert.ToInt32(cboxTipoUsuario.SelectedValue);

                    if (MiUsuarioLocal.Editar())
                    {
                        string MensajeExito = string.Format("El usuario {0} se ha modificado correctamente", MiUsuarioLocal.Nombre);
                        MessageBox.Show(MensajeExito, ":)", MessageBoxButtons.OK);

                        ListarUsuariosActivos();
                        LimpiarForm();
                        ActivarAgregar();
                    }
                    else
                    {
                        string MensajeFracaso = string.Format("El usuario {0} no se ha modificado correctamente", MiUsuarioLocal.Nombre);
                        MessageBox.Show(MensajeFracaso, ":(", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //Al salir del cuadro texto validamos en tiempo real que el formato del email sea el correcto
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()) && !Validacion.ValidarEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("El formato del email es incorrecto", "Error de validacion", MessageBoxButtons.OK);
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void txtEmailRespaldo_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmailRespaldo.Text.Trim()) && !Validacion.ValidarEmail(txtEmailRespaldo.Text.Trim()))
            {
                MessageBox.Show("El formato del email de respaldo es incorrecto", "Error de validacion", MessageBoxButtons.OK);
                txtEmail.Focus();
                txtEmail.SelectAll();
            }
        }

        private void btnVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MiUsuarioLocal.IDUsuario > 0)
            {

                Logica.Models.Usuario UsuarioConsulta = new Logica.Models.Usuario();

                UsuarioConsulta = MiUsuarioLocal.ConsultarPorID(MiUsuarioLocal.IDUsuario);

                if(UsuarioConsulta.IDUsuario > 0)
                {
                    string Mensaje = "";

                    if (cbVerActivos.Checked)
                    {
                        Mensaje = string.Format("Desea continuar con la eliminacion del usuario {0}", MiUsuarioLocal.Nombre);
                    }
                    else
                    {
                        Mensaje = string.Format("Desea continuar con la Activacion del usuario {0}", MiUsuarioLocal.Nombre);

                    }

                    DialogResult resp = MessageBox.Show(Mensaje, "???", MessageBoxButtons.YesNo);

                    if (resp == DialogResult.Yes)
                    {

                        if (cbVerActivos.Checked)
                        {
                            if (MiUsuarioLocal.Eliminar())
                            {
                                MessageBox.Show("Usuario eliminado correctamente", ":/", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if (MiUsuarioLocal.Activar())
                            {
                                MessageBox.Show("Usuario activado correctamente", ":/", MessageBoxButtons.OK);
                            }
                        }
                        
                        ListarUsuariosActivos();
                        LimpiarForm();
                        ActivarAgregar();

                    }
                }
            }
        }

        private void cbVerActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerActivos.Checked)
            {
                btnEliminar.Text = "ELIMINAR";
                ListarUsuariosActivos();
                LimpiarForm();
            }
            else
            {
                btnEliminar.Text = "ACTIVAR";
                ListarUsuariosDesactivados();
                LimpiarForm();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()) && 
                !Validacion.ValidarPassword(txtPassword.Text.Trim()))
            {
                MessageBox.Show("La contrasennia debe tener Mayuscula\n" +
                    "Minuscula\n" +
                    "Numeros enteros\n" +
                    "Caracter especial\n", "Error de validacion", MessageBoxButtons.OK);
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }
    }
}
