using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        E_usuarios objEntidad = new E_usuarios();
        N_usuarios objNegocios = new N_usuarios();
        public frmLogin()
        {
            InitializeComponent();
            
            
        }

        private const int shadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = shadow;
                return cp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
           DataTable obj = objNegocios.Ingresar(txtUsuario.text, txtContra.Text);
            try
            {
                if (obj.Rows.Count > 0)
                {
                    frmSuccess.confirmacionForm("Inicio de sesio Correcto.");
                    if (frmSuccess.ParaIngresar == true) { 
                    frmMenuAdmin form = new frmMenuAdmin();
                    form.Show();
                    this.Hide();
                    }
                }
                else
                {
                    frmError.denegationForm("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
                
                
            
            
        }

        private void txtContra_OnTextChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
