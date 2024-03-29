﻿using Examen_II_Andrea_Lozano.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_II_Andrea_Lozano.Modelos.DAD
{
    public class TipoDAD : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarTipo(Tipo tipo)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPO_SOPORTE");
                sql.Append(" VALUES (@TipoSoporte); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 50).Value = tipo.TipoSoporte;
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

        public DataTable GetTipo()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPO_SOPORTE");

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

        public bool ActualizarTipo(Tipo tipo)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPO_SOPORTE");
                sql.Append(" SET TIPOSOPORTE = (@TipoSoporte); ");
                sql.Append(" WHERE IDTIPOSOPORTE = (@Id); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tipo.IdTipoSoporte;
                comando.Parameters.Add("@TipoSoporte", SqlDbType.NVarChar, 50).Value = tipo.TipoSoporte;
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

        public bool EliminarTipo(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TIPO_SOPORTE");
                sql.Append(" WHERE IDTIPOSOPORTE = (@Id); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
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
