﻿using Examen_II_Andrea_Lozano.Modelos.DAD;
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
    public class TipoController
    {
        TipoView vista;
        TipoDAD tipoDAD = new TipoDAD();
        Tipo tipo = new Tipo();
        string operacion = string.Empty;
        public TipoController(TipoView view)
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
            ListarTipo();
        }
        private void ListarTipo()
        {

            tipoDAD.GetTipo();
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
            tipo = null;
        }
        private void Modificar(object sender, EventArgs e)
        {
            //if (vista.DetalleDataGridView.SelectedRows.Count > 0)
            //{
            //    operacion = "Modificar";
            //    HabilitarControles();

            //    //vista.txt_IdTipoSoporte.Text = vista.DetalleDataGridView.CurrentRow.Cells["IDTIPOSOPORTE"].Value.ToString();
            //    //vista.cb_TipoSoporte.Text = vista.DetalleDataGridView.CurrentRow.Cells["TIPOSOPORTE"].Value.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Debe selecciona una Fila/Registro");
            //}

        }
        private void Eliminar(object sender, EventArgs e)
        {
            //if (vista.DetalleDataGridView.SelectedRows.Count > 0)
            //{
            //    bool elimino = tipoDAD.EliminarTipo(Convert.ToInt32(vista.DetalleDataGridView.CurrentRow.Cells["IDTIPOSOPORTE"].Value));
            //    if (elimino)
            //    {
            //        MessageBox.Show("Tipo de Soporte Eliminado Exitosamente", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information);
            //        //ListarTipo();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo Eliminar el Tipo de Soporte", "Atención", MessageBoxButtons.OK,
            //                         MessageBoxIcon.Error);
            //}
        }
        private void Agregar(object serder, EventArgs e)
        {
            if (vista.cb_TipoSoporte.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_TipoSoporte, "Selecione un tipo de servicio");
                vista.cb_TipoSoporte.Focus();
                return;
            }

            tipo.TipoSoporte = vista.cb_TipoSoporte.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = tipoDAD.InsertarTipo(tipo);

                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();

                    MessageBox.Show("Tipo de Soporte Creado Exitosamente", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    //ListarTipo();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Tipo de Soporte", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            } 

            //else if (operacion == "Modificar")
            //{
            //    tipo.IdTipoSoporte = Convert.ToInt32(vista.txt_IdTipoSoporte.Text);
            //    bool modifico = tipoDAD.ActualizarTipo(tipo);
            //    if (modifico)
            //    {
            //        DesabilitarControles();
            //        LimpiarControles();

            //        MessageBox.Show("Tipo Modificado Exitosamente", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Information);
            //        //ListarTipo();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo Modificar el Tipo de Soporte", "Atención", MessageBoxButtons.OK,
            //                        MessageBoxIcon.Error);
            //    }
            //}
        }
        private void LimpiarControles()
        {
            vista.cb_TipoSoporte.Text = " ";
        }
        private void HabilitarControles()
        {
            vista.cb_TipoSoporte.Enabled = true;

            vista.btn_Agregar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
            vista.btn_Nuevo.Enabled = false;
        }
        private void DesabilitarControles()
        {
            vista.cb_TipoSoporte.Enabled = false;

            vista.btn_Agregar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_Nuevo.Enabled = true;
        }
    }
}
