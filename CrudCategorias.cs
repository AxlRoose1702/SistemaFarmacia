using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CrudCategorias : Form
    {
        private SqlConnection conn;
        public CrudCategorias()
        {
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");
        }

        private void txtCodigoCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrudCategorias_Load(object sender, EventArgs e)
        {
            string QryConsultarUsuarios = "Select * from tbl_usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewCategorias.DataSource = dt;
        }
    }
}
