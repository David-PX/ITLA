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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        public void PantallaCompleta()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            PantallaCompleta();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHora.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = true;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            subMenuOpciones.Visible = true;
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = true;
        }

        private void agregarUusarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = false;
            frmAgregarUsuario frm = new frmAgregarUsuario();
            frm.Show();
        }

        private void modificarUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = false;
            frmModificar frm = new frmModificar();
            frm.Show();

        }

        private void verUsuarios_Click(object sender, EventArgs e)
        {
            subMenuUsuarios.Visible = false;
        }

        private void agregarVisitante_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmAgregarVisitante frm = new frmAgregarVisitante();
            frm.Show();
        }
        private void modificarVisitantes_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
        }

        private void verVisitantes_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmVerVisitantes frm = new frmVerVisitantes();
            frm.Show();
        }

        private void btnEdificios_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmEdificioscs frm = new frmEdificioscs();
            frm.Show();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            subMenuVisitantes.Visible = false;
            frmAulas frm = new frmAulas();
            frm.Show();
        }

        private void center_MouseClick(object sender, MouseEventArgs e)
        {
            subMenuVisitantes.Visible = false;
            subMenuOpciones.Visible = false;
            subMenuUsuarios.Visible = false;
        }

        private void center_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
