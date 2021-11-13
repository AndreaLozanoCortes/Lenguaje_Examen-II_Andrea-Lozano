using Examen_II_Andrea_Lozano.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Andrea_Lozano.Modelos.DAD
{
    public class TicketDAD: Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarNuevoCliente(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET_CLIENTE");
                sql.Append(" VALUES (@Identidad, @Nombre, @Email, @Direccion); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 50).Value = ticket.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = ticket.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = ticket.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = ticket.Direccion;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetTicket()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET_CLIENTE");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dt;
        }

    }


}
