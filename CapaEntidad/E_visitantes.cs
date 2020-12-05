using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidad
{
    public class E_visitantes
    {
        int _ID;
        byte[] _IMAGEN;
        string _NOMBRE;
        string _APELLIDO;
        string _CORREO;
        string _CARRERA;
        int _IDEDIFICIO;
        int _IDAULA;
        DateTime _HORAENTRADA;
        DateTime _HORASALIDA;
        string _MOTIVOENTRADA;

        public int ID { get => _ID; set => _ID = value; }
        public byte[] IMAGEN { get => _IMAGEN; set => _IMAGEN = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDO { get => _APELLIDO; set => _APELLIDO = value; }
        public string CORREO { get => _CORREO; set => _CORREO = value; }
        public string CARRERA { get => _CARRERA; set => _CARRERA = value; }
        public int IDEDIFICIO { get => _IDEDIFICIO; set => _IDEDIFICIO = value; }
        public int IDAULA { get => _IDAULA; set => _IDAULA = value; }
        public DateTime HORAENTRADA { get => _HORAENTRADA; set => _HORAENTRADA = value; }
        public DateTime HORASALIDA { get => _HORASALIDA; set => _HORASALIDA = value; }
        public string MOTIVOENTRADA { get => _MOTIVOENTRADA; set => _MOTIVOENTRADA = value; }
    }
}
