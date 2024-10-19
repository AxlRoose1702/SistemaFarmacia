namespace SistemaFarmacia
{
    partial class MenuNavegacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMenuMedicamentos = new System.Windows.Forms.Button();
            this.btnMenuVentas = new System.Windows.Forms.Button();
            this.btnMenuDetalleV = new System.Windows.Forms.Button();
            this.btnMenuCategorias = new System.Windows.Forms.Button();
            this.btnMenuProveedores = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnMenuUsuarios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU DE NAVEGACION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuMedicamentos);
            this.groupBox1.Controls.Add(this.btnMenuVentas);
            this.groupBox1.Controls.Add(this.btnMenuDetalleV);
            this.groupBox1.Controls.Add(this.btnMenuCategorias);
            this.groupBox1.Controls.Add(this.btnMenuProveedores);
            this.groupBox1.Controls.Add(this.btnMenuClientes);
            this.groupBox1.Controls.Add(this.btnMenuUsuarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 403);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMenuMedicamentos
            // 
            this.btnMenuMedicamentos.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuMedicamentos.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuMedicamentos.Location = new System.Drawing.Point(406, 185);
            this.btnMenuMedicamentos.Name = "btnMenuMedicamentos";
            this.btnMenuMedicamentos.Size = new System.Drawing.Size(151, 79);
            this.btnMenuMedicamentos.TabIndex = 7;
            this.btnMenuMedicamentos.Text = "Menu Medicamentos";
            this.btnMenuMedicamentos.UseVisualStyleBackColor = false;
            this.btnMenuMedicamentos.Click += new System.EventHandler(this.btnMenuMedicamentos_Click);
            // 
            // btnMenuVentas
            // 
            this.btnMenuVentas.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuVentas.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuVentas.Location = new System.Drawing.Point(266, 185);
            this.btnMenuVentas.Name = "btnMenuVentas";
            this.btnMenuVentas.Size = new System.Drawing.Size(134, 79);
            this.btnMenuVentas.TabIndex = 6;
            this.btnMenuVentas.Text = "Menu Ventas";
            this.btnMenuVentas.UseVisualStyleBackColor = false;
            this.btnMenuVentas.Click += new System.EventHandler(this.btnMenuVentas_Click);
            // 
            // btnMenuDetalleV
            // 
            this.btnMenuDetalleV.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuDetalleV.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDetalleV.Location = new System.Drawing.Point(126, 185);
            this.btnMenuDetalleV.Name = "btnMenuDetalleV";
            this.btnMenuDetalleV.Size = new System.Drawing.Size(134, 79);
            this.btnMenuDetalleV.TabIndex = 5;
            this.btnMenuDetalleV.Text = "Menu Detalle Ventas";
            this.btnMenuDetalleV.UseVisualStyleBackColor = false;
            this.btnMenuDetalleV.Click += new System.EventHandler(this.btnMenuDetalleV_Click);
            // 
            // btnMenuCategorias
            // 
            this.btnMenuCategorias.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuCategorias.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCategorias.Location = new System.Drawing.Point(472, 112);
            this.btnMenuCategorias.Name = "btnMenuCategorias";
            this.btnMenuCategorias.Size = new System.Drawing.Size(133, 67);
            this.btnMenuCategorias.TabIndex = 4;
            this.btnMenuCategorias.Text = "Menu Categorias";
            this.btnMenuCategorias.UseVisualStyleBackColor = false;
            this.btnMenuCategorias.Click += new System.EventHandler(this.btnMenuCategorias_Click);
            // 
            // btnMenuProveedores
            // 
            this.btnMenuProveedores.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuProveedores.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuProveedores.Location = new System.Drawing.Point(333, 112);
            this.btnMenuProveedores.Name = "btnMenuProveedores";
            this.btnMenuProveedores.Size = new System.Drawing.Size(133, 67);
            this.btnMenuProveedores.TabIndex = 3;
            this.btnMenuProveedores.Text = "Menu Proveedores";
            this.btnMenuProveedores.UseVisualStyleBackColor = false;
            this.btnMenuProveedores.Click += new System.EventHandler(this.btnMenuProveedores_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuClientes.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClientes.Location = new System.Drawing.Point(197, 112);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Size = new System.Drawing.Size(130, 67);
            this.btnMenuClientes.TabIndex = 2;
            this.btnMenuClientes.Text = "Menu Clientes";
            this.btnMenuClientes.UseVisualStyleBackColor = false;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // btnMenuUsuarios
            // 
            this.btnMenuUsuarios.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuarios.Location = new System.Drawing.Point(61, 112);
            this.btnMenuUsuarios.Name = "btnMenuUsuarios";
            this.btnMenuUsuarios.Size = new System.Drawing.Size(130, 67);
            this.btnMenuUsuarios.TabIndex = 1;
            this.btnMenuUsuarios.Text = "Menu Usuarios";
            this.btnMenuUsuarios.UseVisualStyleBackColor = false;
            this.btnMenuUsuarios.Click += new System.EventHandler(this.btnMenuUsuarios_Click);
            // 
            // MenuNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuNavegacion";
            this.Text = "MenuNavegacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuMedicamentos;
        private System.Windows.Forms.Button btnMenuVentas;
        private System.Windows.Forms.Button btnMenuDetalleV;
        private System.Windows.Forms.Button btnMenuCategorias;
        private System.Windows.Forms.Button btnMenuProveedores;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnMenuUsuarios;
    }
}