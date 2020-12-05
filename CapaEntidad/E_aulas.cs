using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_aulas
    {
        int _ID;
        int _IDEDIFICIO;
        string _PLANTA;
        string _NOMBRE;
        string _ESTADO;

        public int ID { get => _ID; set => _ID = value; }
        public int IDEDIFICIO { get => _IDEDIFICIO; set => _IDEDIFICIO = value; }
        public string PLANTA { get => _PLANTA; set => _PLANTA = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string ESTADO { get => _ESTADO; set => _ESTADO = value; }
    
    }
}
