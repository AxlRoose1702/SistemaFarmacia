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
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
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
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNIT.Text) || string.IsNullOrEmpty(txtProveedor.Text) || string.IsNullOrEmpty(txtTEL.Text))
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

                string QryAgregarProveedor = "Insert into tbl_proveedores (Nombre, Nit, Telefono, Email, Direccion, FechaCreacion, Estado) values (@Nombre, @Nit, @Telefono, @Email, @Direccion, @FechaCreacion, @Estado)";
                SqlCommand cmd = new SqlCommand(QryAgregarProveedor, conn);
                cmd.Parameters.AddWithValue("@Nombre", txtProveedor.Text);
                cmd.Parameters.AddWithValue("@Nit", txtNIT.Text);
                cmd.Parameters.AddWithValue("@Telefono", txtTEL.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Estado", cboxEstado.Text);
                cmd.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(dtpfecha.Text));

                conn.Open();
                int cant = cmd.ExecuteNonQuery();

                // VERIFICA SI SE AGREGARON FILAS
                if (cant > 0)
                {
                    MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                    txtProveedor.Text = "";
                    txtNIT.Text = "";
                    txtTEL.Text = "";
                    txtEmail.Text = "";
                    txtDireccion.Text = "";
                    cboxEstado.Text = "";
                    dtpfecha.Text = "";
                    lblERROR.Text = "";


                    // MODIFICAR SEGUN CRUD UTILIZADO
                    string QryConsultarProveedores = "Select * from tbl_proveedores";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarProveedores, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewProveedores.DataSource = dt;

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

            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtNIT.Text) || string.IsNullOrEmpty(txtProveedor.Text) || string.IsNullOrEmpty(txtTEL.Text))
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

                int cant = 0;
                conn.Open();

                // Captura datos formulario y actualiza en base de datos
                string QryActualizaProveedor = "Update tbl_proveedores set Nombre=@Nombre, Nit=@Nit, Email=@Email, Telefono=@Telefono, Direccion=@Direccion, Estado=@Estado, FechaCreacion=@FechaCreacion where CodigoProveedor=@CodigoProveedor";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaProveedor, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoProveedor", txtCodigoProveedor.Text);
                commandQryActualiza.Parameters.AddWithValue("@Nombre", txtProveedor.Text);
                commandQryActualiza.Parameters.AddWithValue("@Nit", txtNIT.Text);
                commandQryActualiza.Parameters.AddWithValue("@Email", txtEmail.Text);
                commandQryActualiza.Parameters.AddWithValue("@Telefono", txtTEL.Text);
                commandQryActualiza.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                commandQryActualiza.Parameters.AddWithValue("@Estado", cboxEstado.Text);
                commandQryActualiza.Parameters.AddWithValue("@FechaCreacion", DateTime.Parse(dtpfecha.Text));
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoProveedor.Text = "";
                    txtProveedor.Text = "";
                    txtNIT.Text = "";
                    txtEmail.Text = "";
                    txtTEL.Text = "";
                    txtDireccion.Text = "";
                    cboxEstado.Text = "";
                    dtpfecha.Text = "";

                    string QryConsultarProveedores = "Select * from tbl_proveedores";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarProveedores, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewProveedores.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }

        }

        private void dgviewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoProveedor.Text = dgviewProveedores.SelectedCells[0].Value.ToString();
            txtProveedor.Text = dgviewProveedores.SelectedCells[1].Value.ToString();
            txtNIT.Text = dgviewProveedores.SelectedCells[2].Value.ToString();
            txtEmail.Text = dgviewProveedores.SelectedCells[4].Value.ToString();
            txtTEL.Text = dgviewProveedores.SelectedCells[3].Value.ToString();
            txtDireccion.Text = dgviewProveedores.SelectedCells[5].Value.ToString();
            cboxEstado.Text = dgviewProveedores.SelectedCells[7].Value.ToString();
            dtpfecha.Text = dgviewProveedores.SelectedCells[6].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

                int cant = 0;
                conn.Open();

                // Captura datos formulario y elimina en base de datos
                string QryEliminaProveedores = "Delete from tbl_proveedores where CodigoProveedor=@CodigoProveedor";
                SqlCommand commandQryElimina = new SqlCommand(QryEliminaProveedores, conn);
                commandQryElimina.Parameters.AddWithValue("@CodigoProveedor", txtCodigoProveedor.Text);
                cant = commandQryElimina.ExecuteNonQuery();

                // Valida si se eliminaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Eliminado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoProveedor.Text = "";
                    txtProveedor.Text = "";
                    txtNIT.Text = "";
                    txtEmail.Text = "";
                    txtTEL.Text = "";
                    txtDireccion.Text = "";
                    cboxEstado.Text = "";
                    dtpfecha.Text = "";

                    string QryConsultarProveedores = "Select * from tbl_proveedores";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarProveedores, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgviewProveedores.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se elimino el registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión

        }
    }
}
