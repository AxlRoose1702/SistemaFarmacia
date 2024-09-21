using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudUsuarios : Form
    {
        private SqlConnection conn;
        public CrudUsuarios()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CrudUsuarios_Load(object sender, EventArgs e)
        {
            
            string QryConsultarUsuarios = "Select * from tbl_usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewUsuarios.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
