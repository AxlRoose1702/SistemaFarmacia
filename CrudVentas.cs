using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudVentas : Form
    {
        private SqlConnection conn;
        public CrudVentas()
        {
            // CONEXIONES A BASE DE DATOS (3 VERSIONES)
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");
            comboPAGO.Text = "Seleccionar";
        }

        private void CrudVentas_Load(object sender, EventArgs e)
        {
            string QryConsultarUsuarios = "Select * from tbl_ventas";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvVentas.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCodigoC.Text) || string.IsNullOrEmpty(txtCodigoU.Text))
            {
                //Datos vacios
                MessageBox.Show("Hay datos vacios en el formulario");

            } else if (comboPAGO.Text != "Efectivo" && comboPAGO.Text != "Transferencia" && comboPAGO.Text != "Tarjeta") {

                //Dato no seleccionado
                MessageBox.Show("Hay datos sin seleccionar en el formulario");
            }
            else
            { 

            //SE ABRE LA CONEXIÓN SQL
            int cant = 0;
            conn.Open();

            //SE MODIFICA SEGUN DATOS DE LA BASE DE DATOS Y [DISEÑO]
            string QryAgregarVentas = "Insert into tbl_ventas (FechaVenta, CodigoCliente, CodigoUsuario, TipoPago) values (@FechaVenta, @CodigoCliente, @CodigoUsuario, @TipoPago)";
            SqlCommand cmd = new SqlCommand(QryAgregarVentas, conn);
            cmd.Parameters.AddWithValue("@FechaVenta", DateTime.Parse(dateFecha.Text));
            cmd.Parameters.AddWithValue("@CodigoCliente", txtCodigoC.Text);
            cmd.Parameters.AddWithValue("@CodigoUsuario", txtCodigoU.Text);
            cmd.Parameters.AddWithValue("@TipoPago", comboPAGO.Text);


            // VERIFICA SI SE AGREGARON FILAS
            cant = cmd.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Se ha insertado los datos correctamente", "¡Datos Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //DEJAMOS EN BLANCO TODAS LAS CASILLAS
                dateFecha.Text = "";
                txtCodigoC.Text = "";
                txtCodigoU.Text = "";
                comboPAGO.Text = "";

                // MODIFICAR SEGUN CRUD UTILIZADO
                string QryConsultarMedicamentos = "Select * from tbl_ventas";
                SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarMedicamentos, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvVentas.DataSource = dt;

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
