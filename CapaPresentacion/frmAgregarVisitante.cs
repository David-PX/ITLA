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
    public partial class frmAgregarVisitante : Form
    {
        public frmAgregarVisitante()
        {
            InitializeComponent();

        }
        E_visitantes objEntidad = new E_visitantes();
        N_visitantes objNegocio = new N_visitantes();
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

        private void LimpiarCaja()
        {
           
                 txtNombre.Text = "";
                   txtApellido.Text = "";
                  cbxCarrera.Text = "";
                 txtCorreo.Text = "";
      
         
            txtMotivo.Text = "";
                }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if(this.openFileDialog1.FileName.Equals("") == false)
                {
                    pPerfil.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtCorreo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
      

        private void frmAgregarVisitante_Load(object sender, EventArgs e)
        {
            objNegocio.listarEdificiosEnCmb(cbxEdificio);

           
           



        }

        private void CbxEdificio_SelectedValueChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbxEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {


            

        }

        private void cbxEdificio_SelectedValueChanged(object sender, EventArgs e)
        {

           
        }

        private void cbxEdificio_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pPerfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            bool validarEmail = objNegocio.email_bien_escrito(txtCorreo.Text);


            if (validarEmail == true)
            {



                try
                {
                    objEntidad.IMAGEN = ms.GetBuffer();
                    objEntidad.NOMBRE = txtNombre.Text;
                    objEntidad.APELLIDO = txtApellido.Text;
                    objEntidad.CARRERA = cbxCarrera.Text;
                    objEntidad.CORREO = txtCorreo.Text;
                    objEntidad.IDEDIFICIO = Convert.ToInt32(cbxEdificio.SelectedValue);
                    objEntidad.IDAULA = Convert.ToInt32(cbxAula.SelectedValue);
                    objEntidad.HORAENTRADA = dt1.Value;
                    objEntidad.HORASALIDA = dt2.Value;
                    objEntidad.MOTIVOENTRADA = txtMotivo.Text;
                    objNegocio.InsertandoVisitante(objEntidad);

                    frmSuccess.confirmacionForm("Se ha guardado el estudiate con exito");
                    LimpiarCaja();
                }
                catch (Exception ez)
                {
                    //frmError.denegationForm("No se ha podido guardar el estudiante" + ez);
                    MessageBox.Show(ez.ToString());
                }
            }
            else
            {
                frmError.denegationForm("El email introducido no es valido");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCancelOrAccept.frmDobleOpcion("Seguro que desea salir?");
            if (frmCancelOrAccept.ParaEjecutar == true)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objNegocio.listarAulasEnCmb(cbxAula, Convert.ToInt32(cbxEdificio.SelectedValue));
        }
    }
}
