using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class Login : Form
    {
        private SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=GODLECH\\SQLEXPRESS;Initial Catalog=Db_farmacia;Integrated Security=True;");
            conn = new SqlConnection("server=DESKTOP-QDTQ6AS\\SQLEXPRESS; database=Db_farmacia; integrated security=true");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txtUser.Text.Trim();
            password = txtPasswordUser.Text.Trim();

            conn.Open();
            string QryConsultarUsuarios = "Select Usuario, Contrasena from tbl_usuarios where Usuario = @user";
            using (SqlCommand cmd = new SqlCommand(QryConsultarUsuarios, conn))
            {
                cmd.Parameters.AddWithValue("@user", user);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbPasswordHash = reader["Contrasena"].ToString();
                        MenuNavegacion nav = new MenuNavegacion();
                        nav.Show();
                        MessageBox.Show("Sesion iniciada con exito!");

                    }
                    else
                    {
                        MessageBox.Show("Usuario no enontrado.");
                    }
                }

            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
