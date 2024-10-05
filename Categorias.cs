using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class Categorias : Form
    {
        private SqlConnection conn;
        public Categorias()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            string QryConsultarCategorias = "Select * from tbl_categorias";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarCategorias, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewCategoria.DataSource = dt;
        }
    }
}
