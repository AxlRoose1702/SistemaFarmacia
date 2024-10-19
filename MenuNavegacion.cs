using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class MenuNavegacion : Form
    {
        public MenuNavegacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            CrudUsuarios usuarios = new CrudUsuarios();
            usuarios.Show();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            CrudClientes clientes = new CrudClientes();
            clientes.Show();
        }

        private void btnMenuProveedores_Click(object sender, EventArgs e)
        {
            CrudProveedores proveedores = new CrudProveedores();
            proveedores.Show();
        }

        private void btnMenuCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
        }

        private void btnMenuDetalleV_Click(object sender, EventArgs e)
        {
            CrudDetalleVentas detalleVentas = new CrudDetalleVentas();
            detalleVentas.Show();
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            CrudVentas ventas = new CrudVentas();
            ventas.Show();
        }

        private void btnMenuMedicamentos_Click(object sender, EventArgs e)
        {
            CrudMedicamentos medicamentos = new CrudMedicamentos();
            medicamentos.Show();
        }
    }
}
