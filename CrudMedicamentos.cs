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
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
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
        
        private void btnEditar_Click(object sender, EventArgs e)
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

                int cant = 0;
                conn.Open();

                // Captura datos formulario y actualiza en base de datos
                string QryActualizaMedicamentos = "Update tbl_medicamentos set Descripcion=@Descripcion, UnidadMedida=@UnidadMedida, Precio=@Precio, Stock=@Stock, FechaIngreso=@FechaIngreso, FechaVencimiento=@FechaVencimiento, CodigoCategoria=@CodigoCategoria, CodigoProveedor=@CodigoProveedor where CodigoMedicamento=@CodigoMedicamento";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaMedicamentos, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoMedicamento", txtCodigo.Text);
                commandQryActualiza.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                commandQryActualiza.Parameters.AddWithValue("@UnidadMedida", comboMEDIDA.Text);
                commandQryActualiza.Parameters.AddWithValue("@Precio", double.Parse(txtPrecio.Text));
                commandQryActualiza.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));
                commandQryActualiza.Parameters.AddWithValue("@FechaIngreso", DateTime.Parse(dateIngreso.Text));
                commandQryActualiza.Parameters.AddWithValue("@FechaVencimiento", DateTime.Parse(dateVencimiento.Text));
                commandQryActualiza.Parameters.AddWithValue("@CodigoCategoria", txtCodCategorias.Text);
                commandQryActualiza.Parameters.AddWithValue("@CodigoProveedor", txtCodProveedor.Text);
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigo.Text = "";
                    txtDescripcion.Text = "";
                    comboMEDIDA.Text = "";
                    txtPrecio.Text = "";
                    txtStock.Text = "";
                    txtCodCategorias.Text = "";
                    txtCodProveedor.Text = "";

                    string QryConsultarMedicamentos = "Select * from tbl_medicamentos";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMedicamentos.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }

        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvMedicamentos.SelectedCells[0].Value.ToString();
            txtDescripcion.Text = dgvMedicamentos.SelectedCells[1].Value.ToString();
            comboMEDIDA.Text = dgvMedicamentos.SelectedCells[2].Value.ToString();
            txtPrecio.Text = dgvMedicamentos.SelectedCells[3].Value.ToString();
            txtStock.Text = dgvMedicamentos.SelectedCells[4].Value.ToString();
            txtCodCategorias.Text = dgvMedicamentos.SelectedCells[7].Value.ToString();
            txtCodProveedor.Text = dgvMedicamentos.SelectedCells[8].Value.ToString();
            dateIngreso.Text= dgvMedicamentos.SelectedCells[5].Value.ToString();
            dateVencimiento.Text = dgvMedicamentos.SelectedCells[6].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cant = 0;
            conn.Open();

            // Captura datos formulario y elimina en base de datos
            string QryMedicamentos = "Delete from tbl_medicamentos  where CodigoMedicamento=@CodigoMedicamento";
            SqlCommand commandQryEliminar = new SqlCommand(QryMedicamentos, conn);
            commandQryEliminar.Parameters.AddWithValue("@CodigoMedicamento", txtCodigo.Text);
            cant = commandQryEliminar.ExecuteNonQuery();

            // Valida si se eliminaron datos en la base de datos
            if (cant > 0)
            {
                MessageBox.Show("Registro Eliminado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                comboMEDIDA.Text = "";
                txtPrecio.Text = "";
                txtStock.Text = "";
                txtCodCategorias.Text = "";
                txtCodProveedor.Text = "";

                string QryConsultarMedicamentos = "Select * from tbl_medicamentos";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMedicamentos.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se elimino el registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
    }
}
