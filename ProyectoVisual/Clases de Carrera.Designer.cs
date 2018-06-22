namespace ProyectoVisual
{
    partial class Clases_de_Carrera
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
            this.txtCodigoCarera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.códigoDeClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDeCarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasesCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet4 = new ProyectoVisual.ProyectoDataSet4();
            this.cmbClasesCarrera = new System.Windows.Forms.ComboBox();
            this.txtCodigoClase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clases_CarreraTableAdapter = new ProyectoVisual.ProyectoDataSet4TableAdapters.Clases_CarreraTableAdapter();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesCarreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoCarera
            // 
            this.txtCodigoCarera.Location = new System.Drawing.Point(151, 84);
            this.txtCodigoCarera.Name = "txtCodigoCarera";
            this.txtCodigoCarera.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoCarera.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Clases de Carrera";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(151, 208);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(151, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(151, 270);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 23);
            this.btnCrear.TabIndex = 36;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo de Carrera:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDeClaseDataGridViewTextBoxColumn,
            this.códigoDeCarreraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasesCarreraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(395, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 533);
            this.dataGridView1.TabIndex = 42;
            // 
            // códigoDeClaseDataGridViewTextBoxColumn
            // 
            this.códigoDeClaseDataGridViewTextBoxColumn.DataPropertyName = "Código de Clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.HeaderText = "Código de Clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.Name = "códigoDeClaseDataGridViewTextBoxColumn";
            // 
            // códigoDeCarreraDataGridViewTextBoxColumn
            // 
            this.códigoDeCarreraDataGridViewTextBoxColumn.DataPropertyName = "Código de Carrera";
            this.códigoDeCarreraDataGridViewTextBoxColumn.HeaderText = "Código de Carrera";
            this.códigoDeCarreraDataGridViewTextBoxColumn.Name = "códigoDeCarreraDataGridViewTextBoxColumn";
            // 
            // clasesCarreraBindingSource
            // 
            this.clasesCarreraBindingSource.DataMember = "Clases Carrera";
            this.clasesCarreraBindingSource.DataSource = this.proyectoDataSet4;
            // 
            // proyectoDataSet4
            // 
            this.proyectoDataSet4.DataSetName = "ProyectoDataSet4";
            this.proyectoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbClasesCarrera
            // 
            this.cmbClasesCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasesCarrera.FormattingEnabled = true;
            this.cmbClasesCarrera.Location = new System.Drawing.Point(151, 125);
            this.cmbClasesCarrera.Name = "cmbClasesCarrera";
            this.cmbClasesCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbClasesCarrera.TabIndex = 71;
            this.cmbClasesCarrera.Tag = "";
            this.cmbClasesCarrera.DropDown += new System.EventHandler(this.cmbClasesdeMaestro_DropDown);
            this.cmbClasesCarrera.DropDownClosed += new System.EventHandler(this.cmbClasesdeMaestro_DropDownClosed);
            // 
            // txtCodigoClase
            // 
            this.txtCodigoClase.Location = new System.Drawing.Point(151, 152);
            this.txtCodigoClase.Name = "txtCodigoClase";
            this.txtCodigoClase.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoClase.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Codigo de Clase:";
            // 
            // clases_CarreraTableAdapter
            // 
            this.clases_CarreraTableAdapter.ClearBeforeFill = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(289, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // Clases_de_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 588);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbClasesCarrera);
            this.Controls.Add(this.txtCodigoClase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigoCarera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.Name = "Clases_de_Carrera";
            this.Text = "Clases_de_Carrera";
            this.Load += new System.EventHandler(this.Clases_de_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesCarreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoCarera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbClasesCarrera;
        private System.Windows.Forms.TextBox txtCodigoClase;
        private System.Windows.Forms.Label label3;
        private ProyectoDataSet4 proyectoDataSet4;
        private System.Windows.Forms.BindingSource clasesCarreraBindingSource;
        private ProyectoDataSet4TableAdapters.Clases_CarreraTableAdapter clases_CarreraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeCarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscar;
    }
}