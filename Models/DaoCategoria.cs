using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace waSEMANA077.Models
{
    public class DaoCategoria
    {
        static string cadena = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        private SqlConnection cn = new SqlConnection(cadena);

        public Boolean Insertar(Categoria obj)
        {
            SqlCommand cmd = new SqlCommand("Compras.usp_insertar_categorias", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcat", obj.idCategoria);
            cmd.Parameters.AddWithValue("@nomcat", obj.NombreCategoria);
            cmd.Parameters.AddWithValue("@descat", obj.Descripcion);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;


            } catch (SqlException ex)
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