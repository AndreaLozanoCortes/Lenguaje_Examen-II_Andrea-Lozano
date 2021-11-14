
using Examen_II_Andrea_Lozano.Modelos.DAD;
using Examen_II_Andrea_Lozano.Modelos.Entidades;
using Examen_II_Andrea_Lozano.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Andrea_Lozano.Controladores
{
    public class DetalleController
    {  
        DetalleView vista;
        TipoDAD tipoDAD = new TipoDAD();
        EstadoDAD estadoDAD = new EstadoDAD();
        TicketDAD ticketDAD = new TicketDAD();
 
        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTipo();
            ListarEstado();
            ListarTicket();
        }
        private void ListarTipo()
        {
            vista.DetalleDataGridView.DataSource = tipoDAD.GetTipo();
        }
        private void ListarEstado()
        {
            vista.Detalle1DataGridView.DataSource = estadoDAD.GetEstado();
        }
        private void ListarTicket()
        {
           vista.Detalle2DataGridView.DataSource = ticketDAD.GetTicket();
        }

       


    }
}
