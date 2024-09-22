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
    public partial class CrudProveedores : Form
    {
        private SqlConnection conn;
        public CrudProveedores()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
        }

        private void CrudProveedores_Load(object sender, EventArgs e)
        {
            string QryConsultarUsuarios = "Select * from tbl_usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(QryConsultarUsuarios, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgviewUsuarios.DataSource = dt;
        }
    }
}
