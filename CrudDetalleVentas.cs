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
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
        }

        private void CrudDetalleVentas_Load(object sender, EventArgs e)
        {
            string QryConsultarUsuarios = "Select * from tbl_detalle_ventas";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewDetalleVenta.DataSource = dt;

        }
    }
}
