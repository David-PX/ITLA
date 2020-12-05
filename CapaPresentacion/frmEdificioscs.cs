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
    public partial class frmEdificioscs : Form
    {
        private string ID;
        private bool Editarse = false;
        E_edificios objEntidad = new E_edificios();
        N_edificios objNegocios = new N_edificios();
        public frmEdificioscs()
        {
            InitializeComponent();
        }

        // EFECTO BOX SHADOW INICIO
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
        //EFECTO BOX SHADOW FIN

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCancelOrAccept.frmDobleOpcion("Seguro que desea salir?");
            if (frmCancelOrAccept.ParaEjecutar == true)
            {
                this.Close();
            }
        }

        private void frmEdificioscs_Load(object sender, EventArgs e)
        {
            MostrarTabla("");
            radioButton1.Checked = true;
        }

        public void MostrarTabla(string buscar)
        {
            N_edificios objNegocio = new N_edificios();
            tablaEdificios.DataSource = objNegocio.ListarEdificio(buscar);
        }
        private void limpiarCaja()
        {

            txtNombre.text = "";

            txtNombre.Focus();
            Editarse = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.NOMBRE = txtNombre.text;
                    objEntidad.ESTADO = Convert.ToString(radioButton1.Checked);

                    objNegocios.InsertandoEdificio(objEntidad);

                    frmSuccess.confirmacionForm("Se ha guardado el edificio");
                    MostrarTabla("");
                    limpiarCaja();
                }
                catch (Exception ez)
                {
                    frmError.denegationForm("No se ha podido agregar el edificio" + ez.ToString());
                }
            }
            if (Editarse == true)
            {

                try
                {
                    objEntidad.ID = Convert.ToInt32(ID);
                    objEntidad.NOMBRE = txtNombre.text.ToString();
                    objEntidad.ESTADO = radioButton1.Checked.ToString();

                    objNegocios.EditandoEdificio(objEntidad);
                    frmSuccess.confirmacionForm("Se ha editado el edificio");
                    MostrarTabla("");
                    limpiarCaja();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    frmError.denegationForm("No se ha podido editar el edificio" + ex.ToString());
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaEdificios.SelectedRows.Count > 0)
            {
                Editarse = true;
                ID = tablaEdificios.CurrentRow.Cells[0].Value.ToString();
                txtNombre.text = tablaEdificios.CurrentRow.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaEdificios.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(tablaEdificios.CurrentRow.Cells[0].Value.ToString());
                objNegocios.EliminandoEdificio(objEntidad);
                frmSuccess.confirmacionForm("Se ha eliminado correctamente");
                MostrarTabla("");
                limpiarCaja();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            MostrarTabla(bunifuTextbox1.text);
        }
    }
}
