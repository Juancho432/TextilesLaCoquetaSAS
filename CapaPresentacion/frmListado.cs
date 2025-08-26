using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmListado : Form
    {
        CN_Empleados objCN = new CN_Empleados();

        public frmListado()
        {
            InitializeComponent();
        }

        private void Button_Listado_Click(object sender, EventArgs e)
        {
            dvg_Listado.DataSource = null;
            dvg_Listado.DataSource = objCN.ListarEmpleados();
        }
    }
}
