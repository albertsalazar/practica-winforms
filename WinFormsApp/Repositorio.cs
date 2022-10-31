using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace WinFormsApp
{
    internal class Repositorio
    {
        /// <summary>
        /// Método para Obtener los vuelos
        /// </summary>
        /// <returns></returns>
        public static DataSet ObtenerVuelos()
        {
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.CommandText = "SELECT * FROM VUELOS";
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }
        /// <summary>
        /// Método para crear un vuelo.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CrearVuelo(Vuelo v)
        {
            bool isOk = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; INSERT INTO VUELOS VALUES ('" + v.origen + "', '" + v.destino + "','" + v.fecha + "', '" + v.pasajeros + "')";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                isOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOk = false;
            }

            return isOk;
        }
        /// <summary>
        /// Método para eliminar un vuelo.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool EliminarVuelo(Vuelo v)
        {
            bool isOk = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "DELETE FROM VUELOS WHERE ID = '" + v.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                isOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOk = false;
            }

            return isOk;
        }
        /// <summary>
        /// Método para modificar un vuelo.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ModificarVuelo(Vuelo v)
        {
            bool isOk = false;
            Conexion conexion = new Conexion();
            SqlCommand comando = new SqlCommand();

            try
            {
                comando.CommandText = "set dateformat dmy; UPDATE VUELOS SET ORIGEN = '" + v.origen + "', DESTINO = '" + v.destino + "', FECHA= '" + v.fecha + "', " +
                    "PASAJEROS = '" + v.pasajeros + "' " +
                    " WHERE ID = '" + v.Id + "'";

                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                isOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isOk = false;
            }

            return isOk;
        }
    }
}
