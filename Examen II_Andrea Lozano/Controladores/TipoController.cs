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

        private void Agregar(object serder, EventArgs e)
        {
            if (vista.cb_TipoSoporte.Text == "")
            {
                vista.errorProvider1.SetError(vista.cb_TipoSoporte, "Ingrese un número de identidad");
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
                    //ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el Tipo de Soporte", "Atención", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }


        private void LimpiarControles()
        {
            vista.cb_TipoSoporte.Text = " ";
        }


        private void HabilitarControles()
        {
            vista.cb_TipoSoporte.Enabled = true;
            
            vista.btn_Agregar.Enabled = true;
            vista.btn_Limpiar.Enabled = true;
            vista.btn_Nuevo.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.cb_TipoSoporte.Enabled = true;

            vista.btn_Agregar.Enabled = false;
            vista.btn_Limpiar.Enabled = false;
            vista.btn_Nuevo.Enabled = true;
        }
    }
}
