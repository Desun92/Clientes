﻿using System;
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
    public partial class FrmConsultaClientesTree : Form
    {
        List<Cliente> ListaClientes;
        public FrmConsultaClientesTree()
        {
            InitializeComponent();
        }

        public FrmConsultaClientesTree(List<Cliente> listaClientes)
        {
            InitializeComponent();
            this.ListaClientes = listaClientes;
        }

        private void FrmConsultaClientesTree_Load(object sender, EventArgs e)
        {
            if (ListaClientes.Count > 0)
            {
                TrvClientes.Nodes.Clear();
                LimpiarCampos();
                int contadorNodos = 0;
                ArrayList ciudades = new ArrayList();

                //Sacamos la lista de las ciudades que tengamos en nuestro registro de clientes y la guardamos en un arrayList
                foreach (Cliente cliente in ListaClientes)
                {
                    if (!ciudades.Contains(cliente.getCiudad()))
                    {
                        ciudades.Add(cliente.getCiudad());
                    }
                }

                //Para cada ciudad que haya en el arrayList, creamos un nodo
                foreach (String ciudad in ciudades)
                {
                    TrvClientes.Nodes.Add(ciudad, ciudad, "tierra", "tierra.ico");
                    TrvClientes.SelectedNode = TrvClientes.Nodes[contadorNodos];

                    //Para esa ciudad que hemos creado, le añadimos los apellidos de los clientes que pertenezcan a dicha ciudad
                    foreach (Cliente cliente in ListaClientes)
                    {
                        if (cliente.getCiudad() == ciudad)
                        {
                            if (cliente.getVip())
                            {
                                TrvClientes.SelectedNode.Nodes.Add(cliente.getApellidos(), cliente.getApellidos(), 1);
                            }
                            else
                            {
                                TrvClientes.SelectedNode.Nodes.Add(cliente.getApellidos(), cliente.getApellidos(), 2);
                            }
                        }
                    }
                    contadorNodos++;
                }
            }
        }

        public void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtCiudad.Clear();
            TxtComentarios.Clear();
            TxtEmail.Clear();
            PctFoto.Image = null;
        }

        private void TrvClientes_DoubleClick(object sender, EventArgs e)
        {
            if(ListaClientes.Count > 0)
            {
                LimpiarCampos();
                //Comprobamos que el nodo seleccionado no sea el de una ciudad, si no el de un cliente
                if(TrvClientes.SelectedNode.Parent != null)
                {
                    //Si es el de un cliente, obtenemos sus datos recorriendo nuestra lista de clientes y exponiéndolos en los campos de texto correspondientes
                    String datos = TrvClientes.SelectedNode.Text;

                    foreach(Cliente cliente in ListaClientes)
                    {
                        if(cliente.getApellidos() == datos)
                        {
                            TxtNombre.Text = cliente.getNombre();
                            TxtApellidos.Text = cliente.getApellidos();
                            TxtCiudad.Text = cliente.getCiudad();
                            TxtEmail.Text = cliente.getEmail();
                            TxtComentarios.Text = cliente.getComentario();
                            if(cliente.getRutaFoto() != null)
                                PctFoto.Image = Image.FromFile(cliente.getRutaFoto());
                            break;
                        }
                    }
                }
            }
        }
    }
}
