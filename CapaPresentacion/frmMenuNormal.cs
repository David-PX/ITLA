using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuNormal : Form
    {
        public frmMenuNormal()
        {
            InitializeComponent();

        }
        public void PantallaCompleta()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuNormal_Load(object sender, EventArgs e)
        {
            PantallaCompleta();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            subMenuOpciones.Visible = false;
            frmCancelOrAccept.frmDobleOpcion("¿Seguro que desea salir de sesion?");
            if (frmCancelOrAccept.ParaEjecutar == true)
            {
                this.Close();
                frmLogin frm = new frmLogin();
                frm.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            subMenuOpciones.Visible = false;
            frmCancelOrAccept.frmDobleOpcion("¿Seguro que desea cerrar la aplicacion?");
            if (frmCancelOrAccept.ParaEjecutar == true)
            {
                Application.Exit();
            }
        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = true;
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            subMenuOpciones.Visible = true;
        }

        private void agregarVisitante_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmAgregarVisitante frm = new frmAgregarVisitante();
            frm.Show();
        }

        private void verVisitantes_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmVerVisitantes frm = new frmVerVisitantes();
            frm.Show();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora.Text = DateTime.Now.ToLongDateString();
        }
    }
}
