using CapaNegocio;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNomina : Form
    {

        private readonly CN_Empleados objCN = new CN_Empleados();

        public frmNomina()
        {
            InitializeComponent();
        }

        private void Button_filtrar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codigo.Text))
            {
                foreach (DataGridViewRow fila in dataGrid_nomina.Rows)
                {
                    fila.Visible = true;
                }
                return;
            }

            foreach (DataGridViewRow fila in dataGrid_nomina.Rows)
            {
                if (fila.Cells[0].Value.ToString() == txt_codigo.Text.Trim())
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = false;
                }
            }
        }

        private void FrmNomina_Load(object sender, System.EventArgs e)
        {
            foreach (var item in objCN.ObtenerNomina())
            {
                dataGrid_nomina.Rows.Add(item.Codigo, item.Nombre, item.Apellido, item.Cargo, item.SalarioBase,
                                         item.Salud, item.Pension, item.Transporte, item.SalarioNeto);
            }
        }
    }
}
