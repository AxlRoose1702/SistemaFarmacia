using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudClientes : Form
    {
        private SqlConnection conn;
        public CrudClientes()
        {
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

            }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CrudClientes_Load(object sender, EventArgs e)
        {
            string QryConsultarClientes = "Select * from tbl_clientes";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarClientes, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewClientes.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoCliente.Text) || string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNIT.Text) || string.IsNullOrEmpty(txtTEL.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            }
            else if (cboxEstado.Text != "ACTIVO" && cboxEstado.Text != "INACTIVO")
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
                string QryAgregarClientes = "Insert into tbl_clientes (Nombre, Nit, Telefono, Direccion, FechaCreacion, Estado) values (@Nombre, @Nit, @Telefono, @Direccion, @FechaCreacion, @Estado)";
                SqlCommand cmd = new SqlCommand(QryAgregarClientes, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtCliente.Text);
                cmd.Parameters.AddWithValue("@Nit", txtNIT.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTEL.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(dateFecha.Text));
                cmd.Parameters.AddWithValue("@Estado", cboxEstado.Text);


                // VERIFICA SI SE AGREGARON FILAS
                cant = cmd.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                    txtCliente.Text = "";
                    txtNIT.Text = "";
                    txtTEL.Text = "";
                    txtDireccion.Text = "";
                    dateFecha.Text = "";
                    cboxEstado.Text = "";
                    lblERROR.Text = "";

                    // MODIFICAR SEGUN CRUD UTILIZADO
                    string QryConsultarClientes = "Select * from tbl_clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarClientes, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewClientes.DataSource = dt;

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

            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNIT.Text) || string.IsNullOrEmpty(txtTEL.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            }
            else if (cboxEstado.Text != "ACTIVO" && cboxEstado.Text != "INACTIVO")
            {

                //Dato no seleccionado
                MessageBox.Show("Hay datos sin seleccionar en el formulario");
            }
            else
            {

                //SE ABRE LA CONEXIÓN SQL
                int cant = 0;
                conn.Open();

                // Captura datos formulario y actualiza en base de datos
                string QryActualizaClientes = "Update tbl_clientes set Nombre=@Cliente, Nit=@Nit, Telefono=@Telefono, Direccion=@Direccion, Estado=@Estado, FechaCreacion=@FechaCreacion where CodigoCliente=@CodigoCliente";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaClientes, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoCliente", txtCodigoCliente.Text);
                commandQryActualiza.Parameters.AddWithValue("@Cliente", txtCliente.Text);
                commandQryActualiza.Parameters.AddWithValue("@Nit", txtNIT.Text);
                commandQryActualiza.Parameters.AddWithValue("@Telefono", txtTEL.Text);
                commandQryActualiza.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                commandQryActualiza.Parameters.AddWithValue("@Estado", cboxEstado.Text);
                commandQryActualiza.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(dateFecha.Text));
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoCliente.Text = "";
                    txtCliente.Text = "";
                    txtNIT.Text = "";
                    txtTEL.Text = "";
                    txtDireccion.Text = "";
                    cboxEstado.Text = "";
                    dateFecha.Text = "";

                    string QryConsultarClientes = "Select * from tbl_clientes";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarClientes, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewClientes.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }
        }

        private void dgviewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoCliente.Text = dgviewClientes.SelectedCells[0].Value.ToString();
            txtCliente.Text = dgviewClientes.SelectedCells[1].Value.ToString();
            txtNIT.Text = dgviewClientes.SelectedCells[2].Value.ToString();
            txtTEL.Text = dgviewClientes.SelectedCells[3].Value.ToString();
            txtDireccion.Text = dgviewClientes.SelectedCells[4].Value.ToString();
            cboxEstado.Text = dgviewClientes.SelectedCells[6].Value.ToString();
            dateFecha.Text = dgviewClientes.SelectedCells[5].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cant = 0;
            conn.Open();

            // Captura datos formulario y elimina en base de datos
            string QryEliminaClientes = "Delete from tbl_clientes  where CodigoCliente=@CodigoCliente";
            SqlCommand commandQryElimina = new SqlCommand(QryEliminaClientes, conn);
            commandQryElimina.Parameters.AddWithValue("@CodigoCliente", txtCodigoCliente.Text);
            cant = commandQryElimina.ExecuteNonQuery();

            // Valida si se eliminaron datos en la base de datos
            if (cant > 0)
            {
                MessageBox.Show("Registro Eliminado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoCliente.Text = "";
                txtCliente.Text = "";
                txtBusqueda.Text = "";
                txtDireccion.Text = "";
                txtTEL.Text = "";
                txtNIT.Text = "";
                cboxEstado.Text = "";

                string QryConsultarClientes = "Select * from tbl_clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarClientes, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgviewClientes.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se elimino el registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
    }
}
