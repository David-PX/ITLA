using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Configuration;

namespace CapaDatos
{
    public class D_edificios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_edificios> ListarEdificios(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@LIKE", buscar);
            leerFilas = cmd.ExecuteReader();
            List<E_edificios> Listar = new List<E_edificios>();
            while (leerFilas.Read())
            {
                Listar.Add(new E_edificios
                {
                    ID = leerFilas.GetInt32(0),

                    NOMBRE = leerFilas.GetString(1),
                    ESTADO = leerFilas.GetString(2)

                });


            }
            conexion.Close();
            leerFilas.Close();
            return Listar;

        }



        public void insertarEdificio(E_edificios edificio) { 
        
            SqlCommand cmd = new SqlCommand("SP_GUARDAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", edificio.NOMBRE);
            cmd.Parameters.AddWithValue("@ESTADO", edificio.ESTADO);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void editarEdificio(E_edificios edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", edificio.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", edificio.NOMBRE);
            cmd.Parameters.AddWithValue("@ESTADO", edificio.ESTADO);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void elminarEdificio(E_edificios edificio)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAREDIFICIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID", edificio.ID);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
