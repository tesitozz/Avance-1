using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace waSEMANA077.Models
{
    public class DaoObrero
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        public Boolean Insertar(Obrero obj)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar_obrero", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_obrero", obj.id_obrero);
            cmd.Parameters.AddWithValue("@nombre", obj.nombre);
            cmd.Parameters.AddWithValue("@apellido", obj.apellido);
            cmd.Parameters.AddWithValue("@dni", obj.dni);
            cmd.Parameters.AddWithValue("@genero", obj.genero);
            cmd.Parameters.AddWithValue("@sueldo", obj.sueldo);
            cmd.Parameters.AddWithValue("@fecha_naci", obj.fecha_naci);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                cn.Close();
                cmd.Dispose();
            }

        }
    }
}