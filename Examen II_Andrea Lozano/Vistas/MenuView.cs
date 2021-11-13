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

        TipoView vistaTipo;
        EstadoView vistaEstado;
        TicketView vistaTicket;
        DetalleView vistaDetalle;

        //Vista Tipo
        private void TipoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaTipo == null)
            {
                vistaTipo = new TipoView();
                vistaTipo.MdiParent = this;
                vistaTipo.FormClosed += Vista_FormClosed;
                vistaTipo.Show();
            }
            else
            {
                vistaTipo.Activate();
            }
        }

        //Vista Estado
        private void EstadoToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaEstado == null)
            {
                vistaEstado = new EstadoView();
                vistaEstado.MdiParent = this;
                vistaEstado.FormClosed += Vista_FormClosed;
                vistaEstado.Show();
            }
            else
            {
                vistaEstado.Activate();
            }
        }

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
        private void DetalleToolStripButton_Click(object sender, EventArgs e)
        {
            if (vistaDetalle == null)
            {
                vistaDetalle = new DetalleView();
                vistaDetalle.MdiParent = this;
                vistaDetalle.FormClosed += Vista_FormClosed;
                vistaDetalle.Show();
            }
            else
            {
                vistaDetalle.Activate();
            }
        }

            private void Vista_FormClosed(object sender, FormClosedEventArgs e)
        {
            vistaTipo = null;
            vistaEstado = null;
            vistaTicket = null;
            vistaDetalle = null;
        }

       
    }
    }

