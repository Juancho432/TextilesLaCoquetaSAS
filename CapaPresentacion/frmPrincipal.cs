using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.MdiParent = this;
            registro.Show();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar buscar = new frmBuscar();
            buscar.MdiParent = this;
            buscar.Show();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado();
            listado.MdiParent = this;
            listado.Show();
        }

        private void calcuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalario salario = new frmSalario();
            salario.MdiParent = this;
            salario.Show();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNomina nomina = new frmNomina();
            nomina.MdiParent = this;
            nomina.Show();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
