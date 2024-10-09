﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudUsuarios : Form
    {
        private SqlConnection conn;
        public CrudUsuarios()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {
            
            string QryConsultarUsuarios = "Select * from tbl_usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewUsuarios.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string QryAgregarUsuarios = "Insert into tbl_usuarios (Email, Usuario, Contrasena, Estado, FechaCreacion) values (@Email, @Usuario, @Contrasena, @Estado, @FechaCreacion)";
            SqlCommand cmd = new SqlCommand(QryAgregarUsuarios, conn);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Contrasena", txtPassword.Text);
            cmd.Parameters.AddWithValue("@Estado", comboEstado.Text);
            cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(date.Text));

            conn.Open();
            int cant = cmd.ExecuteNonQuery();
            

            if (cant > 0) 
            {
                MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
