
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
        //TicketView vista;
        TicketDAD ticketDAD = new TicketDAD();
        //Ticket ticket = new Ticket();

        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(Load);
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTicket();
        }

        private void ListarTicket()
        {
           vista.DetalleDataGridView1.DataSource = ticketDAD.GetTicket();
        }


    }
}
