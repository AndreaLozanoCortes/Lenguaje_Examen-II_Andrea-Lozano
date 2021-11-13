using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen_II_Andrea_Lozano.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        TicketView vistaTicket;
        DetalleView vistaDetalle;

        //Vista Ticket
        private void toolStripEx3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (vistaTicket == null)
            {
                vistaTicket = new TicketView();
                vistaTicket.MdiParent = this;
                vistaTicket.FormClosed += Vista_FormClosed;
                vistaTicket.Show();
            }
            else
            {
                vistaTicket.Activate();
            }
        }

        //Vista Detalle
        private void toolStripTabItem4_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetalleView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += Vista_FormClosed1;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
        }

        private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTicket = null;
        }

        private void Vista_FormClosed1(object sender, FormClosedEventArgs e)
        {
            vistaDetalle = null;
        }
    }
    }

