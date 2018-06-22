namespace ProyectoVisual
{
    partial class Maestro
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
            this.cmbClasesdeMaestro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.proyectoDataSet2 = new ProyectoVisual.ProyectoDataSet2();
            this.clasesMaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clases_MaestroTableAdapter = new ProyectoVisual.ProyectoDataSet2TableAdapters.Clases_MaestroTableAdapter();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidadNegro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtCantidadColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoSolicitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyectoDataSet6 = new ProyectoVisual.ProyectoDataSet6();
            this.proyectoDataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet7 = new ProyectoVisual.ProyectoDataSet7();
            this.solicitudesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudesTableAdapter = new ProyectoVisual.ProyectoDataSet7TableAdapters.SolicitudesTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClasesdeMaestro
            // 
            this.cmbClasesdeMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasesdeMaestro.FormattingEnabled = true;
            this.cmbClasesdeMaestro.Location = new System.Drawing.Point(184, 82);
            this.cmbClasesdeMaestro.Name = "cmbClasesdeMaestro";
            this.cmbClasesdeMaestro.Size = new System.Drawing.Size(121, 21);
            this.cmbClasesdeMaestro.TabIndex = 66;
            this.cmbClasesdeMaestro.Tag = "";
            this.cmbClasesdeMaestro.DropDown += new System.EventHandler(this.cmbClasesdeMaestro_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 65;
            this.label3.Text = "Solicitud por clase de:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(140, 529);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(140, 489);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(140, 448);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 23);
            this.btnEnviar.TabIndex = 69;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // proyectoDataSet2
            // 
            this.proyectoDataSet2.DataSetName = "ProyectoDataSet2";
            this.proyectoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasesMaestroBindingSource
            // 
            this.clasesMaestroBindingSource.DataMember = "Clases Maestro";
            this.clasesMaestroBindingSource.DataSource = this.proyectoDataSet2;
            // 
            // clases_MaestroTableAdapter
            // 
            this.clases_MaestroTableAdapter.ClearBeforeFill = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(184, 324);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(121, 20);
            this.txtEstado.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 114;
            this.label11.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 113;
            this.label10.Text = "Observaciones:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Aprobar",
            "Rechazar"});
            this.cmbEstado.Location = new System.Drawing.Point(186, 364);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 112;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(184, 284);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(121, 20);
            this.txtObservaciones.TabIndex = 111;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "Aprobar/Rechazar:";
            // 
            // txtCantidadNegro
            // 
            this.txtCantidadNegro.Location = new System.Drawing.Point(184, 204);
            this.txtCantidadNegro.Name = "txtCantidadNegro";
            this.txtCantidadNegro.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadNegro.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 108;
            this.label5.Text = "Cantidad Blanco y Negro:";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(143, 244);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 107;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Copias",
            "Impresiones"});
            this.cmbTipo.Location = new System.Drawing.Point(184, 123);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 106;
            // 
            // txtCantidadColor
            // 
            this.txtCantidadColor.Location = new System.Drawing.Point(184, 164);
            this.txtCantidadColor.Name = "txtCantidadColor";
            this.txtCantidadColor.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadColor.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 102;
            this.label8.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Fecha:";
            // 
            // txtCodigoSolicitud
            // 
            this.txtCodigoSolicitud.Location = new System.Drawing.Point(184, 23);
            this.txtCodigoSolicitud.Name = "txtCodigoSolicitud";
            this.txtCodigoSolicitud.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoSolicitud.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cantidad Color:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 15);
            this.label12.TabIndex = 94;
            this.label12.Text = "Codigo de Solicitud:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(140, 408);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 116;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(351, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 533);
            this.dataGridView1.TabIndex = 117;
            // 
            // proyectoDataSet6
            // 
            this.proyectoDataSet6.DataSetName = "ProyectoDataSet6";
            this.proyectoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoDataSet6BindingSource
            // 
            this.proyectoDataSet6BindingSource.DataSource = this.proyectoDataSet6;
            this.proyectoDataSet6BindingSource.Position = 0;
            // 
            // proyectoDataSet7
            // 
            this.proyectoDataSet7.DataSetName = "ProyectoDataSet7";
            this.proyectoDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitudesBindingSource
            // 
            this.solicitudesBindingSource.DataMember = "Solicitudes";
            this.solicitudesBindingSource.DataSource = this.proyectoDataSet7;
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
            this.btnBuscar.Location = new System.Drawing.Point(192, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 118;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 575);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCantidadNegro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtCantidadColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoSolicitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbClasesdeMaestro);
            this.Controls.Add(this.label3);
            this.Name = "Maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Maestro_FormClosed);
            this.Load += new System.EventHandler(this.Maestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClasesdeMaestro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEnviar;
        private ProyectoDataSet2 proyectoDataSet2;
        private System.Windows.Forms.BindingSource clasesMaestroBindingSource;
        private ProyectoDataSet2TableAdapters.Clases_MaestroTableAdapter clases_MaestroTableAdapter;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidadNegro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtCantidadColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource proyectoDataSet6BindingSource;
        private ProyectoDataSet6 proyectoDataSet6;
        private ProyectoDataSet7 proyectoDataSet7;
        private System.Windows.Forms.BindingSource solicitudesBindingSource;
        private ProyectoDataSet7TableAdapters.SolicitudesTableAdapter solicitudesTableAdapter;
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