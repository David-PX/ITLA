using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class E_edificios
    {
        int _ID;
        string _NOMBRE;
        string _ESTADO;

        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string ESTADO { get => _ESTADO; set => _ESTADO = value; }
    }
}
