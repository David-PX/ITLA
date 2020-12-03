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
    public partial class frmError : Form
    {
        public frmError(string mensaje)
        {
            InitializeComponent();
            label1.Text = mensaje;
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

        private void frmError_Load(object sender, EventArgs e)
        {

        }
        public static void denegationForm(string mensaje)
        {
            frmError frm = new frmError(mensaje);
            frm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
