using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class FrmAlta : Form
    {
        private List<Cliente> ListaClientes;
        String RutaImagen = "";
        String NombreClienteSeleccionado = null;
        String ApellidosClienteSeleccionado = null;
        public FrmAlta()
        {
            InitializeComponent();
        }

        public FrmAlta(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.ListaClientes = listaClientes;

            ArrayList listaNombresApellidos = new ArrayList();

            foreach (Cliente clienteLista in ListaClientes)
            {
                String nombreApellidos = clienteLista.getApellidos();
                nombreApellidos += ",";
                nombreApellidos += clienteLista.getNombre();
                listaNombresApellidos.Add(nombreApellidos);
            }

            listaNombresApellidos.Sort();
            LstClientes.DataSource = null;
            LstClientes.DataSource = listaNombresApellidos;
        }

        public List<Cliente> getListaClientes()
        {
            return this.ListaClientes;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(TxtNombre.Text != "" && TxtApellidos.Text != "" && TxtCiudad.Text != "" && TxtEmail.Text != "" && TxtComentario.Text != "")
            {
                String email = TxtEmail.Text;
                if (EmailValido())
                {
                    String nombreComparar = TxtNombre.Text.ToUpper();
                    String apellidosComparar = TxtApellidos.Text.ToUpper();
                    String nombre = TxtNombre.Text;
                    String apellidos = TxtApellidos.Text;
                    String ciudad = TxtCiudad.Text;
                    String comentario = TxtComentario.Text;
                    Boolean vip = ChkVip.Checked;
                    Boolean esta = false;

                    Cliente cliente;

                    if (PctFoto.Image != null)
                        cliente = new Cliente(nombre, apellidos, ciudad, email, comentario, vip, RutaImagen);
                    else
                        cliente = new Cliente(nombre, apellidos, ciudad, email, comentario, vip);

                    foreach (Cliente clienteLista in ListaClientes)
                    {
                        String nombreCliente = clienteLista.getNombre().ToUpper();
                        String apellidosCliente = clienteLista.getApellidos().ToUpper();

                        if (nombreCliente == nombreComparar && apellidosCliente == apellidosComparar)
                        {
                            esta = true;
                            break;
                        }
                    }

                    if (!esta)
                    {
                        ListaClientes.Add(cliente);
                        ArrayList listaNombresApellidos = new ArrayList();

                        foreach (Cliente clienteLista in ListaClientes)
                        {
                            String nombreApellidos = clienteLista.getApellidos();
                            nombreApellidos += ",";
                            nombreApellidos += clienteLista.getNombre();
                            listaNombresApellidos.Add(nombreApellidos);
                        }

                        listaNombresApellidos.Sort();
                        LstClientes.DataSource = null;
                        LstClientes.DataSource = listaNombresApellidos;
                        MessageBox.Show("Cliente añadido");
                    }
                    else
                    {
                        MessageBox.Show("El cliente ya está registrado");
                    }
                }
                else
                    MessageBox.Show("El formato de Email no es correcto");
            }
            else
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog.FileName;
                    PctFoto.Image = Image.FromFile(imagen);
                    RutaImagen = imagen;
                }
            }
            catch
            {
                MessageBox.Show("El archivo no es del tipo soportado");
            }
        }

        private void LstClientes_Click(object sender, EventArgs e)
        {
            if (LstClientes.Items.Count > 0)
            {
                ListBox listBox = (ListBox)sender;
                String ClienteSeleccionado = listBox.SelectedItem.ToString();
                String[] nombreApellidosCliente = ClienteSeleccionado.Split(',');
                ApellidosClienteSeleccionado = nombreApellidosCliente[0];
                NombreClienteSeleccionado = nombreApellidosCliente[1];
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if(ApellidosClienteSeleccionado != null && NombreClienteSeleccionado != null)
            {
                int indice = 0;
                Boolean esta = false;
                foreach(Cliente cliente in ListaClientes)
                {
                    if(cliente.getApellidos() == ApellidosClienteSeleccionado && cliente.getNombre() == NombreClienteSeleccionado)
                    {
                        esta = true;
                        break;
                    }
                    indice++;
                }

                if (esta)
                {
                    ListaClientes.RemoveAt(indice);

                    ArrayList listaNombresApellidos = new ArrayList();

                    foreach (Cliente clienteLista in ListaClientes)
                    {
                        String nombreApellidos = clienteLista.getApellidos();
                        nombreApellidos += ",";
                        nombreApellidos += clienteLista.getNombre();
                        listaNombresApellidos.Add(nombreApellidos);
                    }

                    listaNombresApellidos.Sort();
                    LstClientes.DataSource = null;
                    LstClientes.DataSource = listaNombresApellidos;

                    MessageBox.Show("El cliente: " + ApellidosClienteSeleccionado + ", " + NombreClienteSeleccionado + " ha sido eliminado del registro");
                    ApellidosClienteSeleccionado = null;
                    NombreClienteSeleccionado = null;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún cliente para borrar");
            }
        }

        public void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtCiudad.Clear();
            TxtEmail.Clear();
            TxtComentario.Clear();
            ChkVip.Checked = false;
            PctFoto.Image = null;
        }

        public Boolean EmailValido()
        {
            String email = TxtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
