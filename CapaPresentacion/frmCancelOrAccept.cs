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
    public partial class frmCancelOrAccept : Form
    {
        public frmCancelOrAccept(string mensaje)
        {
            InitializeComponent();
            label2.Text = mensaje;
        }
        public static bool ParaEjecutar = false;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            ParaEjecutar = true;

        }


        public static void frmDobleOpcion(string mensaje)
        {
            frmCancelOrAccept frm = new frmCancelOrAccept(mensaje);
            frm.ShowDialog();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCancelOrAccept_Load(object sender, EventArgs e)
        {
            ParaEjecutar = false;
        }
    }
}
