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
    public class EstadoController
    {
        EstadoView vista;
        EstadoDAD estadoDAD = new EstadoDAD();
        Estado estado = new Estado();
        string operacion = string.Empty;
        public EstadoController(EstadoView view)
        {
            vista = view;
            vista.btn_Nuevo.Click += new EventHandler(Nuevo);
            vista.btn_Agregar.Click += new EventHandler(Agregar);
            vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            vista.btn_Cancelar.Click += new EventHandler(Cancelar);
            vista.Load += new EventHandler(Load);
        }
        private void Load(object sender, EventArgs e)
        {
            ListarEstado();
        }
        private void ListarEstado()
        {

            estadoDAD.GetEstado();
        }
        private void Nuevo(object serder, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
            estado = null;
        }
        private void Modificar(object sender, EventArgs e)
        {
            //if (vista.Detalle1DataGridView.SelectedRows.Count > 0)
            //{
            //    operacion = "Modificar";
            //    HabilitarControles();

                //vista.txt_IdEstado.Text = vista.Detalle1DataGridView.CurrentRow.Cells["IDESTADOTICKET"].Value.ToString();
                //vista.cb_Estado.Text = vista.Detalle1DataGridView.CurrentRow.Cells["ESTADOTICKET"].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Debe selecciona una Fila/Registro");
            //}

        }
        private void Eliminar(object sender, EventArgs e)
        {
            //if (vista.Detalle1DataGridView.SelectedRows.Count > 0)
            //{
               //bool elimino = estadoDAD.EliminarEstado(Convert.ToInt32(vista.Detalle1DataGridView.CurrentRow.Cells["IDESTADOTICKET"].Value));
            //    if (elimino)
            //    {
            //        MessageBox.Show("Estado Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information);
            //        //ListarEstado();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo Eliminar el Estado Actual", "Atención", MessageBoxButtons.OK,
            //                         MessageBoxIcon.Error);
            //}
        }
        private void Agregar(object serder, EventArgs e)
        {
            if (vista.cb_Estado.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_Estado, "Seleccione un estado");
                vista.cb_Estado.Focus();
                return;
            }

            estado.EstadoTicket = vista.cb_Estado.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = estadoDAD.InsertarEstado(estado);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Estado Ingresado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    //ListarEstado();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el Estado", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }

            //else if (operacion == "Modificar")
            //{
                  //estado.IdEstadoTicket = Convert.ToInt32(vista.txt_IdEstado.Text);
                  //bool modifico = estadoDAD.ActualizarEstado(estado);
            //    if (modifico)
            //    {
            //        DesabilitarControles();
            //        LimpiarControles();

            //        MessageBox.Show("Estado Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information);
            //        //ListarEstado();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo Modificar el Estado", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Error);
            //    }
            //}
        }
        private void LimpiarControles()
        {
            vista.cb_Estado.Text = " ";
        }
        private void HabilitarControles()
        {
            vista.cb_Estado.Enabled = true;

            vista.btn_Agregar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
            vista.btn_Nuevo.Enabled = false;

        }
        private void DesabilitarControles()
        {
            vista.cb_Estado.Enabled = true;

            vista.btn_Agregar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;
        }
    }
}
