using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_usuarios
    {
        int _ID;
        string _NOMBRE;
        string _APELLIDO;
        DateTime _FECHANACIMIENTO;
        string _USUARIO;
        string _CONTRA;
        string _ROL;

        public int ID { get => _ID; set => _ID = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public DateTime FECHANACIMIENTO { get => _FECHANACIMIENTO; set => _FECHANACIMIENTO = value; }
        public string USUARIO { get => _USUARIO; set => _USUARIO = value; }
        public string CONTRA { get => _CONTRA; set => _CONTRA = value; }
        public string ROL { get => _ROL; set => _ROL = value; }
    }
}
