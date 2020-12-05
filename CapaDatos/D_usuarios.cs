using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class D_usuarios
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_usuarios> listarUsuarios(string buscar)
        {
            SqlDataReader leerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@LIKE", buscar);
            leerFilas = cmd.ExecuteReader();
            List<E_usuarios> Listar = new List<E_usuarios>();
            while (leerFilas.Read())
            {
                Listar.Add(new E_usuarios
                {
                    ID = leerFilas.GetInt32(0),
                   
                    NOMBRE = leerFilas.GetString(1),
                    APELLIDO = leerFilas.GetString(2),
                    FECHANACIMIENTO = leerFilas.GetDateTime(3),
                    USUARIO = leerFilas.GetString(4),
                    CONTRA = leerFilas.GetString(5),
                    ROL = leerFilas.GetString(6)

                });


            }
            conexion.Close();
            leerFilas.Close();
            return Listar;
        }

            public DataTable Ingresar(string usuario, string contra)
        {
            SqlDataReader leerFilas;
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_INGRESAR", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@USUARIO", usuario);
            cmd.Parameters.AddWithValue("@CONTRA", contra);
            leerFilas = cmd.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.Close();
            return tabla;
            
          




        }



        public void insertarUsuario(E_usuarios usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_AGREGARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", usuario.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", usuario.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", usuario.FECHANACIMIENTO);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
            cmd.Parameters.AddWithValue("@CONTRA", usuario.CONTRA);
            cmd.Parameters.AddWithValue("@ROL", usuario.ROL);




            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        

        public void EditarUsuario(E_usuarios categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@ID", categoria.ID);
            cmd.Parameters.AddWithValue("@NOMBRE", categoria.NOMBRE);
            cmd.Parameters.AddWithValue("@APELLIDO", categoria.APELLIDO);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", categoria.FECHANACIMIENTO);
            cmd.Parameters.AddWithValue("@USUARIO", categoria.USUARIO);
            cmd.Parameters.AddWithValue("@CONTRA", categoria.CONTRA);
            cmd.Parameters.AddWithValue("@ROL", categoria.ROL);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        

        public void EliminarUsuario(E_usuarios usuario)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@ID", usuario.ID);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }

}
