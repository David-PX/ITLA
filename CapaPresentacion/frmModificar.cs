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
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        E_usuarios objEntidad = new E_usuarios();
        N_usuarios objNegocios = new N_usuarios();

        // INICIO BOX SHADOW EFFECT
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        // FIN BOX SHADOW EFFECT
        public void MostrarTabla(string buscar)
        {

            N_usuarios objNegocio = new N_usuarios();
          
            dataGridView1.DataSource = objNegocio.ListandoUsuarios(buscar);
            
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmModificar_Load(object sender, EventArgs e)
        {
            MostrarTabla("");
            dataGridView1.Columns[5].Visible = false; 

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmCancelOrAccept.frmDobleOpcion("Seguo que desea eliminar?");
            if (frmCancelOrAccept.ParaEjecutar == true)
            { 
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    objEntidad.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    objNegocios.EliminandoUsuario(objEntidad);

                    frmSuccess.confirmacionForm("Se ha borrado correctamente");
                    MostrarTabla("");

                }
                else
                {
                    frmError.denegationForm("No se ha podido borrar");
                }
            }
           catch(Exception EX)
            {
                frmError.denegationForm("ha ocurrido un error " + EX);
            }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frmAgregarUsuario.Editarse = true;
                frmAgregarUsuario.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frmAgregarUsuario.NOMBRE = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frmAgregarUsuario.APELLIDO = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frmAgregarUsuario.FECHANACIMIENTO = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frmAgregarUsuario.USUARIO = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frmAgregarUsuario.CONTRA = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frmAgregarUsuario.ROL = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                frmAgregarUsuario frm = new frmAgregarUsuario();
                frm.Show();
                this.Close();



            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
