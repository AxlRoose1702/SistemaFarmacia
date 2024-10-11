using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudMedicamentos : Form
    {

        private SqlConnection conn;

        public CrudMedicamentos()
        {
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoU_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrudMedicamentos_Load(object sender, EventArgs e)
        {
           // ESTO SE MODIFICA A CADA CRUD
            string QryConsultarMedicamentos = "Select * from tbl_medicamentos";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvMedicamentos.DataSource = dt;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCategorias.Text) || string.IsNullOrEmpty(txtCodProveedor.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            }
            else if (comboMEDIDA.Text != "capsulas" && comboMEDIDA.Text != "tabletas")
            {

                //Dato no seleccionado
                MessageBox.Show("Hay datos sin seleccionar en el formulario");
            }
            else
            {

                //SE ABRE LA CONEXIÓN SQL
                int cant = 0;
                conn.Open();

                //SE MODIFICA SEGUN DATOS DE LA BASE DE DATOS Y [DISEÑO]
                string QryAgregarMedicamento = "Insert into tbl_medicamentos (Descripcion, UnidadMedida, Precio, Stock, FechaIngreso, FechaVencimiento, CodigoCategoria, CodigoProveedor) values (@Descripcion, @UnidadMedida, @Precio, @Stock, @FechaIngreso, @FechaVencimiento, @CodigoCategoria, @CodigoProveedor)";
                SqlCommand cmd = new SqlCommand(QryAgregarMedicamento, conn);
                cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@UnidadMedida", comboMEDIDA.Text);
                cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                cmd.Parameters.AddWithValue("@Stock", txtStock.Text);
                cmd.Parameters.AddWithValue("@FechaIngreso", DateTime.Parse(dateIngreso.Text));
                cmd.Parameters.AddWithValue("@FechaVencimiento", DateTime.Parse(dateVencimiento.Text));
                cmd.Parameters.AddWithValue("@CodigoCategoria", txtCodCategorias.Text);
                cmd.Parameters.AddWithValue("@CodigoProveedor", txtCodProveedor.Text);


                // VERIFICA SI SE AGREGARON FILAS
                cant = cmd.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                    txtDescripcion.Text = "";
                    comboMEDIDA.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    dateIngreso.Text = "";
                    dateVencimiento.Text = "";
                    txtCodCategorias.Text = "";
                    txtCodProveedor.Text = "";
                    lblERROR.Text = "";

                    // MODIFICAR SEGUN CRUD UTILIZADO
                    string QryConsultarMedicamentos = "Select * from tbl_medicamentos";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMedicamentos.DataSource = dt;

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
}
