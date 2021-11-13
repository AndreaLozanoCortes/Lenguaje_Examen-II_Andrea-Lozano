using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Andrea_Lozano.Modelos.Entidades
{
    public class DetalleTicket
    {
        public int IdTipoSoporte { get; set; }
        public string TipoSoporte { get; set; }
        public int IdEstadoTicket { get; set; }
        public string EstadoTicket { get; set; }
        public int NumeroCliente { get; set; }
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
