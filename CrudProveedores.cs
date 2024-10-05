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
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
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
    }
}
