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
    public partial class FrmConsultaClientesList : Form
    {
        List<Cliente> ListaClientes;
        public FrmConsultaClientesList()
        {
            InitializeComponent();
        }

        public FrmConsultaClientesList(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.ListaClientes = listaClientes;
        }

        private void CbCiudad_DropDown(object sender, EventArgs e)
        {
            CbCiudad.Items.Clear();
            ArrayList listaCiudades = new ArrayList();

            foreach (Cliente cliente in ListaClientes)
            {
                if (!listaCiudades.Contains(cliente.getCiudad()))
                {
                    listaCiudades.Add(cliente.getCiudad());
                }
            }

           foreach(String ciudad in listaCiudades)
           {
                CbCiudad.Items.Add(ciudad);
           }
        }

        private void CbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstClientes.Items.Clear();
            String ciudad = CbCiudad.Text;
            List<Cliente> listaMostrar = new List<Cliente>();

            foreach(Cliente cliente in ListaClientes)
            {
                if(cliente.getCiudad() == ciudad)
                {
                    listaMostrar.Add(cliente);
                }
            }

            foreach(Cliente cliente in listaMostrar)
            {
                int indiceFoto = 0;
                if (CbVista.Text == "")
                    LstClientes.View = View.Details;

                if (cliente.getVip() == true)
                    indiceFoto = 1;

                ListViewItem lista = new ListViewItem(cliente.getNombre(),indiceFoto);
                
                lista.SubItems.Add(cliente.getApellidos());
                lista.SubItems.Add(cliente.getEmail());
                lista.SubItems.Add(cliente.getComentario());

                LstClientes.Items.Add(lista);
            }
        }

        private void CbVista_DropDown(object sender, EventArgs e)
        {
            CbVista.Items.Clear();
            CbVista.Items.Add("Iconos grandes");
            CbVista.Items.Add("Detalles");
            CbVista.Items.Add("Iconos pequeños");
            CbVista.Items.Add("Lista");
            CbVista.Items.Add("Mosaico");
        }

        private void CbVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbVista.Text)
            {
                case "Iconos grandes":
                    LstClientes.View = View.LargeIcon;
                    break;
                case "Detalles":
                    LstClientes.View = View.Details;
                    break;
                case "Iconos pequeños":
                    LstClientes.View = View.SmallIcon;
                    break;
                case "Lista":
                    LstClientes.View = View.List;
                    break;
                case "Mosaico":
                    LstClientes.View = View.Tile;
                    break;
            }
        }
    }
}
