using Examen_II_Andrea_Lozano.Modelos.DAD;
using Examen_II_Andrea_Lozano.Modelos.Entidades;
using Examen_II_Andrea_Lozano.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Andrea_Lozano.Controladores
{
    public class TickectController
    {
        TicketView vista;
        TicketDAD ticketDAD = new TicketDAD();
        Ticket ticket = new Ticket();
        string operacion = string.Empty;
        public TickectController(TicketView  view)
        {
            vista = view;
            vista.btn_Nuevo.Click += new EventHandler(Nuevo);
            vista.btn_Agregar.Click += new EventHandler(Agregar);
            vista.Load += new EventHandler(Load);
        }


        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
        }

        private void ListarTicket()
        {

            ticketDAD.GetTicket();
        }
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Agregar(object serder, EventArgs e)
        {
            if (vista.txt_IdentidadCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_IdentidadCliente, "Ingrese un número de identidad");
                vista.txt_IdentidadCliente.Focus();
                return;
            }
            if (vista.txt_NombreCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_NombreCliente, "Ingrese un nombre");
                vista.txt_NombreCliente.Focus();
                return;
            }
            if (vista.txt_EmailCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_EmailCliente, "Ingrese una email");
                vista.txt_EmailCliente.Focus();
                return;
            }
            if (vista.txt_DireccionCliente.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_DireccionCliente, "Ingrese una dirección");
                vista.txt_DireccionCliente.Focus();
                return;
            }

            ticket.Identidad = vista.txt_IdentidadCliente.Text;
            ticket.Nombre = vista.txt_NombreCliente.Text;
            ticket.Email = vista.txt_EmailCliente.Text;
            ticket.Direccion = vista.txt_DireccionCliente.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = ticketDAD.InsertarNuevoCliente(ticket);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Ticket Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    //ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Ticket", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


            private void LimpiarControles()
        {
            vista.txt_NumCliente.Clear();
            vista.txt_IdentidadCliente.Clear();
            vista.txt_NombreCliente.Clear();
            vista.txt_EmailCliente.Clear();
            vista.txt_DireccionCliente.Clear();
        }


        private void HabilitarControles()
        {
            vista.txt_IdentidadCliente.Enabled = true;
            vista.txt_NombreCliente.Enabled = true;
            vista.txt_EmailCliente.Enabled = true;
            vista.txt_DireccionCliente.Enabled = true;

            vista.btn_Agregar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Limpiar.Enabled = true;
            vista.btn_Nuevo.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.txt_NumCliente.Enabled = false;
            vista.txt_IdentidadCliente.Enabled = false;
            vista.txt_NombreCliente.Enabled = false;
            vista.txt_EmailCliente.Enabled = false;
            vista.txt_DireccionCliente.Enabled = false;

            vista.btn_Agregar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Limpiar.Enabled = false;
            vista.btn_Nuevo.Enabled = true;
        }
    }
}
