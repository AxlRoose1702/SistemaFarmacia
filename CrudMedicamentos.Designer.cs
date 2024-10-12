namespace SistemaFarmacia
{
    partial class CrudMedicamentos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodCategorias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboMEDIDA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.lblERROR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCodProveedor);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCodCategorias);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateIngreso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboMEDIDA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateVencimiento);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 623);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "Código de proveedor";
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProveedor.Location = new System.Drawing.Point(15, 446);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(280, 22);
            this.txtCodProveedor.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(289, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Codigo de Categorías";
            // 
            // txtCodCategorias
            // 
            this.txtCodCategorias.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCategorias.Location = new System.Drawing.Point(11, 386);
            this.txtCodCategorias.Name = "txtCodCategorias";
            this.txtCodCategorias.Size = new System.Drawing.Size(280, 22);
            this.txtCodCategorias.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fecha Ingreso";
            // 
            // dateIngreso
            // 
            this.dateIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIngreso.Location = new System.Drawing.Point(0, 520);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(286, 22);
            this.dateIngreso.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stock";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Window;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Location = new System.Drawing.Point(14, 314);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(280, 22);
            this.txtStock.TabIndex = 23;
            this.txtStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha Vencimiento";
            // 
            // comboMEDIDA
            // 
            this.comboMEDIDA.FormattingEnabled = true;
            this.comboMEDIDA.Items.AddRange(new object[] {
            "tabletas",
            "capsulas"});
            this.comboMEDIDA.Location = new System.Drawing.Point(6, 186);
            this.comboMEDIDA.Name = "comboMEDIDA";
            this.comboMEDIDA.Size = new System.Drawing.Size(286, 24);
            this.comboMEDIDA.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Location = new System.Drawing.Point(10, 254);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(280, 22);
            this.txtPrecio.TabIndex = 18;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtCodigoU_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Unidad de Medida";
            // 
            // dateVencimiento
            // 
            this.dateVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVencimiento.Location = new System.Drawing.Point(6, 580);
            this.dateVencimiento.Name = "dateVencimiento";
            this.dateVencimiento.Size = new System.Drawing.Size(286, 22);
            this.dateVencimiento.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(12, 126);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 22);
            this.txtDescripcion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 60);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 22);
            this.txtCodigo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código Medicamento";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(798, 563);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 34);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(678, 563);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 34);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(558, 563);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 34);
            this.btnGuardar.TabIndex = 52;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1047, 563);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 34);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(922, 103);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 34);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(1055, 111);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(280, 22);
            this.txtBusqueda.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 48;
            this.label1.Text = "DATOS MEDICAMENTOS";
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(558, 154);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.RowHeadersWidth = 51;
            this.dgvMedicamentos.RowTemplate.Height = 24;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(777, 391);
            this.dgvMedicamentos.TabIndex = 47;
            this.dgvMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellContentClick);
            // 
            // lblERROR
            // 
            this.lblERROR.AutoSize = true;
            this.lblERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblERROR.ForeColor = System.Drawing.Color.Red;
            this.lblERROR.Location = new System.Drawing.Point(1071, 20);
            this.lblERROR.Name = "lblERROR";
            this.lblERROR.Size = new System.Drawing.Size(0, 32);
            this.lblERROR.TabIndex = 56;
            // 
            // CrudMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 663);
            this.Controls.Add(this.lblERROR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicamentos);
            this.Name = "CrudMedicamentos";
            this.Text = "CrudMedicamentos";
            this.Load += new System.EventHandler(this.CrudMedicamentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboMEDIDA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateVencimiento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateIngreso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodCategorias;
        private System.Windows.Forms.Label lblERROR;
    }
}