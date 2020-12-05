using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CapaNegocios
{
    public class N_visitantes
    {
       
        D_visitantes objDato = new D_visitantes();
        public void InsertandoVisitante(E_visitantes visitantes)
        {
            objDato.insertarVisitante(visitantes);
        }
        public void listarEdificiosEnCmb(ComboBox comboBox)
        {
            comboBox.DataSource = objDato.desplegarEdificios();

            comboBox.DisplayMember = "NOMBRE";
            comboBox.ValueMember = "ID";


        }
        public void listarAulasEnCmb(ComboBox comboBox, int idedificio)
        {
            comboBox.DataSource = objDato.desplegarAulas(idedificio);

            comboBox.DisplayMember = "NOMBRE";
            comboBox.ValueMember = "ID";


        }

        public void ListarVisitantes(int like, DataGridView data)
        {
            data.DataSource = objDato.ListarVisitantes(like);

        }

       public Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
