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
        private List<Cliente> ListaClientes; //Lista para trabajar con los clientes
        String RutaImagen = ""; //String para cargar la ruta de la imagen adjunta a los clientes
        String NombreClienteSeleccionado = null; //String para comprobar el nombre de un cliente seleccionado
        String ApellidosClienteSeleccionado = null; //String para comprobar los apellidos de un cliente seleccionado
        public FrmAlta()
        {
            InitializeComponent();
        }

        public FrmAlta(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.ListaClientes = listaClientes;

            ArrayList listaNombresApellidos = new ArrayList();

            //Añadimos a la ListBox el nombre y apellidos de los clientes por orden alfabético
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

        private void BtnGuardar_Click(object sender, EventArgs e) //Método para guardar un cliente nuevo en la lista
        {
            //Si falta algún campo por rellenar, se lo advertimos al usuario, en caso contrario comenzamos a trabajar
            if(TxtNombre.Text != "" && TxtApellidos.Text != "" && TxtCiudad.Text != "" && TxtEmail.Text != "" && TxtComentario.Text != "")
            {
                String email = TxtEmail.Text;
                //Si el email es válido (tiene formato correcto) continuamos, si no, se lo advertimos al usuario
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

                    //Comparamos que no tengamos ya al cliente en la lista mirando su nombre y apellidos en mayúscula para evitar posibles nombres iguales pero en minúscula.
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

                    //Si no está, lo añadimos a nuestra lista de clientes y a nuestra ListBox
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

        private void BtnCargarFoto_Click(object sender, EventArgs e) //Método para cargar la foto del cliente
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

        private void LstClientes_Click(object sender, EventArgs e) //Método para seleccionar un cliente a borrar
        {
            if (LstClientes.Items.Count > 0)
            {
                String ClienteSeleccionado = LstClientes.SelectedItem.ToString(); //Metemos el cliente seleccionado en un String
                String[] nombreApellidosCliente = ClienteSeleccionado.Split(','); //Separamos por un lado el nombre y por el otro los apellidos
                ApellidosClienteSeleccionado = nombreApellidosCliente[0]; //Guardamos los apellidos en una variable
                NombreClienteSeleccionado = nombreApellidosCliente[1]; //Guardamos el nombre en otra
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e) //Método para borrar un cliente
        {
            if(ApellidosClienteSeleccionado != null && NombreClienteSeleccionado != null) //Si no tenemos ningún cliente seleccionado, no hacemos nada
            {
                int indice = 0;
                Boolean esta = false;
                foreach(Cliente cliente in ListaClientes) //Comprobamos que el cliente seleccionado está en nuestra lista
                {
                    if(cliente.getApellidos() == ApellidosClienteSeleccionado && cliente.getNombre() == NombreClienteSeleccionado)
                    {
                        esta = true;
                        break;
                    }
                    indice++;
                }

                if (esta) //Si está, lo borramos en el índice en el que se encuentre
                {
                    ListaClientes.RemoveAt(indice);

                    ArrayList listaNombresApellidos = new ArrayList();

                    foreach (Cliente clienteLista in ListaClientes) //Actualizamos la lista con los clientes después de eliminarlo
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

        public void LimpiarCampos() //Método para limpiar campos
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtCiudad.Clear();
            TxtEmail.Clear();
            TxtComentario.Clear();
            ChkVip.Checked = false;
            PctFoto.Image = null;
        }

        public Boolean EmailValido() //Método para comprobar el correcto formato de un email
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
