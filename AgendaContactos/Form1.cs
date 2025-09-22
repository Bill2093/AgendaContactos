namespace AgendaContactos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblBuscar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgv = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtBuscar = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnExportar = new Button();
            btnLimpiar = new Button();
            lblId = new Label();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeight = 29;
            dgv.Location = new Point(23, 293);
            dgv.Margin = new Padding(3, 4, 3, 4);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(960, 400);
            dgv.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(143, 24);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(62, 27);
            txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 69);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(407, 27);
            txtNombre.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(143, 117);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(199, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(141, 164);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(407, 27);
            txtCorreo.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(143, 211);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(405, 27);
            txtDireccion.TabIndex = 11;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(709, 24);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(273, 27);
            txtBuscar.TabIndex = 12;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(594, 73);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 31);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(709, 73);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(823, 73);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(594, 127);
            btnExportar.Margin = new Padding(3, 4, 3, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(86, 31);
            btnExportar.TabIndex = 16;
            btnExportar.Text = "Exportar CSV";
            btnExportar.Click += btnExportar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(777, 127);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblId
            // 
            lblId.Location = new Point(23, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(114, 31);
            lblId.TabIndex = 1;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(23, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(114, 31);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(23, 120);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(114, 31);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(23, 167);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(114, 31);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo";
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(23, 213);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(114, 31);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección";
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(594, 27);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(114, 31);
            lblBuscar.TabIndex = 6;
            lblBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 720);
            Controls.Add(dgv);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblDireccion);
            Controls.Add(lblBuscar);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDireccion);
            Controls.Add(txtBuscar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnExportar);
            Controls.Add(btnLimpiar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Agenda de Contactos";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
