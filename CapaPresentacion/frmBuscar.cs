using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmBuscar : Form
    {

        private readonly CN_Empleados objCN = new CN_Empleados();

        public frmBuscar()
        {
            InitializeComponent();
        }

        private void Button_Buscar_Click(object sender, System.EventArgs e)
        {
            List<object> data = objCN.BuscarEmpleado(txt_Cod.Text);
            if (data.Count > 0)
            {
                object empleado = data[0];
                var tipo = empleado.GetType();

                lblNom.Text = tipo.GetProperty("Nombre").GetValue(empleado)?.ToString();
                lblApellido.Text = tipo.GetProperty("Apellido").GetValue(empleado)?.ToString();
                lblEdad.Text = tipo.GetProperty("Edad").GetValue(empleado)?.ToString();
                lblCargo.Text = tipo.GetProperty("Cargo").GetValue(empleado)?.ToString();
                lblSalario.Text = tipo.GetProperty("Salario_base").GetValue(empleado)?.ToString();

            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
                lblNom.Text = "-";
                lblApellido.Text = "-";
                lblEdad.Text = "-";
                lblCargo.Text = "-";
                lblSalario.Text = "-";
            }
        }
    }
}
