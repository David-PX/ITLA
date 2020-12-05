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
    public class D_aulas
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);



        
        public DataTable desplegarEdificios()
        {
            SqlDataReader leerFilas;
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_BUSCAREDIFICIO", conexion);
            cmd.Parameters.AddWithValue("@LIKE", "");
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Close();
            return tabla;


        }

        public DataTable ListarAulasYEdificios(string like)
        {
            SqlDataReader leerFilas;
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_BUSCARAULA", conexion);
            cmd.Parameters.AddWithValue("@LIKE", like);
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Close();
            return tabla;


        }
        /*
        public List<E_aulas> ListarAulas(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@LIKE", buscar);
            leerFilas = cmd.ExecuteReader();
            List<E_aulas> Listar = new List<E_aulas>();
            while (leerFilas.Read())
            {
                Listar.Add(new E_aulas
                {
                    ID = leerFilas.GetInt32(0),
                    IDEDIFICIO = leerFilas.GetInt32(1),
                    PLANTA = leerFilas.GetString(2),
                    NOMBRE = leerFilas.GetString(3),
                    ESTADO = leerFilas.GetString(4)

                });


            }
            conexion.Close();
            leerFilas.Close();
            return Listar;

        }
        */



        public void insertarAulas(E_aulas aula)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.IDEDIFICIO);
            cmd.Parameters.AddWithValue("@PLANTA", aula.PLANTA);
            cmd.Parameters.AddWithValue("@NOMBRE", aula.NOMBRE);
            cmd.Parameters.AddWithValue("@ESTADO", aula.ESTADO);

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

        public void editarAulas(E_aulas aula)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", aula.ID);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", aula.IDEDIFICIO);
            cmd.Parameters.AddWithValue("@PLANTA", aula.PLANTA);
            cmd.Parameters.AddWithValue("@NOMBRE", aula.NOMBRE);
            cmd.Parameters.AddWithValue("@ESTADO", aula.ESTADO);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void elminarAulas(E_aulas aula)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARAULA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID", aula.ID);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }

}
