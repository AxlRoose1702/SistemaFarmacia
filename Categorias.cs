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
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

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

                //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                txtNombre.Text = "";
                txtDescripcion.Text = "";
                comboEstado.Text = "";
                
                // MODIFICAR SEGUN CRUD UTILIZADO
                string QryConsultarCategorias = "Select * from tbl_categorias";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarCategorias, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgviewCategoria.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se agregó registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cerrar la conexión
            conn.Close();

        }
    }
}
