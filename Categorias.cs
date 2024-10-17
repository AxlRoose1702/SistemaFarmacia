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
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

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
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtNombre.Text))
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
                    lblERROR.Text = "";

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtNombre.Text))
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
                string QryActualizaCategoria = "Update tbl_categorias set Nombre=@Nombre, Descripcion=@Descripcion, Estado=@Estado where CodigoCategoria=@CodigoCategoria";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaCategoria, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoCategoria", txtCodigoCategoria.Text);
                commandQryActualiza.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                commandQryActualiza.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                commandQryActualiza.Parameters.AddWithValue("@Estado", comboEstado.Text);
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    comboEstado.Text = "";

                    string QryConsultarCategoria = "Select * from tbl_categorias";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarCategoria, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewCategoria.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }

        }

        private void dgviewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCategoria.Text = dgviewCategoria.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgviewCategoria.SelectedCells[0].Value.ToString();
            txtDescripcion.Text = dgviewCategoria.SelectedCells[0].Value.ToString();
            comboEstado.Text = dgviewCategoria.SelectedCells[0].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE

        }
    }
}
