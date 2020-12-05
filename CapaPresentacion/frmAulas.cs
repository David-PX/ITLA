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
    public partial class frmAulas : Form
    {
        public frmAulas()
        {
            InitializeComponent();
        }
        private string ID;
        private bool Editarse = false;
        E_aulas objEntidad = new E_aulas();
        N_aulas objNegocios = new N_aulas();
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

        private void frmAulas_Load(object sender, EventArgs e)
        {
            MostrarTabla("");
            radioButton1.Checked = true;
            objNegocios.listarEdificiosEnCmb(cbxEdificio);
        }
        public void MostrarTabla(string buscar)
        {
            N_aulas objNegocio = new N_aulas();
            objNegocio.ListarAulasYEdificios(buscar, tablaAulas);
        }
        private void limpiarCaja()
        {

            txtNombre.text = "";

            txtNombre.Focus();
            Editarse = false;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            MostrarTabla(bunifuTextbox1.text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editarse == false)
            {
                try
                {
                    objEntidad.IDEDIFICIO = Convert.ToInt32(cbxEdificio.SelectedValue);
                    objEntidad.PLANTA = cbxPlanta.Text;
                    objEntidad.NOMBRE = txtNombre.text;
                    objEntidad.ESTADO = Convert.ToString(radioButton1.Checked);

                    objNegocios.InsertandoAulas(objEntidad);
                    
                    frmSuccess.confirmacionForm("Se ha guardado el aula");
                    MostrarTabla("");
                    limpiarCaja();
                }
                catch (Exception ez)
                {
                    // frmError.denegationForm("No se ha podido agregar la aula" + ez.ToString());
                    MessageBox.Show(ez.ToString());
                }
            }
            if (Editarse == true)
            {

                try
                {
                    objEntidad.ID = Convert.ToInt32(ID);
                    objEntidad.IDEDIFICIO = Convert.ToInt32(cbxEdificio.Text);
                    objEntidad.PLANTA = cbxPlanta.Text;
                    objEntidad.NOMBRE = txtNombre.text;
                    objEntidad.ESTADO = Convert.ToString(radioButton1.Checked);

                    objNegocios.EditandoAulas(objEntidad);
                    frmSuccess.confirmacionForm("Se ha editado la aula");
                    MostrarTabla("");
                    limpiarCaja();
                    Editarse = false;
                }
                catch (Exception ex)
                {
                    frmError.denegationForm("No se ha podido editar la aula" + ex.ToString());
                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaAulas.SelectedRows.Count > 0)
            {
                Editarse = true;
                ID = tablaAulas.CurrentRow.Cells[0].Value.ToString();
                cbxEdificio.Text = tablaAulas.CurrentRow.Cells[1].Value.ToString();
                cbxPlanta.Text = tablaAulas.CurrentRow.Cells[2].Value.ToString();
                txtNombre.text = tablaAulas.CurrentRow.Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCaja();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaAulas.SelectedRows.Count > 0)
            {
                objEntidad.ID = Convert.ToInt32(tablaAulas.CurrentRow.Cells[0].Value.ToString());
                objNegocios.EliminandoAulas(objEntidad);
                frmSuccess.confirmacionForm("Se ha eliminado correctamente");
                MostrarTabla("");
                limpiarCaja();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void cbxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
