using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmSalario : Form
    {

        private readonly CN_Empleados objCN = new CN_Empleados();

        public frmSalario()
        {
            InitializeComponent();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            SalarioDTA? busqueda = objCN.CalcularSalario(txt_codigo.Text);
            if (busqueda is SalarioDTA data)
            {
                lbl_nombre_empleado.Text = data.Nombre;
                lbl_apellido_empleado.Text = data.Apellido;
                lbl_cargo.Text = data.Cargo;
                lbl_salario_base.Text = data.SalarioBase.ToString();
                lbl_deduccion_salud.Text = data.Salud.ToString();
                lbl_deduccion_pension.Text = data.Pension.ToString();
                lbl_aux_transporte.Text = data.Transporte.ToString();
                lbl_salario_neto.Text = data.SalarioNeto.ToString();
            }
            else
            {
                MessageBox.Show("El Empleado No se Encontró");
                lbl_nombre_empleado.Text = "-";
                lbl_apellido_empleado.Text = "-";
                lbl_cargo.Text = "-";
                lbl_salario_base.Text = "-";
                lbl_deduccion_salud.Text = "-";
                lbl_deduccion_pension.Text = "-";
                lbl_aux_transporte.Text = "-";
                lbl_salario_neto.Text = "-";
            }
        }
    }
}
