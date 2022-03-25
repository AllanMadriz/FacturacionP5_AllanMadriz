
namespace FacturacionP5_AllanMadriz.Formularios
{
    partial class FrmUsuariosGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaUsuarios = new System.Windows.Forms.DataGridView();
            this.cIDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.btnVerPassword = new System.Windows.Forms.Button();
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailRespaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbVerActivos = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarForm = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).BeginInit();
            this.gbDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaUsuarios
            // 
            this.dgvListaUsuarios.AllowUserToAddRows = false;
            this.dgvListaUsuarios.AllowUserToDeleteRows = false;
            this.dgvListaUsuarios.AllowUserToResizeColumns = false;
            this.dgvListaUsuarios.AllowUserToResizeRows = false;
            this.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDUsuario,
            this.cNombre,
            this.cNombreUsuario,
            this.cCedula,
            this.cRol});
            this.dgvListaUsuarios.Location = new System.Drawing.Point(12, 68);
            this.dgvListaUsuarios.MultiSelect = false;
            this.dgvListaUsuarios.Name = "dgvListaUsuarios";
            this.dgvListaUsuarios.ReadOnly = true;
            this.dgvListaUsuarios.RowHeadersVisible = false;
            this.dgvListaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaUsuarios.Size = new System.Drawing.Size(776, 201);
            this.dgvListaUsuarios.TabIndex = 0;
            this.dgvListaUsuarios.VirtualMode = true;
            this.dgvListaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuarios_CellClick);
            this.dgvListaUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListaUsuarios_DataBindingComplete);
            // 
            // cIDUsuario
            // 
            this.cIDUsuario.DataPropertyName = "IDUsuario";
            this.cIDUsuario.HeaderText = "Codigo Usuario";
            this.cIDUsuario.Name = "cIDUsuario";
            this.cIDUsuario.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cNombre.DataPropertyName = "Nombre";
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cNombreUsuario
            // 
            this.cNombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cNombreUsuario.DataPropertyName = "NombreUsuario";
            this.cNombreUsuario.HeaderText = "Email";
            this.cNombreUsuario.Name = "cNombreUsuario";
            this.cNombreUsuario.ReadOnly = true;
            this.cNombreUsuario.Width = 180;
            // 
            // cCedula
            // 
            this.cCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cCedula.DataPropertyName = "Cedula";
            this.cCedula.HeaderText = "Cedula";
            this.cCedula.Name = "cCedula";
            this.cCedula.ReadOnly = true;
            this.cCedula.Width = 150;
            // 
            // cRol
            // 
            this.cRol.DataPropertyName = "Rol";
            this.cRol.HeaderText = "Tipo Usuario";
            this.cRol.Name = "cRol";
            this.cRol.ReadOnly = true;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.btnVerPassword);
            this.gbDetalles.Controls.Add(this.cboxTipoUsuario);
            this.gbDetalles.Controls.Add(this.label9);
            this.gbDetalles.Controls.Add(this.txtPassword);
            this.gbDetalles.Controls.Add(this.label8);
            this.gbDetalles.Controls.Add(this.txtEmailRespaldo);
            this.gbDetalles.Controls.Add(this.label7);
            this.gbDetalles.Controls.Add(this.txtTelefono);
            this.gbDetalles.Controls.Add(this.label6);
            this.gbDetalles.Controls.Add(this.txtCedula);
            this.gbDetalles.Controls.Add(this.label5);
            this.gbDetalles.Controls.Add(this.txtEmail);
            this.gbDetalles.Controls.Add(this.label4);
            this.gbDetalles.Controls.Add(this.txtNombre);
            this.gbDetalles.Controls.Add(this.label3);
            this.gbDetalles.Controls.Add(this.txtCodigo);
            this.gbDetalles.Controls.Add(this.label2);
            this.gbDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalles.Location = new System.Drawing.Point(12, 290);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(776, 257);
            this.gbDetalles.TabIndex = 1;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalle del Usuario";
            // 
            // btnVerPassword
            // 
            this.btnVerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPassword.Location = new System.Drawing.Point(727, 130);
            this.btnVerPassword.Name = "btnVerPassword";
            this.btnVerPassword.Size = new System.Drawing.Size(36, 23);
            this.btnVerPassword.TabIndex = 16;
            this.btnVerPassword.Text = "Ver";
            this.btnVerPassword.UseVisualStyleBackColor = true;
            this.btnVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerPassword_MouseDown);
            this.btnVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVerPassword_MouseUp);
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoUsuario.FormattingEnabled = true;
            this.cboxTipoUsuario.Location = new System.Drawing.Point(500, 173);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(261, 24);
            this.cboxTipoUsuario.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(498, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 22);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contrasenia";
            // 
            // txtEmailRespaldo
            // 
            this.txtEmailRespaldo.Location = new System.Drawing.Point(498, 87);
            this.txtEmailRespaldo.Name = "txtEmailRespaldo";
            this.txtEmailRespaldo.Size = new System.Drawing.Size(265, 22);
            this.txtEmailRespaldo.TabIndex = 11;
            this.txtEmailRespaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailRespaldo_KeyPress);
            this.txtEmailRespaldo.Leave += new System.EventHandler(this.txtEmailRespaldo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email Respaldo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(498, 44);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 22);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(70, 178);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(265, 22);
            this.txtCedula.TabIndex = 7;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cedula";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(70, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(116, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Usuario";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(12, 580);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 40);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(285, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBuscar.Location = new System.Drawing.Point(341, 30);
            this.txtBuscar.MaxLength = 20;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(183, 26);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbVerActivos
            // 
            this.cbVerActivos.AutoSize = true;
            this.cbVerActivos.Checked = true;
            this.cbVerActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVerActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerActivos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbVerActivos.Location = new System.Drawing.Point(635, 30);
            this.cbVerActivos.Name = "cbVerActivos";
            this.cbVerActivos.Size = new System.Drawing.Size(152, 20);
            this.cbVerActivos.TabIndex = 9;
            this.cbVerActivos.Text = "Ver Usuarios Activos";
            this.cbVerActivos.UseVisualStyleBackColor = true;
            this.cbVerActivos.CheckedChanged += new System.EventHandler(this.cbVerActivos_CheckedChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(129, 580);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 40);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(246, 580);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 40);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarForm
            // 
            this.btnLimpiarForm.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiarForm.Location = new System.Drawing.Point(538, 580);
            this.btnLimpiarForm.Name = "btnLimpiarForm";
            this.btnLimpiarForm.Size = new System.Drawing.Size(132, 40);
            this.btnLimpiarForm.TabIndex = 12;
            this.btnLimpiarForm.Text = "Limpiar Formulario";
            this.btnLimpiarForm.UseVisualStyleBackColor = false;
            this.btnLimpiarForm.Click += new System.EventHandler(this.btnLimpiarForm_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.Location = new System.Drawing.Point(676, 580);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 40);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmUsuariosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 639);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiarForm);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbVerActivos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbDetalles);
            this.Controls.Add(this.dgvListaUsuarios);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "FrmUsuariosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuariosGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuarios)).EndInit();
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuarios;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox cbVerActivos;
        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailRespaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarForm;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRol;
        private System.Windows.Forms.Button btnVerPassword;
    }
}