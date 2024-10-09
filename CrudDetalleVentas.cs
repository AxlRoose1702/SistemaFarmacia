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
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
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
            //SE ABRE LA CONEXIÓN SQL
            int cant = 0;
            conn.Open();

            //SE MODIFICA SEGUN DATOS DE LA BASE DE DATOS Y [DISEÑO]
            string QryAgregarDetalleVenta = "Insert into tbl_detalle_ventas (CodigoVenta, CodigoMedicamento, Cantidad, PrecioUnitario, Descuento, Impuesto, Total) values (@CodigoVenta, @CodigoMedicamento, @Cantidad, @PrecioUnitario, @Descuento, @Impuesto, @Total)";
            SqlCommand cmd = new SqlCommand(QryAgregarDetalleVenta, conn);
            cmd.Parameters.AddWithValue("@CodigoVenta", txtCodVenta.Text);
            cmd.Parameters.AddWithValue("@CodigoMedicamento", txtCodMedicamento.Text);
            cmd.Parameters.AddWithValue("@Cantidad", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@PrecioUnitario", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@Descuento", txtDescuento.Text);
            cmd.Parameters.AddWithValue("@Impuesto", txtImpuesto.Text);
            cmd.Parameters.AddWithValue("@Total", txtTotal.Text);         

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
}
