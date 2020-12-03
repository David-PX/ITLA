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
    public partial class frmSuccess : Form
    {
        public static bool ParaIngresar = false;

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
        public frmSuccess(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            ParaIngresar = true;
        }

        public static void confirmacionForm(string mensaje)
        {
            frmSuccess frm = new frmSuccess(mensaje);
            frm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
