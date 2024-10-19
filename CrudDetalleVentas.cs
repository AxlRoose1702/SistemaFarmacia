using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudDetalleVentas : Form
    {
        private SqlConnection conn;
        public CrudDetalleVentas()
        {
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

        }

        private void CrudDetalleVentas_Load(object sender, EventArgs e)
        {
            string QryConsultarUsuarios = "Select * from tbl_detalle_ventas";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDetalleV.DataSource = dt;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodMedicamento.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtImpuesto.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios");

            }
            else
            {

                //SE ABRE LA CONEXIÓN SQL
                int cant = 0;
                conn.Open();

                //SE MODIFICA SEGUN DATOS DE LA BASE DE DATOS Y [DISEÑO]
                string QryAgregarDetalleVenta = "Insert into tbl_detalle_ventas (CodigoVenta, CodigoMedicamento, Cantidad, PrecioUnitario, Descuento, Impuesto, Total) values (@CodigoVenta, @CodigoMedicamento, @Cantidad, @PrecioUnitario, @Descuento, @Impuesto, @Total)";
                SqlCommand cmd = new SqlCommand(QryAgregarDetalleVenta, conn);
                cmd.Parameters.AddWithValue("@CodigoVenta", int.Parse(txtCodVenta.Text));
                cmd.Parameters.AddWithValue("@CodigoMedicamento", int.Parse(txtCodMedicamento.Text));
                cmd.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                cmd.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Descuento", decimal.Parse(txtDescuento.Text));
                cmd.Parameters.AddWithValue("@Impuesto", decimal.Parse(txtImpuesto.Text));
                cmd.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));

                // VERIFICA SI SE AGREGARON FILAS
                cant = cmd.ExecuteNonQuery();
                if (cant > 0)
                {
                    MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                    txtCodVenta.Text = "";
                    txtCodMedicamento.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtDescuento.Text = "";
                    txtImpuesto.Text = "";
                    txtTotal.Text = "";
                    lblERROR.Text = "";

                    // MODIFICAR SEGUN CRUD UTILIZADO
                    string QryConsultarDetalleVenta = "Select * from tbl_detalle_ventas";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarDetalleVenta, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDetalleV.DataSource = dt;

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

            if (string.IsNullOrEmpty(txtCodMedicamento.Text) || string.IsNullOrEmpty(txtCodVenta.Text) || string.IsNullOrEmpty(txtDescuento.Text) || string.IsNullOrEmpty(txtImpuesto.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios");

            }
            else
            {

                //SE ABRE LA CONEXIÓN SQL
                int cant = 0;
                conn.Open();

                // Captura datos formulario y actualiza en base de datos
                string QryActualizaDetalleVenta = "Update tbl_detalle_ventas set CodigoVenta=@CodigoVenta, CodigoMedicamento=@CodigoMedicamento, Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario, Descuento=@Descuento, Total=@Total where CodigoDetalleVenta=@CodigoDetalleVenta";
                SqlCommand commandQryActualiza = new SqlCommand(QryActualizaDetalleVenta, conn);
                commandQryActualiza.Parameters.AddWithValue("@CodigoDetalleVenta", int.Parse(txtCodigoDetalleV.Text));
                commandQryActualiza.Parameters.AddWithValue("@CodigoVenta", int.Parse(txtCodVenta.Text));
                commandQryActualiza.Parameters.AddWithValue("@CodigoMedicamento", int.Parse(txtCodMedicamento.Text));
                commandQryActualiza.Parameters.AddWithValue("@Cantidad", int.Parse(txtCantidad.Text));
                commandQryActualiza.Parameters.AddWithValue("@PrecioUnitario", decimal.Parse(txtPrecio.Text));
                commandQryActualiza.Parameters.AddWithValue("@Descuento", decimal.Parse(txtDescuento.Text));
                commandQryActualiza.Parameters.AddWithValue("@Impuesto", decimal.Parse(txtImpuesto.Text));
                commandQryActualiza.Parameters.AddWithValue("@Total", decimal.Parse(txtTotal.Text));
                cant = commandQryActualiza.ExecuteNonQuery();

                // Valida si se actualizaron datos en la base de datos
                if (cant > 0)
                {
                    MessageBox.Show("Registro Actualizado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoDetalleV.Text = "";
                    txtCodVenta.Text = "";
                    txtCodMedicamento.Text = "";
                    txtCantidad.Text = "";
                    txtPrecio.Text = "";
                    txtDescuento.Text = "";
                    txtImpuesto.Text = "";
                    txtTotal.Text = "";

                    string QryConsultarDetalleV = "Select * from tbl_detalle_ventas";
                    SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarDetalleV, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDetalleV.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No se actualizo registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close(); // Cerrar la conexión
            }

        }

        private void dgvDetalleV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoDetalleV.Text = dgvDetalleV.SelectedCells[0].Value.ToString();
            txtCodVenta.Text = dgvDetalleV.SelectedCells[1].Value.ToString();
            txtCodMedicamento.Text = dgvDetalleV.SelectedCells[2].Value.ToString();
            txtCantidad.Text = dgvDetalleV.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dgvDetalleV.SelectedCells[4].Value.ToString();
            txtDescuento.Text = dgvDetalleV.SelectedCells[5].Value.ToString();
            txtImpuesto.Text = dgvDetalleV.SelectedCells[6].Value.ToString();
            txtTotal.Text = dgvDetalleV.SelectedCells[7].Value.ToString();
            //ESTO SIRVE PARA CAPTURAR LOS DATOS DE LA BASE DE DATOS Y MANDARLOS AL FORM EDITABLE

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cant = 0;
            conn.Open();

            // Captura datos formulario y elimina en base de datos
            string QryDetalleVentas = "Delete from tbl_detalle_ventas  where CodigoDetalleVenta=@CodigoDetalleVenta";
            SqlCommand commandQryEliminar = new SqlCommand(QryDetalleVentas, conn);
            commandQryEliminar.Parameters.AddWithValue("@CodigoDetalleVenta", txtCodigoDetalleV.Text);
            cant = commandQryEliminar.ExecuteNonQuery();

            // Valida si se eliminaron datos en la base de datos
            if (cant > 0)
            {
                MessageBox.Show("Registro Eliminado!!!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoDetalleV.Text = "";
                txtCantidad.Text = "";
                txtBusqueda.Text = "";
                txtCodMedicamento.Text = "";
                txtCodVenta.Text = "";
                txtDescuento.Text = "";
                txtPrecio.Text = "";
                txtTotal.Text = "";
                txtImpuesto.Text = "";

                string QryConsultarDetalleVenta = "Select * from tbl_detalle_ventas";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarDetalleVenta, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDetalleV.DataSource = dt;

            }
            else
            {
                MessageBox.Show("No se elimino el registro!!!", "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }
    }
}
