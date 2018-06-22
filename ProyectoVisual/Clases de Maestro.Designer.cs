namespace ProyectoVisual
{
    partial class Clases_de_Maestro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoClase = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.códigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.códigoDeClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasesMaestroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDataSet3 = new ProyectoVisual.ProyectoDataSet3();
            this.clasesMaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clases_MaestroTableAdapter = new ProyectoVisual.ProyectoDataSet3TableAdapters.Clases_MaestroTableAdapter();
            this.cmbClasesdeMaestro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo de Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Código de Usuario:";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.Location = new System.Drawing.Point(157, 91);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoUsuario.TabIndex = 45;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(166, 287);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 23);
            this.btnCrear.TabIndex = 46;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(166, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(166, 235);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 23);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Clases de Maestros";
            // 
            // txtCodigoClase
            // 
            this.txtCodigoClase.Location = new System.Drawing.Point(157, 170);
            this.txtCodigoClase.Name = "txtCodigoClase";
            this.txtCodigoClase.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoClase.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.códigoUsuarioDataGridViewTextBoxColumn,
            this.códigoDeClaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clasesMaestroBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(418, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 533);
            this.dataGridView1.TabIndex = 52;
            // 
            // códigoUsuarioDataGridViewTextBoxColumn
            // 
            this.códigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Código Usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.HeaderText = "Código Usuario";
            this.códigoUsuarioDataGridViewTextBoxColumn.Name = "códigoUsuarioDataGridViewTextBoxColumn";
            // 
            // códigoDeClaseDataGridViewTextBoxColumn
            // 
            this.códigoDeClaseDataGridViewTextBoxColumn.DataPropertyName = "Código de Clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.HeaderText = "Código de Clase";
            this.códigoDeClaseDataGridViewTextBoxColumn.Name = "códigoDeClaseDataGridViewTextBoxColumn";
            // 
            // clasesMaestroBindingSource1
            // 
            this.clasesMaestroBindingSource1.DataMember = "Clases Maestro";
            this.clasesMaestroBindingSource1.DataSource = this.proyectoDataSet3;
            // 
            // proyectoDataSet3
            // 
            this.proyectoDataSet3.DataSetName = "ProyectoDataSet3";
            this.proyectoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasesMaestroBindingSource
            // 
            this.clasesMaestroBindingSource.DataMember = "Clases Maestro";
            // 
            // clases_MaestroTableAdapter
            // 
            this.clases_MaestroTableAdapter.ClearBeforeFill = true;
            // 
            // cmbClasesdeMaestro
            // 
            this.cmbClasesdeMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasesdeMaestro.FormattingEnabled = true;
            this.cmbClasesdeMaestro.Location = new System.Drawing.Point(157, 143);
            this.cmbClasesdeMaestro.Name = "cmbClasesdeMaestro";
            this.cmbClasesdeMaestro.Size = new System.Drawing.Size(121, 21);
            this.cmbClasesdeMaestro.TabIndex = 67;
            this.cmbClasesdeMaestro.Tag = "";
            this.cmbClasesdeMaestro.DropDown += new System.EventHandler(this.cmbClasesdeMaestro_DropDown_1);
            this.cmbClasesdeMaestro.DropDownClosed += new System.EventHandler(this.cmbClasesdeMaestro_DropDownClosed_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(294, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Clases_de_Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 546);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbClasesdeMaestro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigoClase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtCodigoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clases_de_Maestro";
            this.Text = "Clases_de_Maestro";
            this.Load += new System.EventHandler(this.Clases_de_Maestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasesMaestroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoClase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clasesMaestroBindingSource;
        private ProyectoDataSet3 proyectoDataSet3;
        private System.Windows.Forms.BindingSource clasesMaestroBindingSource1;
        private ProyectoDataSet3TableAdapters.Clases_MaestroTableAdapter clases_MaestroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn códigoDeClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbClasesdeMaestro;
        private System.Windows.Forms.Button btnBuscar;
    }
}