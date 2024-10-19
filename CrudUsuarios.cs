using System;
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
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            }
            else if (comboEstado.Text != "ACTIVO" && comboEstado.Text != "INACTIVO")
            {

                //Dato no seleccionado
                MessageBox.Show("Hay datos sin seleccionar en el formulario");
            }
            else
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

                    //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                    txtEmail.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    comboEstado.Text = "";

                    // MODIFICAR SEGUN CRUD UTILIZADO
                    string QryConsultarUsuarios = "Select * from tbl_usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewUsuarios.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se agregó registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Cerrar la conexión
                conn.Close();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            }
            else if (comboEstado.Text != "ACTIVO" && comboEstado.Text != "INACTIVO")
            {

                //Dato no seleccionado
                MessageBox.Show("Hay datos sin seleccionar en el formulario");
            }
            else
            {

                int cant = 0;
                conn.Open();

                // Captura datos formulario y actualiza en base de datos
                string QryActualizaUsuario = "Update tbl_usuarios set Usuario=@Usuario, Contrasena=@Contrasena, Email=@Email, Estado=@Estado, FechaCreacion=@FechaCreacion where CodigoUsuario=@CodigoUsuario";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaUsuario, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoUsuario", txtCodigoUsuario.Text);
                commandQryActualiza.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                commandQryActualiza.Parameters.AddWithValue("@Contrasena", txtPassword.Text);
                commandQryActualiza.Parameters.AddWithValue("@Email", txtEmail.Text);
                commandQryActualiza.Parameters.AddWithValue("@Estado", comboEstado.Text);
                commandQryActualiza.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(date.Text));
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoUsuario.Text = "";
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Text = "";
                    comboEstado.Text = "";
                    date.Text = "";

                    string QryConsultarMedicamentos = "Select * from tbl_usuarios";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewUsuarios.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }

        }

        private void dgviewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoUsuario.Text = dgviewUsuarios.SelectedCells[0].Value.ToString();
            txtUsuario.Text = dgviewUsuarios.SelectedCells[2].Value.ToString();
            txtPassword.Text = dgviewUsuarios.SelectedCells[3].Value.ToString();
            txtEmail.Text = dgviewUsuarios.SelectedCells[1].Value.ToString();
            comboEstado.Text = dgviewUsuarios.SelectedCells[4].Value.ToString();
            date.Text = dgviewUsuarios.SelectedCells[5].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cant = 0;
            conn.Open();

            // Captura datos formulario y elimina en base de datos
            string QryEliminaUsuarios = "Delete from tbl_usuarios where CodigoUsuario=@CodigoUsuario";
            SqlCommand commandQryElimina = new SqlCommand(QryEliminaUsuarios, conn);
            commandQryElimina.Parameters.AddWithValue("@CodigoUsuario", txtCodigoUsuario.Text);
            cant = commandQryElimina.ExecuteNonQuery();

            // Valida si se eliminaron datos en la base de datos
            if (cant > 0)
            {
                MessageBox.Show("Registro Eliminado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoUsuario.Text = "";
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                date.Text = "";
                comboEstado.Text = "";

                string QryConsultarUsuarios = "Select * from tbl_usuarios";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgviewUsuarios.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se elimino el registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
    }
}
