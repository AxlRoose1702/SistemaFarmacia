namespace SistemaFarmacia
{
    partial class CrudUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgviewUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblERROR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgviewUsuarios
            // 
            this.dgviewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgviewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewUsuarios.Location = new System.Drawing.Point(548, 153);
            this.dgviewUsuarios.Name = "dgviewUsuarios";
            this.dgviewUsuarios.ReadOnly = true;
            this.dgviewUsuarios.RowHeadersWidth = 51;
            this.dgviewUsuarios.RowTemplate.Height = 24;
            this.dgviewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewUsuarios.Size = new System.Drawing.Size(766, 391);
            this.dgviewUsuarios.TabIndex = 0;
            this.dgviewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewUsuarios_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATOS USUARIOS";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(6, 580);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(286, 22);
            this.date.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboEstado);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigoUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 623);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 520);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "Estado";
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboEstado.Location = new System.Drawing.Point(6, 471);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(286, 24);
            this.comboEstado.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(12, 377);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(12, 260);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = true;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Location = new System.Drawing.Point(12, 164);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(280, 22);
            this.txtUsuario.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Usuario";
            // 
            // txtCodigoUsuario
            // 
            this.txtCodigoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoUsuario.Location = new System.Drawing.Point(12, 72);
            this.txtCodigoUsuario.Name = "txtCodigoUsuario";
            this.txtCodigoUsuario.Size = new System.Drawing.Size(280, 22);
            this.txtCodigoUsuario.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo de usuario";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(921, 110);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(280, 22);
            this.txtBusqueda.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(788, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1037, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 34);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(548, 562);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 34);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(668, 562);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 34);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(788, 562);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 34);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblERROR
            // 
            this.lblERROR.AutoSize = true;
            this.lblERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblERROR.ForeColor = System.Drawing.Color.Red;
            this.lblERROR.Location = new System.Drawing.Point(1170, 562);
            this.lblERROR.Name = "lblERROR";
            this.lblERROR.Size = new System.Drawing.Size(0, 32);
            this.lblERROR.TabIndex = 29;
            // 
            // CrudUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 664);
            this.Controls.Add(this.lblERROR);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgviewUsuarios);
            this.Name = "CrudUsuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrudUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgviewUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblERROR;
    }
}

