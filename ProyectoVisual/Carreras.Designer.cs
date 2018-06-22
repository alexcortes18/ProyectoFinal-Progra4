namespace ProyectoVisual
{
    partial class Carreras
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
            this.códigoDeCarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeCarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeClasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeMaestrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet1 = new ProyectoVisual.ProyectoDataSet1();
            this.carrerasTableAdapter = new ProyectoVisual.ProyectoDataSet1TableAdapters.CarrerasTableAdapter();
            this.txtCantidadMaestros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadClases = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoCarrera = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoDeCarreraDataGridViewTextBoxColumn,
            this.nombreDeCarreraDataGridViewTextBoxColumn,
            this.cantidadDeClasesDataGridViewTextBoxColumn,
            this.cantidadDeMaestrosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carrerasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(374, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 519);
            this.dataGridView1.TabIndex = 0;
            // 
            // códigoDeCarreraDataGridViewTextBoxColumn
            // 
            this.códigoDeCarreraDataGridViewTextBoxColumn.DataPropertyName = "Código de carrera";
            this.códigoDeCarreraDataGridViewTextBoxColumn.HeaderText = "Código de carrera";
            this.códigoDeCarreraDataGridViewTextBoxColumn.Name = "códigoDeCarreraDataGridViewTextBoxColumn";
            // 
            // nombreDeCarreraDataGridViewTextBoxColumn
            // 
            this.nombreDeCarreraDataGridViewTextBoxColumn.DataPropertyName = "Nombre de carrera";
            this.nombreDeCarreraDataGridViewTextBoxColumn.HeaderText = "Nombre de carrera";
            this.nombreDeCarreraDataGridViewTextBoxColumn.Name = "nombreDeCarreraDataGridViewTextBoxColumn";
            // 
            // cantidadDeClasesDataGridViewTextBoxColumn
            // 
            this.cantidadDeClasesDataGridViewTextBoxColumn.DataPropertyName = "Cantidad de clases";
            this.cantidadDeClasesDataGridViewTextBoxColumn.HeaderText = "Cantidad de clases";
            this.cantidadDeClasesDataGridViewTextBoxColumn.Name = "cantidadDeClasesDataGridViewTextBoxColumn";
            // 
            // cantidadDeMaestrosDataGridViewTextBoxColumn
            // 
            this.cantidadDeMaestrosDataGridViewTextBoxColumn.DataPropertyName = "Cantidad de Maestros";
            this.cantidadDeMaestrosDataGridViewTextBoxColumn.HeaderText = "Cantidad de Maestros";
            this.cantidadDeMaestrosDataGridViewTextBoxColumn.Name = "cantidadDeMaestrosDataGridViewTextBoxColumn";
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "Carreras";
            this.carrerasBindingSource.DataSource = this.proyectoDataSet1;
            // 
            // proyectoDataSet1
            // 
            this.proyectoDataSet1.DataSetName = "ProyectoDataSet1";
            this.proyectoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // txtCantidadMaestros
            // 
            this.txtCantidadMaestros.Location = new System.Drawing.Point(186, 202);
            this.txtCantidadMaestros.Name = "txtCantidadMaestros";
            this.txtCantidadMaestros.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadMaestros.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cantidad de Clases:";
            // 
            // txtCantidadClases
            // 
            this.txtCantidadClases.Location = new System.Drawing.Point(186, 156);
            this.txtCantidadClases.Name = "txtCantidadClases";
            this.txtCantidadClases.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadClases.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(186, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad de Maestros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(125, 269);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 26;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(125, 455);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(125, 393);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(125, 331);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 23);
            this.btnCrear.TabIndex = 23;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Carrera";
            // 
            // txtCodigoCarrera
            // 
            this.txtCodigoCarrera.Location = new System.Drawing.Point(186, 63);
            this.txtCodigoCarrera.Name = "txtCodigoCarrera";
            this.txtCodigoCarrera.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoCarrera.TabIndex = 28;
            // 
            // Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 615);
            this.Controls.Add(this.txtCodigoCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCantidadMaestros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadClases);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Carreras";
            this.Text = "Carreras";
            this.Load += new System.EventHandler(this.Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProyectoDataSet1 proyectoDataSet1;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private ProyectoDataSet1TableAdapters.CarrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeCarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeCarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeClasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeMaestrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCantidadMaestros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadClases;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoCarrera;
    }
}