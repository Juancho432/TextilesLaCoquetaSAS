using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        private readonly CN_Empleados objCN = new CN_Empleados();

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Button_Registrar_Click(object sender, EventArgs e)
        {
            objCN.RegistrarEmpleado(txt_cod.Text, txt_Nom.Text, txt_Ape.Text, 
                                    txt_Edad.Text, txt_Cargo.Text, txt_Sal.Text);
            MessageBox.Show("Registro Exitoso");
        }
    }
}
