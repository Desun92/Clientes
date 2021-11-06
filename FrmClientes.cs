using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class FrmClientes : Form
    {
        FrmAlta FormAlta;
        FrmConsultaClientesList FormConsultaList;
        FrmConsultaClientesTree FormConsultaTree;
        List<Cliente> listaClientes = new List<Cliente>();

        public FrmClientes()
        {
            InitializeComponent();
            /*Cliente a = new Cliente("Adrian", "Castro Villacañas", "Madrid", "Adrian@google.com", "Ninguno", false, "C:/Users/Adri/Pictures/yo.jpg");
            Cliente b = new Cliente("Ruben", "Martin Gomez", "Madrid", "Ruben@google.com", "Ninguno", true);
            Cliente c = new Cliente("Mireia", "Lopez", "Barcelona", "Mireia@google.com", "Ninguno", true);

            this.listaClientes.Add(a);
            this.listaClientes.Add(b);
            this.listaClientes.Add(c);*/
        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            if (FormAlta == null)
            {
                FormAlta = new FrmAlta(listaClientes);
                FormAlta.MdiParent = this;
                FormAlta.Dock = DockStyle.Fill;
                FormAlta.Show();
            }
            else
            {
                FormAlta.Activate();
            }
        }

        private void MnuConsultaList_Click(object sender, EventArgs e)
        {
            if (FormConsultaList == null)
            {
                if(FormAlta!=null)
                    this.listaClientes = FormAlta.getListaClientes();

                FormConsultaList = new FrmConsultaClientesList(listaClientes);
                FormConsultaList.MdiParent = this;
                FormConsultaList.Dock = DockStyle.Fill;
                FormConsultaList.Show();
            }
            else
            {
                if (FormAlta != null)
                    this.listaClientes = FormAlta.getListaClientes();

                FormConsultaList.Activate();
            }
        }

        private void MnuConsultaTree_Click(object sender, EventArgs e)
        {
            if (FormConsultaTree == null)
            {
                if (FormAlta != null)
                    this.listaClientes = FormAlta.getListaClientes();

                FormConsultaTree = new FrmConsultaClientesTree(listaClientes);
                FormConsultaTree.MdiParent = this;
                FormConsultaTree.Dock = DockStyle.Fill;
                FormConsultaTree.Show();
            }
            else
            {
                if (FormAlta != null)
                    this.listaClientes = FormAlta.getListaClientes();

                FormConsultaTree.Activate();
            }
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            String mensaje = ("¿Desea realmente salir?");
            String cabecera = ("Salir");
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensaje, cabecera, botones,MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
                e.Cancel = true;
        }
    }
}
