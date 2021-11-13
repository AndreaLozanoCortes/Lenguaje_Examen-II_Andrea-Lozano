
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
        TicketDAD ticketDAD = new TicketDAD();
        TipoDAD tipoDAD = new TipoDAD();
        

        public DetalleController(DetalleView view)
        {
            vista = view;
            vista.Load += new EventHandler(LoadTodo);
            //vista.Load += new EventHandler(Load1);
        }

        private void LoadTodo(object sender, EventArgs e)
        {
            //ListarTodo();
            vista.DetalleDataGridView1.DataSource = tipoDAD.GetTipo();
            //vista.DetalleDataGridView1.DataSource = ticketDAD.GetTicket();
        }

        //private void Load1(object sender, EventArgs e)
        //{ 
        //    ListarTicket();
        //}

        //private void ListarTodo()
        //{

        //    vista.DetalleDataGridView1.DataSource = tipoDAD.GetTipo();
        //    vista.DetalleDataGridView1.DataSource = ticketDAD.GetTicket();
        //}

        //private void ListarTicket()
        //{
        //   vista.DetalleDataGridView1.DataSource = ticketDAD.GetTicket();
        //}

       


    }
}
