using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudProveedores : Form
    {
        private SqlConnection conn;
        public CrudProveedores()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");
        }

        private void CrudProveedores_Load(object sender, EventArgs e)
        {
            string QryConsultarProveedores = "Select * from tbl_proveedores";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarProveedores, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewProveedores.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string QryAgregarUsuarios = "Insert into tbl_proveedores (Nombre, Nit, Telefono, Email, Direccion, FechaCreacion, Estado) values (@Nombre, @Nit, @Telefono, @Email, @Direccion, @FechaCreacion, @Estado)";
            SqlCommand cmd = new SqlCommand(QryAgregarUsuarios, conn);
            cmd.Parameters.AddWithValue("@Nombre", txtProveedor.Text);
            cmd.Parameters.AddWithValue("@Nit", txtNIT.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTEL.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@Estado", cboxEstado.Text);
            cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(dtpfecha.Text));

            conn.Open();
            int cant = cmd.ExecuteNonQuery();


            if (cant > 0)
            {
                MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
