using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class N_usuarios
    {
        D_usuarios objDato = new D_usuarios();
        public DataTable Ingresar(string usuario, string contra)
        {
            return objDato.Ingresar(usuario, contra);
        }

        public List<E_usuarios> ListandoUsuarios(string like)
        {
            return objDato.listarUsuarios(like);
        }
        
        public void insertandoUsuario(E_usuarios usuario)
        {
            objDato.insertarUsuario(usuario);
        }
        
        public void EditandoUsuario(E_usuarios usuario)
        {
            objDato.EditarUsuario(usuario);

        }
        
        public void EliminandoUsuario(E_usuarios usuario)
        {
            objDato.EliminarUsuario(usuario);
        }

        


    }
}
