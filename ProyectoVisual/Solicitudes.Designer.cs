namespace ProyectoVisual
{
    partial class Solicitudes
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtCodigoMaestro = new System.Windows.Forms.TextBox();
            this.txtCodigoClase = new System.Windows.Forms.TextBox();
            this.txtCantidadColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.txtCodigoSolicitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadNegro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.proyectoDataSet6 = new ProyectoVisual.ProyectoDataSet6();
            this.solicitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudesTableAdapter = new ProyectoVisual.ProyectoDataSet6TableAdapters.SolicitudesTableAdapter();
            this.códigoDeSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadAColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadBlancoYNegroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDeClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDeMaestroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDeSolicitudDataGridViewTextBoxColumn,
            this.códigoUsuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cantidadAColorDataGridViewTextBoxColumn,
            this.cantidadBlancoYNegroDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.códigoDeClaseDataGridViewTextBoxColumn,
            this.códigoDeMaestroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solicitudesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(369, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 533);
            this.dataGridView1.TabIndex = 63;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(37, 510);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 84;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(34, 553);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 83;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(204, 552);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 82;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(204, 510);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 23);
            this.btnCrear.TabIndex = 81;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtCodigoMaestro
            // 
            this.txtCodigoMaestro.Location = new System.Drawing.Point(186, 350);
            this.txtCodigoMaestro.Name = "txtCodigoMaestro";
            this.txtCodigoMaestro.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoMaestro.TabIndex = 77;
            // 
            // txtCodigoClase
            // 
            this.txtCodigoClase.Location = new System.Drawing.Point(186, 304);
            this.txtCodigoClase.Name = "txtCodigoClase";
            this.txtCodigoClase.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoClase.TabIndex = 76;
            // 
            // txtCantidadColor
            // 
            this.txtCantidadColor.Location = new System.Drawing.Point(186, 175);
            this.txtCantidadColor.Name = "txtCantidadColor";
            this.txtCantidadColor.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadColor.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 74;
            this.label8.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Codigo de Maestro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 72;
            this.label6.Text = "Código de Clase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "Fecha:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Location = new System.Drawing.Point(186, 83);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoUsuario.TabIndex = 68;
            // 
            // txtCodigoSolicitud
            // 
            this.txtCodigoSolicitud.Location = new System.Drawing.Point(186, 21);
            this.txtCodigoSolicitud.Name = "txtCodigoSolicitud";
            this.txtCodigoSolicitud.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoSolicitud.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 66;
            this.label3.Text = "Cantidad Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 65;
            this.label2.Text = "Codigo de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Codigo de Solicitud:";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(150, 129);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 85;
            // 
            // txtCantidadNegro
            // 
            this.txtCantidadNegro.Location = new System.Drawing.Point(186, 219);
            this.txtCantidadNegro.Name = "txtCantidadNegro";
            this.txtCantidadNegro.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadNegro.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Cantidad Blanco y Negro:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(186, 465);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(121, 20);
            this.txtObservaciones.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 88;
            this.label9.Text = "Aprobar/Rechazar:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Aprobar",
            "Rechazar"});
            this.cmbEstado.Location = new System.Drawing.Point(186, 423);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 91;
            this.label10.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 92;
            this.label11.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(186, 387);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(121, 20);
            this.txtEstado.TabIndex = 93;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Copias",
            "Impresiones"});
            this.cmbTipo.Location = new System.Drawing.Point(186, 259);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 107;
            // 
            // proyectoDataSet6
            // 
            this.proyectoDataSet6.DataSetName = "ProyectoDataSet6";
            this.proyectoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesBindingSource
            // 
            this.solicitudesBindingSource.DataMember = "Solicitudes";
            this.solicitudesBindingSource.DataSource = this.proyectoDataSet6;
            // 
            // solicitudesTableAdapter
            // 
            this.solicitudesTableAdapter.ClearBeforeFill = true;
            // 
            // códigoDeSolicitudDataGridViewTextBoxColumn
            // 
            this.códigoDeSolicitudDataGridViewTextBoxColumn.DataPropertyName = "Código de solicitud";
            this.códigoDeSolicitudDataGridViewTextBoxColumn.HeaderText = "Código de solicitud";
            this.códigoDeSolicitudDataGridViewTextBoxColumn.Name = "códigoDeSolicitudDataGridViewTextBoxColumn";
            // 
            // códigoUsuarioDataGridViewTextBoxColumn
            // 
            this.códigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Código usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.HeaderText = "Código usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.Name = "códigoUsuarioDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // cantidadAColorDataGridViewTextBoxColumn
            // 
            this.cantidadAColorDataGridViewTextBoxColumn.DataPropertyName = "Cantidad a color";
            this.cantidadAColorDataGridViewTextBoxColumn.HeaderText = "Cantidad a color";
            this.cantidadAColorDataGridViewTextBoxColumn.Name = "cantidadAColorDataGridViewTextBoxColumn";
            // 
            // cantidadBlancoYNegroDataGridViewTextBoxColumn
            // 
            this.cantidadBlancoYNegroDataGridViewTextBoxColumn.DataPropertyName = "Cantidad blanco y negro";
            this.cantidadBlancoYNegroDataGridViewTextBoxColumn.HeaderText = "Cantidad blanco y negro";
            this.cantidadBlancoYNegroDataGridViewTextBoxColumn.Name = "cantidadBlancoYNegroDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // códigoDeClaseDataGridViewTextBoxColumn
            // 
            this.códigoDeClaseDataGridViewTextBoxColumn.DataPropertyName = "Código de clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.HeaderText = "Código de clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.Name = "códigoDeClaseDataGridViewTextBoxColumn";
            // 
            // códigoDeMaestroDataGridViewTextBoxColumn
            // 
            this.códigoDeMaestroDataGridViewTextBoxColumn.DataPropertyName = "Código de maestro";
            this.códigoDeMaestroDataGridViewTextBoxColumn.HeaderText = "Código de maestro";
            this.códigoDeMaestroDataGridViewTextBoxColumn.Name = "códigoDeMaestroDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(194, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 108;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Solicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 613);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidadNegro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCodigoMaestro);
            this.Controls.Add(this.txtCodigoClase);
            this.Controls.Add(this.txtCantidadColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoUsuario);
            this.Controls.Add(this.txtCodigoSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Solicitudes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.Solicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtCodigoMaestro;
        private System.Windows.Forms.TextBox txtCodigoClase;
        private System.Windows.Forms.TextBox txtCantidadColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.TextBox txtCodigoSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.TextBox txtCantidadNegro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private ProyectoDataSet6 proyectoDataSet6;
        private System.Windows.Forms.BindingSource solicitudesBindingSource;
        private ProyectoDataSet6TableAdapters.SolicitudesTableAdapter solicitudesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadAColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadBlancoYNegroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeMaestroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscar;
    }
}