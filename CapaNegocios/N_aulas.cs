using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;

namespace CapaNegocios
{
    public class N_aulas
    {
        D_aulas objDato = new D_aulas();
        public void ListarAulasYEdificios(string like, DataGridView data)
        {
            data.DataSource = objDato.ListarAulasYEdificios(like);

        }

        public void InsertandoAulas(E_aulas aulas)
        {
            objDato.insertarAulas(aulas);
        }
        public void EditandoAulas(E_aulas aulas)
        {
            objDato.editarAulas(aulas);

        }
        public void EliminandoAulas(E_aulas aulas)
        {
            objDato.elminarAulas(aulas);
        }


        public void listarEdificiosEnCmb(ComboBox comboBox)
        {
            comboBox.DataSource = objDato.desplegarEdificios();

            comboBox.DisplayMember = "NOMBRE";
            comboBox.ValueMember = "ID";


        }   
    }
}
