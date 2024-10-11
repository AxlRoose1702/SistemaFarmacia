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
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

            }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgviewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
