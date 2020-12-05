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
    public class D_visitantes
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

        public DataTable desplegarAulas(int like)
        {
            SqlDataReader leerFilas;
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_DESPLEGARAULA", conexion);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", like);
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Close();
            return tabla;


        }
        public DataTable ListarVisitantes(int like)
        {
            SqlDataReader leerFilas;
            DataTable tabla = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_LISTARVISITANTES", conexion);
            cmd.Parameters.AddWithValue("@EDIFICIO", like);
            cmd.CommandType = CommandType.StoredProcedure;
            leerFilas = cmd.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Close();
            return tabla;


        }

        public void insertarVisitante(E_visitantes visitantes)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARVISITANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IMAGE", visitantes.IMAGEN);
            cmd.Parameters.AddWithValue("@NOMBRE", visitantes.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", visitantes.APELLIDO);
            cmd.Parameters.AddWithValue("@CARRERA", visitantes.CARRERA);
            cmd.Parameters.AddWithValue("@CORREO", visitantes.CORREO);
            cmd.Parameters.AddWithValue("@ID_EDIFICIO", visitantes.IDEDIFICIO);
            cmd.Parameters.AddWithValue("@ID_AULA", visitantes.IDAULA);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", visitantes.HORAENTRADA);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", visitantes.HORASALIDA);
            cmd.Parameters.AddWithValue("@MOTIVA_ENTRADA", visitantes.MOTIVOENTRADA);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        /*

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
        */  
    }
}
