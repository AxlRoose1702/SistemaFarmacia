using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class Categorias : Form
    {
        private SqlConnection conn;
        public Categorias()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            string QryConsultarCategorias = "Select * from tbl_categorias";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarCategorias, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewCategoria.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string QryAgregarCategoria = "Insert into tbl_categorias (Nombre, Descripcion, Estado) values (@Nombre, @Descripcion, @Estado)";
            SqlCommand cmd = new SqlCommand(QryAgregarCategoria, conn);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@Estado", comboEstado.Text);

            conn.Open();
            int cant = cmd.ExecuteNonQuery();

            if (cant > 0)
            {
                MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
