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

        private void CbCiudad_DropDown(object sender, EventArgs e) //Método que "pone" las ciudades que tenemos disponibles en el ComboBox
        {
            CboCiudad.Items.Clear();
            ArrayList listaCiudades = new ArrayList();

            foreach (Cliente cliente in ListaClientes)
            {
                if (!listaCiudades.Contains(cliente.getCiudad())) //Si ya tenemos la ciudad una vez, no la volvemos a añadir
                {
                    listaCiudades.Add(cliente.getCiudad());
                }
            }

           foreach(String ciudad in listaCiudades) //Añadimos a la ComboBox las ciudades
           {
                CboCiudad.Items.Add(ciudad);
           }
        }

        private void CbCiudad_SelectedIndexChanged(object sender, EventArgs e) //Método que actualiza la información de la ListView al cambiar el valor del ComboBox
        {
            LvwClientes.Items.Clear();
            String ciudad = CboCiudad.Text;
            List<Cliente> listaMostrar = new List<Cliente>();

            foreach(Cliente cliente in ListaClientes) //Guardamos en nuestro array para mostrar los datos de los clientes aquellos clientes que pertenezcan a la ciudad que está en el ComboBox
            {
                if(cliente.getCiudad() == ciudad)
                {
                    listaMostrar.Add(cliente);
                }
            }

            foreach(Cliente cliente in listaMostrar) //Mostramos los datos de los clientes y le añadimos un icono u otro dependiendo de si es o no VIP
            {
                int indiceFoto = 0;
                if (CboVista.Text == "")
                    LvwClientes.View = View.Details;

                if (cliente.getVip() == true)
                    indiceFoto = 1;

                ListViewItem lista = new ListViewItem(cliente.getNombre(),indiceFoto);
                
                lista.SubItems.Add(cliente.getApellidos());
                lista.SubItems.Add(cliente.getEmail());
                lista.SubItems.Add(cliente.getComentario());

                LvwClientes.Items.Add(lista);
            }
        }

        private void CbVista_DropDown(object sender, EventArgs e) //Método que despliega las distintas opciones en el ComboBox Vista
        {
            CboVista.Items.Clear();
            CboVista.Items.Add("Iconos grandes");
            CboVista.Items.Add("Detalles");
            CboVista.Items.Add("Iconos pequeños");
            CboVista.Items.Add("Lista");
            CboVista.Items.Add("Mosaico");
        }

        private void CbVista_SelectedIndexChanged(object sender, EventArgs e) //Método que cambia la distribución de la información del ListView en función de la opción seleccionada en el ComboBox
        {
            switch (CboVista.Text)
            {
                case "Iconos grandes":
                    LvwClientes.View = View.LargeIcon;
                    break;
                case "Detalles":
                    LvwClientes.View = View.Details;
                    break;
                case "Iconos pequeños":
                    LvwClientes.View = View.SmallIcon;
                    break;
                case "Lista":
                    LvwClientes.View = View.List;
                    break;
                case "Mosaico":
                    LvwClientes.View = View.Tile;
                    break;
            }
        }
    }
}
