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
    public class EstadoDAD : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarEstado(Estado estado)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO_TICKET");
                sql.Append(" VALUES (@EstadoTicket); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = estado.EstadoTicket;
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

        public DataTable GetEstado()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO_TICKET");

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

        public bool ActualizarEstado(Estado estado)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADO_TICKET");
                sql.Append(" SET ESTADOTICKET = (@EstadoTicket); ");
                sql.Append(" WHERE IDESTADOTICKET = (@IdEstadoTicket); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdEstadoTicket", SqlDbType.Int).Value = estado.IdEstadoTicket;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = estado.EstadoTicket;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                modifico = false;
            }
            return modifico;
        }

        public bool EliminarEstado(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM ESTADO_TICKET");
                sql.Append(" WHERE IDESTADOTICKET = (@IdEstadoTicket); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@IdEstadoTicket", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                modifico = false;
            }
            return modifico;
        }
    }
}
