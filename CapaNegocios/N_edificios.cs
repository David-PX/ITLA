using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaNegocios
{
    public class N_edificios
    {
        D_edificios objDato = new D_edificios();
        public List<E_edificios> ListarEdificio(string buscar)
        {
            return objDato.ListarEdificios(buscar);
        }

        public void InsertandoEdificio(E_edificios edificio)
        {
            objDato.insertarEdificio(edificio);
        }
        public void EditandoEdificio(E_edificios edificio)
        {
            objDato.editarEdificio(edificio);

        }
        public void EliminandoEdificio(E_edificios edificio)
        {
            objDato.elminarEdificio(edificio);
        }
    }
}
